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
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for JobProcessDetails Object
    /// </summary>  
    public class JobProcessDetailsUnmarshaller : IUnmarshaller<JobProcessDetails, XmlUnmarshallerContext>, IUnmarshaller<JobProcessDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        JobProcessDetails IUnmarshaller<JobProcessDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public JobProcessDetails Unmarshall(JsonUnmarshallerContext context)
        {
            JobProcessDetails unmarshalledObject = new JobProcessDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("numberOfCanceledThings", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfCanceledThings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numberOfFailedThings", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfFailedThings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numberOfInProgressThings", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfInProgressThings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numberOfQueuedThings", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfQueuedThings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numberOfRejectedThings", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfRejectedThings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numberOfRemovedThings", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfRemovedThings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numberOfSucceededThings", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfSucceededThings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numberOfTimedOutThings", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfTimedOutThings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("processingTargets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ProcessingTargets = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static JobProcessDetailsUnmarshaller _instance = new JobProcessDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JobProcessDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}