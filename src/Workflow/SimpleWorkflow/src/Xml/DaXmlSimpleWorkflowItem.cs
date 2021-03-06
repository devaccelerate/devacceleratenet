﻿// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ejyle.DevAccelerate.Workflow.SimpleWorkflow.Xml
{
    [SerializableAttribute()]
    [XmlType(AnonymousType =true, Namespace = "https://devaccelerate.github.io/schema/simple-workflow-v10.html")]
    public class DaXmlSimpleWorkflowItem : DaXmlSimpleWorkflowItem<DaXmlSimpleWorkflowItemSetting, DaXmlSimpleWorkflowItemParameterDefinition>
    {
    }

    [SerializableAttribute()]
    [XmlType(AnonymousType =true, Namespace = "https://devaccelerate.github.io/schema/simple-workflow-v10.html")]
    public class DaXmlSimpleWorkflowItem<TSimpleWorkflowItemSetting, TSimpleWorkflowItemParameterDefinition> : IDaSimpleWorkflowItem<TSimpleWorkflowItemSetting, TSimpleWorkflowItemParameterDefinition>
        where TSimpleWorkflowItemSetting : IDaSimpleWorkflowItemSetting
        where TSimpleWorkflowItemParameterDefinition : IDaSimpleWorkflowParameterDefinition
    {
        private DaSimpleWorkflowItemType _workflowItemType;
        private string _name;
        private string _type;
        private TSimpleWorkflowItemSetting[] _settings;
        private TSimpleWorkflowItemParameterDefinition[] _expectedParameters;

        [XmlArray(ElementName = "settings")]
        [XmlArrayItem(ElementName = "setting")]
        public TSimpleWorkflowItemSetting[] Settings
        {
            get
            {
                return this._settings;
            }
            set
            {
                this._settings = value;
            }
        }

        [XmlArray(ElementName = "expectedParameters")]
        [XmlArrayItem(ElementName = "expectedParameter")]
        public TSimpleWorkflowItemParameterDefinition[] ExpectedParameters
        {
            get
            {
                return this._expectedParameters;
            }
            set
            {
                this._expectedParameters = value;
            }
        }

        [XmlAttributeAttribute(AttributeName= "workflowItemType")]
        public DaSimpleWorkflowItemType WorkflowItemType
        {
            get
            {
                return this._workflowItemType;
            }
            set
            {
                this._workflowItemType = value;
            }
        }

        [XmlAttributeAttribute(AttributeName = "name")]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        [XmlAttributeAttribute(AttributeName = "type")]
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
    }
}
