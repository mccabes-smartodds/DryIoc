﻿
namespace DryIoc.MefAttributedModel.CompileTimeAssemblyScan.Tests
{
    public static class CompileTimeGeneratedRegistrator
    {
        public static readonly ExportedRegistrationInfo[] Registrations =
        {

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Service),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Service), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.AnotherService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.AnotherService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransientService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ITransientService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Transient,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SingletonService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ISingletonService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SingletonOpenGenericService<>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IOpenGenericService<>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransientOpenGenericService<>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransientOpenGenericService<>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Transient,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OpenGenericServiceWithTwoParameters<,>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OpenGenericServiceWithTwoParameters<,>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DependentService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DependentService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OneTransientService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMultipleImplentations), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Transient,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.AnotherTransientService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMultipleImplentations), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Transient,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OneServiceWithMetadata),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMetadata), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.AnotherServiceWithMetadata),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMetadata), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Transient,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.YetAnotherServiceWithMetadata),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMetadata), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Transient,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithMultipleCostructors),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithMultipleCostructors), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithMultipleCostructorsAndOneImporting),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithMultipleCostructorsAndOneImporting), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SingleServiceWithMetadata),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SingleServiceWithMetadata), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithImportedCtorParameter),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithImportedCtorParameter), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.INamedService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.AnotherNamedService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.INamedService), "blah", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DbMan),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DbMan), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ISomeDb), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IAnotherDb), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DbMan<>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DbMan<>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ISomeDb<>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UseLazyEnumerable),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UseLazyEnumerable), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Me),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Me), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Transient,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LazyDepClient),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LazyDepClient), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Transient,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LazyDep),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LazyDep), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Transient,
        ReuseName = null,
        OpenResolutionScope = true,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject1),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IExportConditionInterface), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = true,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ForImportCondition1ParentAttribute)
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject2),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IExportConditionInterface), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ForImportCondition2ParentAttribute)
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject3),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IExportConditionInterface), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = true,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ForImportCondition3ParentAttribute)
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject1),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject1), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject2),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject2), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject3),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject3), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.A),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.A), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Transient,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = true,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.B),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.B), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Transient,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithReuseAttribute),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithReuseAttribute), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Transient,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithSingletonReuse),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithSingletonReuse), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithCurrentScopeReuse),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithCurrentScopeReuse), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.CurrentScope,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithResolutionScopeReuse),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithResolutionScopeReuse), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.ResolutionScope,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UserOfServiceWithResolutionScopeReuse),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UserOfServiceWithResolutionScopeReuse), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.ResolutionScope,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithNamedCurrentScope),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithNamedCurrentScope), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.CurrentScope,
        ReuseName = "ScopeA",
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WeaklyReferencedService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WeaklyReferencedService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = true,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PreventDisposalService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PreventDisposalService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = true,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DTUser),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DTUser), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DT),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DT), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Transient,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = true,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DT2),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DT2), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Transient,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = true,
        TrackDisposableTransient = true,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.A1),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.A1), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IntItem),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IntItem), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IItem<System.Int32>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Item<>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Item<>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IItem<>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.CompositeItem<>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.CompositeItem<>), "root", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IItem<>), "root", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.AllOpts),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IAllOpts), "a", DryIoc.IfAlreadyRegistered.Keep),
            },
        Reuse = DryIocAttributes.ReuseType.CurrentScope,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.AllOpts2),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IAllOpts), "a", DryIoc.IfAlreadyRegistered.Keep),
            },
        Reuse = DryIocAttributes.ReuseType.CurrentScope,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedScopeService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedScopeService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.CurrentScope,
        ReuseName = "a",
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiCtorDep),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiCtorDep), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiCtorSample),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiCtorSample), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PrintToCodeExample),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PrintToCodeExample), 1, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IPrintToCode), 1, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ClientWithPrimitiveParameter),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ClientWithPrimitiveParameter), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ClientWithServiceAndPrimitiveProperty),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ClientWithServiceAndPrimitiveProperty), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FastHandler),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FastHandler), "fast", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), "fast", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SlowHandler),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SlowHandler), "slow", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), "slow", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransactHandler),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransactHandler), "transact", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), "transact", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LoggingHandlerDecorator),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LoggingHandlerDecorator), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = null,
Decorator = new DecoratorInfo("slow")
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.RetryHandlerDecorator),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.RetryHandlerDecorator), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = null,
Decorator = new DecoratorInfo(null)
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransactHandlerDecorator),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransactHandlerDecorator), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = null,
Decorator = new DecoratorInfo("transact")
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.CustomHandlerDecorator),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.CustomHandlerDecorator.ForSlowHandler),
Decorator = new DecoratorInfo(null)
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DecoratorWithFastHandlerImport),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DecoratorWithFastHandlerImport), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = null,
Decorator = new DecoratorInfo(null)
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BlahHandler),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), DryIoc.MefAttributedModel.UnitTests.CUT.BlahFooh.Blah, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FoohHandler),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FoohHandler), DryIoc.MefAttributedModel.UnitTests.CUT.BlahFooh.Fooh, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), DryIoc.MefAttributedModel.UnitTests.CUT.BlahFooh.Fooh, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FoohDecorator),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FoohDecorator), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = null,
Decorator = new DecoratorInfo(DryIoc.MefAttributedModel.UnitTests.CUT.BlahFooh.Fooh)
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DecoratedResult),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDecoratedResult), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Transient,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FuncDecorator),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDecoratedResult), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = null,
Decorator = new DecoratorInfo(null)
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DynamicDecorator),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDecoratedResult), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Transient,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = true,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = null,
Decorator = new DecoratorInfo(null)
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceAReal),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceA), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceADecoratorInner),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceA), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = null,
Decorator = new DecoratorInfo(null)
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceADecoratorOuter),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceA), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Decorator,
        ConditionType = null,
Decorator = new DecoratorInfo(null)
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FactoryConsumer),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FactoryConsumer), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.One),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.One), "one", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.One), "two", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DryFactory<>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DryFactory<>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IFactory<>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Wrapper,
        ConditionType = null,
        Wrapper = new WrapperInfo { WrappedServiceTypeGenericArgIndex = -1 }
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FactoryWithArgsConsumer),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FactoryWithArgsConsumer), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Two),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Two), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DryFactory<,>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DryFactory<,>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IFactory<,>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Wrapper,
        ConditionType = null,
        Wrapper = new WrapperInfo { WrappedServiceTypeGenericArgIndex = 1 }
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OrangeFactory),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OrangeFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Orange),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Orange), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
new FactoryMethodInfo { DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OrangeFactory),
MemberName = "Create",
new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OrangeFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed)
}
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FruitFactory),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FruitFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Orange),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Orange), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
new FactoryMethodInfo { DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FruitFactory),
MemberName = "CreateOrange",
new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FruitFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed)
}
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Apple),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Apple), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
new FactoryMethodInfo { DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FruitFactory),
MemberName = "CreateApple",
new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FruitFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed)
}
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedFruitFactory),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedFruitFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Orange),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Orange), "orange", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
new FactoryMethodInfo { DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedFruitFactory),
MemberName = "CreateOrange",
new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedFruitFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed)
}
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Apple),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Apple), "apple", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
new FactoryMethodInfo { DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedFruitFactory),
MemberName = "CreateApple",
new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedFruitFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed)
}
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransientOrangeFactory),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransientOrangeFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Orange),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Orange), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Transient,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
new FactoryMethodInfo { DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransientOrangeFactory),
MemberName = "Create",
new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransientOrangeFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed)
}
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FuncFactory),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FuncFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(System.Func<System.String, DryIoc.MefAttributedModel.UnitTests.CUT.Orange>),
        Exports = new[] {
            new ExportInfo(typeof(System.Func<System.String, DryIoc.MefAttributedModel.UnitTests.CUT.Orange>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
new FactoryMethodInfo { DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FuncFactory),
MemberName = "Create",
new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FuncFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed)
}
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BirdFactory),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BirdFactory), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Duck),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Duck), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
new FactoryMethodInfo { DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BirdFactory),
MemberName = "GetDuck"
}
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Chicken),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Chicken), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
new FactoryMethodInfo { DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BirdFactory),
MemberName = "Chicken"
}
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Chicken),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Chicken), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
new FactoryMethodInfo { DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.StaticBirdFactory),
MemberName = "Chicken"
}
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Duck),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Duck), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
new FactoryMethodInfo { DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.StaticBirdFactory),
MemberName = "Duck"
}
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.KeyedFactoryWithString),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.KeyedFactoryWithString), "hey", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(System.String),
        Exports = new[] {
            new ExportInfo(typeof(System.String), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
new FactoryMethodInfo { DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.KeyedFactoryWithString),
MemberName = "GetValue",
new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.KeyedFactoryWithString), "hey", DryIoc.IfAlreadyRegistered.AppendNotKeyed)
}
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.KeyClient),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.KeyClient), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.KeyService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IService), DryIoc.MefAttributedModel.UnitTests.CUT.ServiceKey.One, DryIoc.IfAlreadyRegistered.Throw),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OtherKeyService),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OtherKeyService), DryIoc.MefAttributedModel.UnitTests.CUT.ServiceKey.OtherOne, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IService), DryIoc.MefAttributedModel.UnitTests.CUT.ServiceKey.OtherOne, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithBothTheSameExports),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithBothTheSameExports), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedOne),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedOne), "blah", DryIoc.IfAlreadyRegistered.Keep),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.INamed), "blah", DryIoc.IfAlreadyRegistered.Keep),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IOne), "blah", DryIoc.IfAlreadyRegistered.Keep),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BothExportManyAndExport),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.INamed), "named", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BothExportManyAndExport), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.INamed), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IOne), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NativeUser),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NativeUser), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Transient,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.HomeUser),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.HomeUser), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithFieldAndProperty),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithFieldAndProperty), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OneDependsOnExternalTool),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OneDependsOnExternalTool), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OtherDependsOnExternalTool),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OtherDependsOnExternalTool), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithUnregisteredExternalDependency),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithUnregisteredExternalDependency), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BCryptPasswordHasher),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IPasswordHasher), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SCryptPasswordHasher),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IPasswordHasher), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Rfc2898PasswordHasher),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IPasswordHasher), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PasswordVerifier1),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PasswordVerifier1), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PasswordVerifier2),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PasswordVerifier2), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PasswordVerifier3),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PasswordVerifier3), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PasswordVerifier4),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PasswordVerifier4), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SomeDep),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDep), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.RequiresManyOfType),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.RequiresManyOfType), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BlahDep),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDep), "blah", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.HuhDep),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDep), "huh", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.RequiresManyOfName),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.RequiresManyOfName), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.RequiresManyOfMeta),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.RequiresManyOfMeta), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FooHey),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FooHey), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IFooService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FooBlah),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FooBlah), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IFooService), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = true,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FooConsumerNotFound),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FooConsumerNotFound), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ForExport),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IForExport), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ForExportBaseImpl),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ForExportBase), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported), "a", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported), "c", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IMultiExported), "c", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported), "b", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IMultiExported), "i", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IMultiExported), "j", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = true,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ILogTableManager),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ILogTableManager), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ILogTableManager), "LogTableManagerFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
new FactoryMethodInfo { DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LogTableManager),
MemberName = "Create",
new Type[] {
typeof(System.String)
}
}
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LogTableManagerConsumer1),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LogTableManagerConsumer1), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LogTableManagerConsumer2),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LogTableManagerConsumer2), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Constants),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Constants), "SN.InstanceFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(System.String),
        Exports = new[] {
            new ExportInfo(typeof(System.String), "ExportedSetting", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
new FactoryMethodInfo { DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Constants),
MemberName = "ExportedValue",
new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Constants), "SN.InstanceFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed)
}
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Provider),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Provider), "SN.InstanceFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Abc),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Abc), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
new FactoryMethodInfo { DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Provider),
MemberName = "ExportedValue",
new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Provider), "SN.InstanceFactory", DryIoc.IfAlreadyRegistered.AppendNotKeyed)
}
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SettingImportHelper),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SettingImportHelper), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PrivateConsumer),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDummyServiceConsumer), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Daah.Fooh<>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Daah.Fooh<>), "a", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Daah.FoohFactory<>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Daah.FoohFactory<>), null, DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null
    }, 

    new ExportedRegistrationInfo {
        ImplementationType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Daah.Fooh<>),
        Exports = new[] {
            new ExportInfo(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Daah.Fooh<>), "b", DryIoc.IfAlreadyRegistered.AppendNotKeyed),
            },
        Reuse = DryIocAttributes.ReuseType.Singleton,
        ReuseName = null,
        OpenResolutionScope = false,
        AsResolutionCall = false,
        AsResolutionRoot = false,
        PreventDisposal = false,
        WeaklyReferenced = false,
        AllowDisposableTransient = false,
        TrackDisposableTransient = false,
        UseParentReuse = false,
        HasMetadataAttribute = false,
        FactoryType = DryIoc.FactoryType.Service,
        ConditionType = null,
new FactoryMethodInfo { DeclaringType = typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Daah.FoohFactory<>),
MemberName = "Create",
new Type[] {
typeof(A)
}
}
    }, 
        };
    }
}