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
using System.Linq;

namespace Microsoft.Azure.Management.DataFactories.Common.Models
{
    /// <summary>
    /// Pipeline runtime information.
    /// </summary>
    public partial class PipelineRuntimeInfo
    {
        private DateTime _deploymentTime;
        
        /// <summary>
        /// Required. The deployment time of the pipeline.
        /// </summary>
        public DateTime DeploymentTime
        {
            get { return this._deploymentTime; }
            set { this._deploymentTime = value; }
        }
        
        private string _pipelineState;
        
        /// <summary>
        /// Optional. Indicates the current state of the pipeline. . Must be
        /// one of <see cref="PipelineState"/>.
        /// </summary>
        public string PipelineState
        {
            get { return this._pipelineState; }
            set { this._pipelineState = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the PipelineRuntimeInfo class.
        /// </summary>
        public PipelineRuntimeInfo()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the PipelineRuntimeInfo class with
        /// required arguments.
        /// </summary>
        public PipelineRuntimeInfo(DateTime deploymentTime)
            : this()
        {
            this.DeploymentTime = deploymentTime;
        }
    }
}
