﻿using NUnit.Framework;

namespace DryIoc.IssuesTests
{
    [TestFixture]
    public class Issue110_SupportContravarianceInResolveMany
    {
        [Test]
        public void Resolve_many_should_return_matching_contvariant_generic_service()
        {
            var eventHandler = new EventHandler();
            var eventInfo = new FiredEventInfo();

            var eventProvider = new DryIocEventProvider();
            eventProvider.AddHandler(eventHandler);

            eventProvider.FireEvent<IHandledEventInfo>(eventInfo);
            Assert.AreEqual(1, eventHandler.HandledCount);

            eventProvider.FireEvent(eventInfo);
            Assert.AreEqual(2, eventHandler.HandledCount);
        }
    }

    interface IEventInfo { }

    interface IHandledEventInfo : IEventInfo { }

    class FiredEventInfo : IHandledEventInfo { }

    interface IEventHandler<in EventInfoType>
        where EventInfoType : IEventInfo
    {
        void Handle(EventInfoType eventInfo);
    }

    class EventHandler : IEventHandler<IHandledEventInfo>
    {
        public int HandledCount { get; private set; }

        public void Handle(IHandledEventInfo eventInfo)
        {
            ++HandledCount;
        }
    }

    interface IEventProvider
    {
        string Name { get; }

        void AddHandler<EventInfoType>(IEventHandler<EventInfoType> eventHandler)
            where EventInfoType : IEventInfo;

        void FireEvent<EventInfoType>(EventInfoType eventInfo)
            where EventInfoType : IEventInfo;
    }

    class DryIocEventProvider : IEventProvider
    {
        IContainer _dryContainer = new Container();

        public string Name { get { return "DryIoc"; } }

        public void AddHandler<EventInfoType>(IEventHandler<EventInfoType> eventHandler)
            where EventInfoType : IEventInfo
        {
            _dryContainer.RegisterInstance(eventHandler);
        }

        public void FireEvent<EventInfoType>(EventInfoType eventInfo)
            where EventInfoType : IEventInfo
        {
            var eventHandlers = _dryContainer.ResolveMany<IEventHandler<EventInfoType>>();
            foreach (var eventHandler in eventHandlers)
            {
                eventHandler.Handle(eventInfo);
            }
        }
    }
}
