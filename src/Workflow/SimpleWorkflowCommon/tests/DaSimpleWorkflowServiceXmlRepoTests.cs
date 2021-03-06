﻿// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Ejyle.DevAccelerate.Workflow.SimpleWorkflow.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ejyle.DevAccelerate.Workflow.SimpleWorkflow.Common.Tests
{
    [TestClass]
    public class DaSimpleWorkflowServiceXmlRepoTests
    {
        [TestMethod]
        public void CallEchoApiWorkflowTest()
        {
            var service = new DaSimpleWorkflowService("C:\\data");

            var parameters = new Dictionary<string, object>();
            parameters.Add("message", "Hello, World!");
            parameters.Add("X-Auth-ID", "ABCD1234");
            var result = service.Execute("SignInWorkflow", parameters);

            Assert.IsNotNull(result, "The workflow's result is null.");
            Assert.IsTrue(result.IsSuccess, "The workflow's success returned false.");
        }
    }
}
