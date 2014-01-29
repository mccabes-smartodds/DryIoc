﻿using System;
using NUnit.Framework;

namespace DryIoc.Playground
{
    [TestFixture]
    //[Ignore]
    public class HashArrayMappedTrieTests
    {
        [Test]
        public void Test_how_int_hash_code_is_working_at_edge_cases()
        {
            // Hash code for negative is still negative and equal to key
            Assert.AreEqual(-7, -7.GetHashCode());
        }

        [Test]
        public void Create_trie_and_add_value_to_it()
        {
            var trie = HashTrie<string>.Empty;
            trie = trie.AddOrUpdate(705, "a");
            trie = trie.AddOrUpdate(706, "b");
            trie = trie.AddOrUpdate(750, "c");
            trie = trie.AddOrUpdate(705, "A");
            trie = trie.AddOrUpdate(0, "0x");
            trie = trie.AddOrUpdate(5, "5x");
            trie = trie.AddOrUpdate(555555555, "55x");
            trie = trie.AddOrUpdate(750, "C");

            Assert.AreEqual(null, trie.GetValueOrDefault(13));
            Assert.AreEqual("C", trie.GetValueOrDefault(750));
            Assert.AreEqual("0x", trie.GetValueOrDefault(0));
            Assert.AreEqual("A", trie.GetValueOrDefault(705));
            Assert.AreEqual("55x", trie.GetValueOrDefault(555555555));
            Assert.AreEqual(null, trie.GetValueOrDefault(-1));
        }
    }

    public sealed class HashTrie<V>
    {
        public static HashTrie<V> Empty = new HashTrie<V>();

        public V GetValueOrDefault(int key, V defaultValue = default (V))
        {
            return _root.GetValueOrDefault(key, defaultValue);
        }

        public HashTrie<V> AddOrUpdate(int key, V value)
        {
            return new HashTrie<V>(_root.AddOrUpdate(key, value));
        }

        private readonly Node _root;

        private HashTrie(Node root = null)
        {
            _root = root ?? Node.EmptyNode;
        }

        private sealed class Node
        {
            public static readonly Node EmptyNode = new Node();

            public V GetValueOrDefault(int hash, V defaultValue)
            {
                var index = hash & LEVEL_MASK; // index from 0 to 31
                var indexBit = (uint)1 << index;
                if ((_indexBitmap & indexBit) == 0)
                    return defaultValue;

                // get node or value by looking at real index
                var pastIndexBitmap = _indexBitmap >> index;
                var realIndex = pastIndexBitmap == 1 ? _nodes.Length - 1 // the last bit matched, that means index is the last
                    : _nodes.Length - GetSetBitsCount(pastIndexBitmap);

                var valueOrNode = _nodes[realIndex];
                if (!(valueOrNode is Node))
                    return (V)valueOrNode;

                var restOfHash = hash >> LEVEL_BITS;
                return restOfHash == 0 ? defaultValue
                    : ((Node)valueOrNode).GetValueOrDefault(restOfHash, defaultValue);
            }

            public Node AddOrUpdate(int hash, V value)
            {
                var index = hash & LEVEL_MASK; // index from 0 to 31

                // get value or node
                var restOfHash = hash >> LEVEL_BITS;
                var valueOrNode = restOfHash == 0 ? (object)value : EmptyNode.AddOrUpdate(restOfHash, value);

                // insert or update node
                var indexBit = (uint)1 << index;
                if (_nodes == null)
                    return new Node(new[] { valueOrNode }, indexBit);

                // find real index where to insert into new nodes
                var pastIndexBitmap = _indexBitmap >> index;
                var pastIndexCount = pastIndexBitmap == 0 ? 0 : GetSetBitsCount(pastIndexBitmap);
                var realIndex = _nodes.Length - pastIndexCount;

                // insert:
                if ((_indexBitmap & indexBit) == 0)
                {
                    // otherwise copy old nodes with extra room for new node
                    var nodesToInsert = new object[_nodes.Length + 1];

                    // Copy up to index, set node to index, and copy past of index nodes.
                    if (realIndex != 0)
                        Array.Copy(_nodes, 0, nodesToInsert, 0, realIndex);
                    nodesToInsert[realIndex] = valueOrNode;
                    if (pastIndexCount != 0)
                        Array.Copy(_nodes, realIndex, nodesToInsert, realIndex + 1, pastIndexCount);

                    return new Node(nodesToInsert, _indexBitmap | indexBit);
                }

                // update:
                // copy nodes and replace value at index
                var nodesToUpdate = new object[_nodes.Length];
                if (nodesToUpdate.Length > 1)
                    Array.Copy(_nodes, 0, nodesToUpdate, 0, nodesToUpdate.Length);
                nodesToUpdate[realIndex] = valueOrNode;

                return new Node(nodesToUpdate, _indexBitmap);
            }

            private const int LEVEL_MASK = 31;  // Hash mask to find hash part on each trie level.
            private const int LEVEL_BITS = 5;   // Number of bits from hash corresponding to one level.
            
            private readonly object[] _nodes;   // Up to 32 nodes: sub nodes or values.
            private readonly uint _indexBitmap; // Bits indicating nodes at what index are in use.

            private Node() { }

            private Node(object[] nodes, uint indexBitmap)
            {
                _nodes = nodes;
                _indexBitmap = indexBitmap;
            }

            // http://www-graphics.stanford.edu/~seander/bithacks.html#CountBitsSetKernighan
            private static int GetSetBitsCount(uint i)
            {
                var count = 0;
                while (i != 0)
                {
                    i &= i - 1;
                    ++count;
                }
                return count;
            }

            // variable-precision SWAR algorithm http://playingwithpointers.com/swar.html
            //private static int GetSetBitsCountSWAR(uint i)
            //{
            //    i = i - ((i >> 1) & 0x55555555);
            //    i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            //    return (int)((((i + (i >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24);
            //}
        }
    }

    public static class Bits
    {
        private const int BITS_NUMBER = 32;

        public static string PrintBits(this uint key)
        {
            var bits = new char[BITS_NUMBER];
            var test = key;
            for (var i = BITS_NUMBER - 1; i >= 0; i--)
            {
                bits[i] = (test & 1) == 1 ? '1' : '0';
                test >>= 1;
            }

            return new string(bits);
        }
    }
}
