using MultiprocessesAssistant.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
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
    public class LoanApplication
    {
        public string age { get; set;}
        public string yearlyIncome { get; set;}
        public string emailAddress { get; set;}
        public string loanAmount { get; set;}
        public string loanTerm { get; set;}
        public string loanRate { get; set;}
        public string loanID { get; set;}
        
    }
}