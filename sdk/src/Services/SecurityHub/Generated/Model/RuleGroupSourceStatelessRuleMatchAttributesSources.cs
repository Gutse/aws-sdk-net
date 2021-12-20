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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A source IP addresses and address range to inspect for.
    /// </summary>
    public partial class RuleGroupSourceStatelessRuleMatchAttributesSources
    {
        private string _addressDefinition;

        /// <summary>
        /// Gets and sets the property AddressDefinition. 
        /// <para>
        /// An IP address or a block of IP addresses.
        /// </para>
        /// </summary>
        public string AddressDefinition
        {
            get { return this._addressDefinition; }
            set { this._addressDefinition = value; }
        }

        // Check to see if AddressDefinition property is set
        internal bool IsSetAddressDefinition()
        {
            return this._addressDefinition != null;
        }

    }
}