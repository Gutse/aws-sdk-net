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
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsOpenSearchServiceDomainClusterConfigDetails Object
    /// </summary>  
    public class AwsOpenSearchServiceDomainClusterConfigDetailsUnmarshaller : IUnmarshaller<AwsOpenSearchServiceDomainClusterConfigDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsOpenSearchServiceDomainClusterConfigDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsOpenSearchServiceDomainClusterConfigDetails IUnmarshaller<AwsOpenSearchServiceDomainClusterConfigDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsOpenSearchServiceDomainClusterConfigDetails Unmarshall(JsonUnmarshallerContext context)
        {
            AwsOpenSearchServiceDomainClusterConfigDetails unmarshalledObject = new AwsOpenSearchServiceDomainClusterConfigDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DedicatedMasterCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DedicatedMasterCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DedicatedMasterEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DedicatedMasterEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DedicatedMasterType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DedicatedMasterType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.InstanceCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WarmCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.WarmCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WarmEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.WarmEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WarmType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WarmType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ZoneAwarenessConfig", targetDepth))
                {
                    var unmarshaller = AwsOpenSearchServiceDomainClusterConfigZoneAwarenessConfigDetailsUnmarshaller.Instance;
                    unmarshalledObject.ZoneAwarenessConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ZoneAwarenessEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ZoneAwarenessEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsOpenSearchServiceDomainClusterConfigDetailsUnmarshaller _instance = new AwsOpenSearchServiceDomainClusterConfigDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsOpenSearchServiceDomainClusterConfigDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}