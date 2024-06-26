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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EdgeModelStat Object
    /// </summary>  
    public class EdgeModelStatUnmarshaller : IUnmarshaller<EdgeModelStat, XmlUnmarshallerContext>, IUnmarshaller<EdgeModelStat, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EdgeModelStat IUnmarshaller<EdgeModelStat, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public EdgeModelStat Unmarshall(JsonUnmarshallerContext context)
        {
            EdgeModelStat unmarshalledObject = new EdgeModelStat();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ActiveDeviceCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ActiveDeviceCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConnectedDeviceCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ConnectedDeviceCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OfflineDeviceCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.OfflineDeviceCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SamplingDeviceCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.SamplingDeviceCount = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EdgeModelStatUnmarshaller _instance = new EdgeModelStatUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EdgeModelStatUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}