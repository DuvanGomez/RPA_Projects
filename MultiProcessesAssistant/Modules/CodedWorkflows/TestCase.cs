using MultiprocessesAssistant.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.Api.Models;
using UiPath.Testing.Activities.Models;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using UiPath.Word;
using UiPath.Word.Activities;
using UiPath.Word.Activities.API;
using UiPath.Word.Activities.API.Models;

namespace MultiprocessesAssistant.Modules.CodedWorkflows
{
    public class TestCase : CodedWorkflow
    {
        LoanApplication newLoan = new LoanApplication();
        
        [TestCase]
        public void Execute()
        {
            
            // Arrange
            Log("Test run started for TestCase example.");
            //Initializeloan application variables
            initializeLoanClass();
            //Navigate to loan Application Screen
            NavigateToLoanApplicationScreen();
            //Applying the loan and getting the loan rate
            string loanRate = ApplyForLoan();
            Console.WriteLine("Loan Rate: " + loanRate);
            //Verifying whether the loan rate is 8%.
            testing.VerifyExpression(loanRate.Contains("8"));

            // Act
            RunWorkflow(@"Modules\CodedWorkflows\CodedWorkflowTest.cs" );

            // Assert
            // To start using activities, use IntelliSense (CTRL + Space) to discover the available services, e.g. testing.VerifyExpression(...).
        }
        
        public void initializeLoanClass()
        {
            newLoan.age = "34";
            newLoan.emailAddress = "test.email@gmail.com";
            newLoan.loanAmount = "80000";
            newLoan.loanTerm = "5";
            newLoan.yearlyIncome = "10000";
        }
        
        public void NavigateToLoanApplicationScreen()
        { 
            var homeScreen = uiAutomation.Open(ObjectRepository.Descriptors.Chrome__UiBank_app.Chrome__UiBank);
            homeScreen.Click(ObjectRepository.Descriptors.Chrome__UiBank_app.Chrome__UiBank.Products);
            homeScreen.Click(ObjectRepository.Descriptors.Chrome__UiBank_app.Chrome__UiBank.Loans);
            
            var app = uiAutomation.Open(ObjectRepository.Descriptors.Chrome__UiBank_app.Chrome__UiBank_Loan_Screen);
            app.Click("Apply For A Loan");
         }
                
        public string ApplyForLoan()
        {
            string loanRate = null;
            var loanScreen = uiAutomation.Open("Chrome: UiBank New Loan");
            loanScreen.TypeInto("Age",newLoan.age);
            loanScreen.TypeInto("Email Address", newLoan.emailAddress);
            loanScreen.TypeInto("Current Yearly", newLoan.yearlyIncome);
            loanScreen.TypeInto("Loan Amount Requested", newLoan.loanAmount);
            loanScreen.TypeInto("Loan Term", newLoan.loanTerm);
            
            var loanRequestScreen = uiAutomation.Open("Chrome: UiBank - Loan Pass Fail");
            var successMsg = loanRequestScreen.GetText("Success Message");
            
            Console.WriteLine(successMsg);
            if(successMsg.Contains("approved"))
            {
                loanRate = loanRequestScreen.GetText("Loan Rate");
            }
            else
                loanRate = "0";
            return loanRate;
        }
    }
}