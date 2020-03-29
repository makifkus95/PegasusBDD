// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PegasusBDD.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute(TestName="PegasusBDD")]
    [NUnit.Framework.DescriptionAttribute("PegasusBDD")]
    public partial class PegasusBDDFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Feature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PegasusBDD", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestCaseAttribute(TestName="SenaryoOne")]
        [NUnit.Framework.DescriptionAttribute("SenaryoOne")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void SenaryoOne()
        {
            string[] tagsOfScenario = new string[] {
                    "mytag"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SenaryoOne", null, new string[] {
                        "mytag"});
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
 testRunner.And("2 saniye bekle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 7
 testRunner.And("\'//*[@id=\'fligth-searh\']/div[2]/div[1]/div/span/span[1]/span/span[2]\' objesine tı" +
                        "klanır..", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 8
 testRunner.And("\'select2-search__field\' objesine \'istanbul-\' yazılır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 9
 testRunner.And("\'//*[@id=\'fligth-searh\']/div[2]/div[2]/div/span/span[1]/span/span[2]\' objesine tı" +
                        "klanır..", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 10
 testRunner.And("\'select2-search__field\' objesine \'kayseri\' yazılır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 11
 testRunner.And("\'//*[@id=\'fligth-searh\']/div[3]/div[1]/div/div[1]/span\' objesine tıklanır..", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 12
 testRunner.And("\'Gidiş Bilet\' seçimi \'10.Mayıs.2020\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 13
 testRunner.And("\'Dönüş Bileti\' seçimi \'23.Kasım.2020\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 14
 testRunner.And("2 saniye bekle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 15
 testRunner.And("\'//*[@id=\'flight\']//button\' objesine tıklanır..", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 16
 testRunner.And("\'Gidiş için\' uçuş seçimi yapılır. \'//*[@id=\'boarding-card-body\']/div[1]/div[3]/di" +
                        "v[2]/div[2]/div[2]/div[1]\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 17
 testRunner.And("\'Gidiş için\' Ekonomik paket seçimi yapılır. \'//*[@id=\'boarding-card-body\']/div[1]" +
                        "/div[3]/div[2]/div[2]/div[2]/div[1]/div/div[2]/div[1]/button/div[2]/div\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 18
 testRunner.And("2 saniye bekle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 19
 testRunner.And("\'Dönüş için\' uçuş seçimi yapılır. \'//*[@id=\"boarding-card-body\"]/div[1]/div[3]/di" +
                        "v[3]/div[2]/div[2]/div[1]\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 20
 testRunner.And("\'Döüş için\' Ekonomik paket seçimi yapılır. \'//*[@id=\"boarding-card-body\"]/div[1]/" +
                        "div[3]/div[3]/div[2]/div[2]/div[1]/div/div[2]/div[1]/button/div[2]/div\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 21
 testRunner.And("3 saniye bekle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion