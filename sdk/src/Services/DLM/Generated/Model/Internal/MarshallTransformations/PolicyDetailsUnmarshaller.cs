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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DLM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DLM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PolicyDetails Object
    /// </summary>  
    public class PolicyDetailsUnmarshaller : IUnmarshaller<PolicyDetails, XmlUnmarshallerContext>, IUnmarshaller<PolicyDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PolicyDetails IUnmarshaller<PolicyDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PolicyDetails Unmarshall(JsonUnmarshallerContext context)
        {
            PolicyDetails unmarshalledObject = new PolicyDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Actions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Action, ActionUnmarshaller>(ActionUnmarshaller.Instance);
                    unmarshalledObject.Actions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CopyTags", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CopyTags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateInterval", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.CreateInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CrossRegionCopyTargets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CrossRegionCopyTarget, CrossRegionCopyTargetUnmarshaller>(CrossRegionCopyTargetUnmarshaller.Instance);
                    unmarshalledObject.CrossRegionCopyTargets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventSource", targetDepth))
                {
                    var unmarshaller = EventSourceUnmarshaller.Instance;
                    unmarshalledObject.EventSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Exclusions", targetDepth))
                {
                    var unmarshaller = ExclusionsUnmarshaller.Instance;
                    unmarshalledObject.Exclusions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExtendDeletion", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ExtendDeletion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Parameters", targetDepth))
                {
                    var unmarshaller = ParametersUnmarshaller.Instance;
                    unmarshalledObject.Parameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PolicyLanguage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyLanguage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PolicyType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceLocations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ResourceLocations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ResourceTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RetainInterval", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RetainInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Schedules", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Schedule, ScheduleUnmarshaller>(ScheduleUnmarshaller.Instance);
                    unmarshalledObject.Schedules = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetTags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.TargetTags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PolicyDetailsUnmarshaller _instance = new PolicyDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PolicyDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}