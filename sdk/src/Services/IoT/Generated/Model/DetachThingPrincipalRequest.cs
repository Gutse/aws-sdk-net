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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the DetachThingPrincipal operation.
    /// Detaches the specified principal from the specified thing. A principal can be X.509
    /// certificates, IAM users, groups, and roles, Amazon Cognito identities or federated
    /// identities.
    /// 
    ///  <note> 
    /// <para>
    /// This call is asynchronous. It might take several seconds for the detachment to propagate.
    /// </para>
    ///  </note> 
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DetachThingPrincipal</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class DetachThingPrincipalRequest : AmazonIoTRequest
    {
        private string _principal;
        private string _thingName;

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// If the principal is a certificate, this value must be ARN of the certificate. If the
        /// principal is an Amazon Cognito identity, this value must be the ID of the Amazon Cognito
        /// identity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return !string.IsNullOrEmpty(this._principal);
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

    }
}