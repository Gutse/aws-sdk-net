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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the GetBucketReplication operation.
    /// <note> 
    /// <para>
    /// This operation gets an Amazon S3 on Outposts bucket's replication configuration. To
    /// get an S3 bucket's replication configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketReplication.html">GetBucketReplication</a>
    /// in the <i>Amazon S3 API Reference</i>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Returns the replication configuration of an S3 on Outposts bucket. For more information
    /// about S3 on Outposts, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
    /// Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>. For information about
    /// S3 replication on Outposts configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsReplication.html">Replicating
    /// objects for S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// It can take a while to propagate <c>PUT</c> or <c>DELETE</c> requests for a replication
    /// configuration to all S3 on Outposts systems. Therefore, the replication configuration
    /// that's returned by a <c>GET</c> request soon after a <c>PUT</c> or <c>DELETE</c> request
    /// might return a more recent result than what's on the Outpost. If an Outpost is offline,
    /// the delay in updating the replication configuration on that Outpost can be significant.
    /// </para>
    ///  </note> 
    /// <para>
    /// This action requires permissions for the <c>s3-outposts:GetReplicationConfiguration</c>
    /// action. The Outposts bucket owner has this permission by default and can grant it
    /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsIAM.html">Setting
    /// up IAM with S3 on Outposts</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsBucketPolicy.html">Managing
    /// access to S3 on Outposts bucket</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// All Amazon S3 on Outposts REST API requests for this action require an additional
    /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
    /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
    /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
    /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
    /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketReplication.html#API_control_GetBucketReplication_Examples">Examples</a>
    /// section.
    /// </para>
    ///  
    /// <para>
    /// If you include the <c>Filter</c> element in a replication configuration, you must
    /// also include the <c>DeleteMarkerReplication</c>, <c>Status</c>, and <c>Priority</c>
    /// elements. The response also returns those elements.
    /// </para>
    ///  
    /// <para>
    /// For information about S3 on Outposts replication failure reasons, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/outposts-replication-eventbridge.html#outposts-replication-failure-codes">Replication
    /// failure reasons</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <c>GetBucketReplication</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketReplication.html">PutBucketReplication</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketReplication.html">DeleteBucketReplication</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetBucketReplicationRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _bucket;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the Outposts bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return !string.IsNullOrEmpty(this._accountId);
        }

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// Specifies the bucket to get the replication information for.
        /// </para>
        ///  
        /// <para>
        /// For using this parameter with Amazon S3 on Outposts with the REST API, you must specify
        /// the name and the x-amz-outpost-id as well.
        /// </para>
        ///  
        /// <para>
        /// For using this parameter with S3 on Outposts with the Amazon Web Services SDK and
        /// CLI, you must specify the ARN of the bucket accessed in the format <c>arn:aws:s3-outposts:&lt;Region&gt;:&lt;account-id&gt;:outpost/&lt;outpost-id&gt;/bucket/&lt;my-bucket-name&gt;</c>.
        /// For example, to access the bucket <c>reports</c> through Outpost <c>my-outpost</c>
        /// owned by account <c>123456789012</c> in Region <c>us-west-2</c>, use the URL encoding
        /// of <c>arn:aws:s3-outposts:us-west-2:123456789012:outpost/my-outpost/bucket/reports</c>.
        /// The value must be URL encoded. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

    }
}