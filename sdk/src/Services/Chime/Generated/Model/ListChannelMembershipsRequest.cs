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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
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
namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the ListChannelMemberships operation.
    /// Lists all channel memberships in a channel.
    /// 
    ///  <note> 
    /// <para>
    /// The <c>x-amz-chime-bearer</c> request header is mandatory. Use the <c>AppInstanceUserArn</c>
    /// of the user that makes the API call as the value in the header.
    /// </para>
    ///  </note> <important> 
    /// <para>
    ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
    /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_ListChannelMemberships.html">ListChannelMemberships</a>,
    /// in the Amazon Chime SDK.
    /// </para>
    ///  
    /// <para>
    /// Using the latest version requires migrating to a dedicated namespace. For more information,
    /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
    /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ListChannelMembershipsRequest : AmazonChimeRequest
    {
        private string _channelArn;
        private string _chimeBearer;
        private int? _maxResults;
        private string _nextToken;
        private ChannelMembershipType _type;

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The maximum number of channel memberships that you want returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string ChannelArn
        {
            get { return this._channelArn; }
            set { this._channelArn = value; }
        }

        // Check to see if ChannelArn property is set
        internal bool IsSetChannelArn()
        {
            return this._channelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ChimeBearer. 
        /// <para>
        /// The <c>AppInstanceUserArn</c> of the user that makes the API call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1600)]
        public string ChimeBearer
        {
            get { return this._chimeBearer; }
            set { this._chimeBearer = value; }
        }

        // Check to see if ChimeBearer property is set
        internal bool IsSetChimeBearer()
        {
            return !string.IsNullOrEmpty(this._chimeBearer);
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of channel memberships that you want returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token passed by previous API calls until all requested channel memberships are
        /// returned.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The membership type of a user, <c>DEFAULT</c> or <c>HIDDEN</c>. Default members are
        /// always returned as part of <c>ListChannelMemberships</c>. Hidden members are only
        /// returned if the type filter in <c>ListChannelMemberships</c> equals <c>HIDDEN</c>.
        /// Otherwise hidden members are not returned.
        /// </para>
        /// </summary>
        public ChannelMembershipType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}