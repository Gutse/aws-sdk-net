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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SnapshotJobS3Result Object
    /// </summary>  
    public class SnapshotJobS3ResultUnmarshaller : IUnmarshaller<SnapshotJobS3Result, XmlUnmarshallerContext>, IUnmarshaller<SnapshotJobS3Result, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SnapshotJobS3Result IUnmarshaller<SnapshotJobS3Result, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SnapshotJobS3Result Unmarshall(JsonUnmarshallerContext context)
        {
            SnapshotJobS3Result unmarshalledObject = new SnapshotJobS3Result();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ErrorInfo", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SnapshotJobResultErrorInfo, SnapshotJobResultErrorInfoUnmarshaller>(SnapshotJobResultErrorInfoUnmarshaller.Instance);
                    unmarshalledObject.ErrorInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3DestinationConfiguration", targetDepth))
                {
                    var unmarshaller = SnapshotS3DestinationConfigurationUnmarshaller.Instance;
                    unmarshalledObject.S3DestinationConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3Uri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.S3Uri = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SnapshotJobS3ResultUnmarshaller _instance = new SnapshotJobS3ResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SnapshotJobS3ResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}