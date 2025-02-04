using System;
using System.Windows.Forms;
// <copyright file="PexAssemblyInfo.cs" company="ALT + F4">Copyright ©Info@IT  2019</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("Info@IT")]
[assembly: PexInstrumentAssembly("DAL")]
[assembly: PexInstrumentAssembly("System.Data")]
[assembly: PexInstrumentAssembly("System.Drawing")]
[assembly: PexInstrumentAssembly("System.Windows.Forms")]
[assembly: PexInstrumentAssembly("BAL")]
[assembly: PexInstrumentAssembly("Bunifu_UI_v1.52")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "DAL")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Data")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Drawing")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Windows.Forms")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "BAL")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Bunifu_UI_v1.52")]
[assembly: PexInstrumentType("mscorlib", "System.CultureAwareComparer")]
[assembly: PexInstrumentType(typeof(WeakReference<ToolStripControlHost>))]
[assembly: PexInstrumentAssembly("System.Configuration")]
[assembly: PexInstrumentType(typeof(OperatingSystem))]
[assembly: PexInstrumentType(typeof(WeakReference<ToolStripControlHost>))]
[assembly: PexInstrumentType(typeof(WeakReference<ToolStripControlHost>))]

