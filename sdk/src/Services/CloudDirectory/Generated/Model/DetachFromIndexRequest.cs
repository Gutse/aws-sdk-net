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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
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
namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Container for the parameters to the DetachFromIndex operation.
    /// Detaches the specified object from the specified index.
    /// </summary>
    public partial class DetachFromIndexRequest : AmazonCloudDirectoryRequest
    {
        private string _directoryArn;
        private ObjectReference _indexReference;
        private ObjectReference _targetReference;

        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the directory the index and object exist in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryArn
        {
            get { return this._directoryArn; }
            set { this._directoryArn = value; }
        }

        // Check to see if DirectoryArn property is set
        internal bool IsSetDirectoryArn()
        {
            return !string.IsNullOrEmpty(this._directoryArn);
        }

        /// <summary>
        /// Gets and sets the property IndexReference. 
        /// <para>
        /// A reference to the index object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ObjectReference IndexReference
        {
            get { return this._indexReference; }
            set { this._indexReference = value; }
        }

        // Check to see if IndexReference property is set
        internal bool IsSetIndexReference()
        {
            return this._indexReference != null;
        }

        /// <summary>
        /// Gets and sets the property TargetReference. 
        /// <para>
        /// A reference to the object being detached from the index.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ObjectReference TargetReference
        {
            get { return this._targetReference; }
            set { this._targetReference = value; }
        }

        // Check to see if TargetReference property is set
        internal bool IsSetTargetReference()
        {
            return this._targetReference != null;
        }

    }
}