/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ECS.Model
{
    /// <summary>
    /// This is the response object from the DescribeContainerInstances operation.
    /// </summary>
    public partial class DescribeContainerInstancesResponse : AmazonWebServiceResponse
    {
        private List<ContainerInstance> _containerInstances = AWSConfigs.InitializeCollections ? new List<ContainerInstance>() : null;
        private List<Failure> _failures = AWSConfigs.InitializeCollections ? new List<Failure>() : null;

        /// <summary>
        /// Gets and sets the property ContainerInstances. 
        /// <para>
        /// The list of container instances.
        /// </para>
        /// </summary>
        public List<ContainerInstance> ContainerInstances
        {
            get { return this._containerInstances; }
            set { this._containerInstances = value; }
        }

        // Check to see if ContainerInstances property is set
        internal bool IsSetContainerInstances()
        {
            return this._containerInstances != null && (this._containerInstances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Failures. 
        /// <para>
        /// Any failures associated with the call.
        /// </para>
        /// </summary>
        public List<Failure> Failures
        {
            get { return this._failures; }
            set { this._failures = value; }
        }

        // Check to see if Failures property is set
        internal bool IsSetFailures()
        {
            return this._failures != null && (this._failures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}