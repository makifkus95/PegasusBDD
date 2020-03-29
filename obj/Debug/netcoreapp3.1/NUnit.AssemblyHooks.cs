using System.CodeDom.Compiler;
using System.Diagnostics;
using global::NUnit.Framework;
using global::TechTalk.SpecFlow;

[GeneratedCode("SpecFlow", "3.1.89")]
[SetUpFixture]
public class PegasusBDD_NUnitAssemblyHooks
{
    [OneTimeSetUp]
    public void AssemblyInitialize()
    {
        var currentAssembly = typeof(PegasusBDD_NUnitAssemblyHooks).Assembly;

        TestRunnerManager.OnTestRunStart(currentAssembly);
    }

    [OneTimeTearDown]
    public void AssemblyCleanup()
    {
        var currentAssembly = typeof(PegasusBDD_NUnitAssemblyHooks).Assembly;

        TestRunnerManager.OnTestRunEnd(currentAssembly);
    }
}
