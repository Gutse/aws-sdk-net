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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type containing the response information for the new health check.
    /// </summary>
    public partial class CreateHealthCheckResponse : AmazonWebServiceResponse
    {
        private HealthCheck _healthCheck;
        private string _location;

        /// <summary>
        /// Gets and sets the property HealthCheck. 
        /// <para>
        /// A complex type that contains identifying information about the health check.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HealthCheck HealthCheck
        {
            get { return this._healthCheck; }
            set { this._healthCheck = value; }
        }

        // Check to see if HealthCheck property is set
        internal bool IsSetHealthCheck()
        {
            return this._healthCheck != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The unique URL representing the new health check.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return !string.IsNullOrEmpty(this._location);
        }

    }
}