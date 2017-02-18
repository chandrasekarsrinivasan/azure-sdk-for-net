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
using Hyak.Common;
using Microsoft.Azure.Management.ApiManagement.Models;

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    /// <summary>
    /// Parameters supplied to the UpdateHostanme operation.
    /// </summary>
    public partial class ApiServiceUpdateHostnameParameters
    {
        private IList<HostnameConfiguration> _hostnamesToCreateOrUpdate;
        
        /// <summary>
        /// Optional. Gets or sets hostnames to create of update.
        /// </summary>
        public IList<HostnameConfiguration> HostnamesToCreateOrUpdate
        {
            get { return this._hostnamesToCreateOrUpdate; }
            set { this._hostnamesToCreateOrUpdate = value; }
        }
        
        private IList<HostnameType> _hostnamesToDelete;
        
        /// <summary>
        /// Optional. Gets or sets hostnames to delete.
        /// </summary>
        public IList<HostnameType> HostnamesToDelete
        {
            get { return this._hostnamesToDelete; }
            set { this._hostnamesToDelete = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ApiServiceUpdateHostnameParameters class.
        /// </summary>
        public ApiServiceUpdateHostnameParameters()
        {
            this.HostnamesToCreateOrUpdate = new LazyList<HostnameConfiguration>();
            this.HostnamesToDelete = new LazyList<HostnameType>();
        }
    }
}