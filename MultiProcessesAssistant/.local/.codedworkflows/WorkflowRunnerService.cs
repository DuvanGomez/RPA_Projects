using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using MultiprocessesAssistant;

[assembly: WorkflowRunnerServiceAttribute(typeof(MultiprocessesAssistant.WorkflowRunnerService))]
namespace MultiprocessesAssistant
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Tests/ProcessTestCase.xaml
        /// </summary>
        public void ProcessTestCase(System.Collections.Generic.IDictionary<string, object> cXC_DynamicData)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\ProcessTestCase.xaml", new Dictionary<string, object>{{"cXC_DynamicData", cXC_DynamicData}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/ProcessTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ProcessTestCase(System.Collections.Generic.IDictionary<string, object> cXC_DynamicData, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\ProcessTestCase.xaml", new Dictionary<string, object>{{"cXC_DynamicData", cXC_DynamicData}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Modules/DataTest/SyntheticTestData.xaml
        /// </summary>
        public void SyntheticTestData()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Modules\DataTest\SyntheticTestData.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Modules/DataTest/SyntheticTestData.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void SyntheticTestData(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Modules\DataTest\SyntheticTestData.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/WorkflowTestCaseTemplate.xaml
        /// </summary>
        public void WorkflowTestCaseTemplate()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\WorkflowTestCaseTemplate.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/WorkflowTestCaseTemplate.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void WorkflowTestCaseTemplate(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\WorkflowTestCaseTemplate.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/MainTestCase.xaml
        /// </summary>
        public void MainTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\MainTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/MainTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void MainTestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\MainTestCase.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Modules/CXCProcess.xaml
        /// </summary>
        public void CXCProcess(string in_NewFilePath, System.Data.DataTable in_dtTemplateFields, System.Collections.Generic.Dictionary<string, object> in_dictTransactionItemData)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Modules\CXCProcess.xaml", new Dictionary<string, object>{{"in_NewFilePath", in_NewFilePath}, {"in_dtTemplateFields", in_dtTemplateFields}, {"in_dictTransactionItemData", in_dictTransactionItemData}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Modules/CXCProcess.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CXCProcess(string in_NewFilePath, System.Data.DataTable in_dtTemplateFields, System.Collections.Generic.Dictionary<string, object> in_dictTransactionItemData, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Modules\CXCProcess.xaml", new Dictionary<string, object>{{"in_NewFilePath", in_NewFilePath}, {"in_dtTemplateFields", in_dtTemplateFields}, {"in_dictTransactionItemData", in_dictTransactionItemData}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main(string in_OrchestratorQueueName, string in_OrchestratorQueueFolder, string in_ProcessDescription, string in_ExecuteDispatcher)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{{"in_OrchestratorQueueName", in_OrchestratorQueueName}, {"in_OrchestratorQueueFolder", in_OrchestratorQueueFolder}, {"in_ProcessDescription", in_ProcessDescription}, {"in_ExecuteDispatcher", in_ExecuteDispatcher}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Main(string in_OrchestratorQueueName, string in_OrchestratorQueueFolder, string in_ProcessDescription, string in_ExecuteDispatcher, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{{"in_OrchestratorQueueName", in_OrchestratorQueueName}, {"in_OrchestratorQueueFolder", in_OrchestratorQueueFolder}, {"in_ProcessDescription", in_ProcessDescription}, {"in_ExecuteDispatcher", in_ExecuteDispatcher}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/InitAllSettingsTestCase.xaml
        /// </summary>
        public void InitAllSettingsTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllSettingsTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/InitAllSettingsTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void InitAllSettingsTestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllSettingsTestCase.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Modules/CXCProcess - Copy (1).xaml
        /// </summary>
        public void CXCProcess___Copy__1_(string in_NewFilePath, UiPath.Core.QueueItem in_TransactionItem, System.Data.DataTable in_dtTemplateFields, System.Collections.Generic.Dictionary<string, object> in_dictTransactionItemData)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Modules\CXCProcess - Copy (1).xaml", new Dictionary<string, object>{{"in_NewFilePath", in_NewFilePath}, {"in_TransactionItem", in_TransactionItem}, {"in_dtTemplateFields", in_dtTemplateFields}, {"in_dictTransactionItemData", in_dictTransactionItemData}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Modules/CXCProcess - Copy (1).xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CXCProcess___Copy__1_(string in_NewFilePath, UiPath.Core.QueueItem in_TransactionItem, System.Data.DataTable in_dtTemplateFields, System.Collections.Generic.Dictionary<string, object> in_dictTransactionItemData, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Modules\CXCProcess - Copy (1).xaml", new Dictionary<string, object>{{"in_NewFilePath", in_NewFilePath}, {"in_TransactionItem", in_TransactionItem}, {"in_dtTemplateFields", in_dtTemplateFields}, {"in_dictTransactionItemData", in_dictTransactionItemData}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Modules/ConvertNumberToText_TestCase.xaml
        /// </summary>
        public void ConvertNumberToText_TestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Modules\ConvertNumberToText_TestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Modules/ConvertNumberToText_TestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ConvertNumberToText_TestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Modules\ConvertNumberToText_TestCase.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Mocks/Modules/ConvertNumberToText_mock.xaml
        /// </summary>
        public string ConvertNumberToText_mock(int in_AmountNeto)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Mocks\Modules\ConvertNumberToText_mock.xaml", new Dictionary<string, object>{{"in_AmountNeto", in_AmountNeto}}, default, default, default, GetAssemblyName());
            return (string)result["out_AmountNetoText"];
        }

        /// <summary>
        /// Invokes the Mocks/Modules/ConvertNumberToText_mock.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string ConvertNumberToText_mock(int in_AmountNeto, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Mocks\Modules\ConvertNumberToText_mock.xaml", new Dictionary<string, object>{{"in_AmountNeto", in_AmountNeto}}, default, isolated, default, GetAssemblyName());
            return (string)result["out_AmountNetoText"];
        }

        /// <summary>
        /// Invokes the test_AdvanceDataManipulation.xaml
        /// </summary>
        public void test_AdvanceDataManipulation()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"test_AdvanceDataManipulation.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the test_AdvanceDataManipulation.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void test_AdvanceDataManipulation(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"test_AdvanceDataManipulation.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/Dispatcher_TestCase.xaml
        /// </summary>
        public void Dispatcher_TestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\Dispatcher_TestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/Dispatcher_TestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Dispatcher_TestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\Dispatcher_TestCase.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Modules/Dispatcher.xaml
        /// </summary>
        public void Dispatcher(string in_SheetName, string in_FilePath)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Modules\Dispatcher.xaml", new Dictionary<string, object>{{"in_SheetName", in_SheetName}, {"in_FilePath", in_FilePath}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Modules/Dispatcher.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Dispatcher(string in_SheetName, string in_FilePath, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Modules\Dispatcher.xaml", new Dictionary<string, object>{{"in_SheetName", in_SheetName}, {"in_FilePath", in_FilePath}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Modules/ConvertNumberToText.xaml
        /// </summary>
        public string ConvertNumberToText(int in_AmountNeto)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Modules\ConvertNumberToText.xaml", new Dictionary<string, object>{{"in_AmountNeto", in_AmountNeto}}, default, default, default, GetAssemblyName());
            return (string)result["out_AmountNetoText"];
        }

        /// <summary>
        /// Invokes the Modules/ConvertNumberToText.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string ConvertNumberToText(int in_AmountNeto, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Modules\ConvertNumberToText.xaml", new Dictionary<string, object>{{"in_AmountNeto", in_AmountNeto}}, default, isolated, default, GetAssemblyName());
            return (string)result["out_AmountNetoText"];
        }

        /// <summary>
        /// Invokes the Framework/TakeScreenshot.xaml
        /// </summary>
        public string TakeScreenshot(string in_Folder, string io_FilePath)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\TakeScreenshot.xaml", new Dictionary<string, object>{{"in_Folder", in_Folder}, {"io_FilePath", io_FilePath}}, default, default, default, GetAssemblyName());
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Framework/TakeScreenshot.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string TakeScreenshot(string in_Folder, string io_FilePath, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\TakeScreenshot.xaml", new Dictionary<string, object>{{"in_Folder", in_Folder}, {"io_FilePath", io_FilePath}}, default, isolated, default, GetAssemblyName());
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
        public System.Collections.Generic.Dictionary<string, object> InitAllSettings(string in_ConfigFile, string[] in_ConfigSheets)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_ConfigFile", in_ConfigFile}, {"in_ConfigSheets", in_ConfigSheets}}, default, default, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, object>)result["out_Config"];
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Collections.Generic.Dictionary<string, object> InitAllSettings(string in_ConfigFile, string[] in_ConfigSheets, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_ConfigFile", in_ConfigFile}, {"in_ConfigSheets", in_ConfigSheets}}, default, isolated, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, object>)result["out_Config"];
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
        public void CloseAllApplications()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CloseAllApplications(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/InitAllApplicationsTestCase.xaml
        /// </summary>
        public void InitAllApplicationsTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllApplicationsTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/InitAllApplicationsTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void InitAllApplicationsTestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllApplicationsTestCase.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/CXCProcess_TestCase.xaml
        /// </summary>
        public void CXCProcess_TestCase(System.Collections.Generic.IDictionary<string, object> cXC_DynamicData)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\CXCProcess_TestCase.xaml", new Dictionary<string, object>{{"cXC_DynamicData", cXC_DynamicData}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/CXCProcess_TestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CXCProcess_TestCase(System.Collections.Generic.IDictionary<string, object> cXC_DynamicData, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\CXCProcess_TestCase.xaml", new Dictionary<string, object>{{"cXC_DynamicData", cXC_DynamicData}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, string in_TransactionField1, string in_TransactionField2, string in_TransactionID, System.Exception in_SystemException, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_BusinessException", in_BusinessException}, {"in_TransactionField1", in_TransactionField1}, {"in_TransactionField2", in_TransactionField2}, {"in_TransactionID", in_TransactionID}, {"in_SystemException", in_SystemException}, {"in_Config", in_Config}, {"in_TransactionItem", in_TransactionItem}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}, {"io_ConsecutiveSystemExceptions", io_ConsecutiveSystemExceptions}}, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"], (int)result["io_ConsecutiveSystemExceptions"]);
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, string in_TransactionField1, string in_TransactionField2, string in_TransactionID, System.Exception in_SystemException, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_BusinessException", in_BusinessException}, {"in_TransactionField1", in_TransactionField1}, {"in_TransactionField2", in_TransactionField2}, {"in_TransactionID", in_TransactionID}, {"in_SystemException", in_SystemException}, {"in_Config", in_Config}, {"in_TransactionItem", in_TransactionItem}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}, {"io_ConsecutiveSystemExceptions", io_ConsecutiveSystemExceptions}}, default, isolated, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"], (int)result["io_ConsecutiveSystemExceptions"]);
        }

        /// <summary>
        /// Invokes the Framework/Process.xaml
        /// </summary>
        public void Process(UiPath.Core.QueueItem in_TransactionItem, System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Process.xaml", new Dictionary<string, object>{{"in_TransactionItem", in_TransactionItem}, {"in_Config", in_Config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/Process.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Process(UiPath.Core.QueueItem in_TransactionItem, System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Process.xaml", new Dictionary<string, object>{{"in_TransactionItem", in_TransactionItem}, {"in_Config", in_Config}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
        public void KillAllProcesses()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void KillAllProcesses(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
        public void InitAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void InitAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Modules/CodedWorkflows/CodedWorkflowTest.cs
        /// </summary>
        public void CodedWorkflowTest()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Modules\CodedWorkflows\CodedWorkflowTest.cs", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Modules/CodedWorkflows/CodedWorkflowTest.cs
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CodedWorkflowTest(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Modules\CodedWorkflows\CodedWorkflowTest.cs", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/GetTransactionDataTestCase.xaml
        /// </summary>
        public void GetTransactionDataTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\GetTransactionDataTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/GetTransactionDataTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void GetTransactionDataTestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\GetTransactionDataTestCase.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Collections.Generic.Dictionary<string, object> in_Config, System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Collections.Generic.Dictionary<string, object> in_Config, System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, isolated, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
        public (UiPath.Core.QueueItem out_TransactionItem, string out_TransactionField1, string out_TransactionField2, string out_TransactionID, System.Data.DataTable io_dt_TransactionData) GetTransactionData(int in_TransactionNumber, System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable io_dt_TransactionData)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_TransactionNumber", in_TransactionNumber}, {"in_Config", in_Config}, {"io_dt_TransactionData", io_dt_TransactionData}}, default, default, default, GetAssemblyName());
            return ((UiPath.Core.QueueItem)result["out_TransactionItem"], (string)result["out_TransactionField1"], (string)result["out_TransactionField2"], (string)result["out_TransactionID"], (System.Data.DataTable)result["io_dt_TransactionData"]);
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (UiPath.Core.QueueItem out_TransactionItem, string out_TransactionField1, string out_TransactionField2, string out_TransactionID, System.Data.DataTable io_dt_TransactionData) GetTransactionData(int in_TransactionNumber, System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable io_dt_TransactionData, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_TransactionNumber", in_TransactionNumber}, {"in_Config", in_Config}, {"io_dt_TransactionData", io_dt_TransactionData}}, default, isolated, default, GetAssemblyName());
            return ((UiPath.Core.QueueItem)result["out_TransactionItem"], (string)result["out_TransactionField1"], (string)result["out_TransactionField2"], (string)result["out_TransactionID"], (System.Data.DataTable)result["io_dt_TransactionData"]);
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}