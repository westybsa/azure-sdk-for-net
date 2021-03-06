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
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Optional. Configures the Windows Remote Management service on the
    /// virtual machine, which enables remote Windows PowerShell.
    /// </summary>
    public partial class WindowsRemoteManagementSettings
    {
        private IList<WindowsRemoteManagementListener> _listeners;
        
        /// <summary>
        /// Required. Contains a collection of information for enabling remote
        /// Windows PowerShell.
        /// </summary>
        public IList<WindowsRemoteManagementListener> Listeners
        {
            get { return this._listeners; }
            set { this._listeners = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WindowsRemoteManagementSettings
        /// class.
        /// </summary>
        public WindowsRemoteManagementSettings()
        {
            this._listeners = new List<WindowsRemoteManagementListener>();
        }
    }
}
