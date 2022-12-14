// <copyright file="PexAssemblyInfo.cs">Copyright ©  2021</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "NUnit3")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("StockWatcher.ViewModels")]
[assembly: PexInstrumentAssembly("FluentValidation")]
[assembly: PexInstrumentAssembly("System.Core")]
[assembly: PexInstrumentAssembly("FancyCandles")]
[assembly: PexInstrumentAssembly("Microsoft.Toolkit.Mvvm")]
[assembly: PexInstrumentAssembly("StockWatcher.Services")]
[assembly: PexInstrumentAssembly("StockWatcher.Models")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "FluentValidation")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "FancyCandles")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.Toolkit.Mvvm")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "StockWatcher.Services")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "StockWatcher.Models")]

