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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// High-level information about the managed rule group that your own rule group is copied
    /// from. You can use the the metadata to track version updates made to the originating
    /// rule group. You can retrieve all objects for a rule group by calling <a href="https://docs.aws.amazon.com/network-firewall/latest/APIReference/API_DescribeRuleGroup.html">DescribeRuleGroup</a>.
    /// </summary>
    public partial class SourceMetadata
    {
        private string _sourceArn;
        private string _sourceUpdateToken;

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the rule group that your own rule group is copied
        /// from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceUpdateToken. 
        /// <para>
        /// The update token of the Amazon Web Services managed rule group that your own rule
        /// group is copied from. To determine the update token for the managed rule group, call
        /// <a href="https://docs.aws.amazon.com/network-firewall/latest/APIReference/API_DescribeRuleGroup.html#networkfirewall-DescribeRuleGroup-response-UpdateToken">DescribeRuleGroup</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string SourceUpdateToken
        {
            get { return this._sourceUpdateToken; }
            set { this._sourceUpdateToken = value; }
        }

        // Check to see if SourceUpdateToken property is set
        internal bool IsSetSourceUpdateToken()
        {
            return this._sourceUpdateToken != null;
        }

    }
}