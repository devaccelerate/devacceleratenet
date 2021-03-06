﻿// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Workflow.SimpleWorkflow
{
    public interface IDaSimpleWorkflow<TSimpleWorkflowItem, TSimpleWorkflowSetting, TSimpleWorkflowItemParameterDefinition>
        where TSimpleWorkflowItem : IDaSimpleWorkflowItem<TSimpleWorkflowSetting, TSimpleWorkflowItemParameterDefinition>
        where TSimpleWorkflowSetting : IDaSimpleWorkflowItemSetting
        where TSimpleWorkflowItemParameterDefinition : IDaSimpleWorkflowParameterDefinition
    {
        TSimpleWorkflowItem[] WorkflowItems
        {
            get;
            set;
        }

        string Name
        {
            get;
            set;
        }

        bool AbortOnError
        {
            get;
            set;
        }
    }
}
