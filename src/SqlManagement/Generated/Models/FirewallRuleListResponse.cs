// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.WindowsAzure.Management.Sql;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql.Models
{
    /// <summary>
    /// A standard service response including an HTTP status code and request
    /// ID.
    /// </summary>
    public partial class FirewallRuleListResponse : OperationResponse, IEnumerable<FirewallRuleListResponse.FirewallRule>
    {
        private IList<FirewallRuleListResponse.FirewallRule> _firewallRules;
        
        /// <summary>
        /// Gets or sets the firewall rules for this SQL Database Server.
        /// </summary>
        public IList<FirewallRuleListResponse.FirewallRule> FirewallRules
        {
            get { return this._firewallRules; }
            set { this._firewallRules = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the FirewallRuleListResponse class.
        /// </summary>
        public FirewallRuleListResponse()
        {
            this._firewallRules = new List<FirewallRuleListResponse.FirewallRule>();
        }
        
        /// <summary>
        /// Gets the sequence of FirewallRules.
        /// </summary>
        public IEnumerator<FirewallRuleListResponse.FirewallRule> GetEnumerator()
        {
            return this.FirewallRules.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of FirewallRules.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// Firewall rule.
        /// </summary>
        public partial class FirewallRule
        {
            private string _endIPAddress;
            
            /// <summary>
            /// Gets or sets the ending IP address applied to this rule.
            /// </summary>
            public string EndIPAddress
            {
                get { return this._endIPAddress; }
                set { this._endIPAddress = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Gets or sets the name of the Firewall Rule.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private string _startIPAddress;
            
            /// <summary>
            /// Gets or sets the beginning IP address applied to this rule.
            /// </summary>
            public string StartIPAddress
            {
                get { return this._startIPAddress; }
                set { this._startIPAddress = value; }
            }
            
            private string _type;
            
            /// <summary>
            /// Gets or sets the type of resource.
            /// </summary>
            public string Type
            {
                get { return this._type; }
                set { this._type = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the FirewallRule class.
            /// </summary>
            public FirewallRule()
            {
            }
        }
    }
}
