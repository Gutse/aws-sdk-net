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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeCommit.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeCommit.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PullRequestEvent Object
    /// </summary>  
    public class PullRequestEventUnmarshaller : IUnmarshaller<PullRequestEvent, XmlUnmarshallerContext>, IUnmarshaller<PullRequestEvent, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PullRequestEvent IUnmarshaller<PullRequestEvent, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PullRequestEvent Unmarshall(JsonUnmarshallerContext context)
        {
            PullRequestEvent unmarshalledObject = new PullRequestEvent();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("actorArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActorArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("approvalRuleEventMetadata", targetDepth))
                {
                    var unmarshaller = ApprovalRuleEventMetadataUnmarshaller.Instance;
                    unmarshalledObject.ApprovalRuleEventMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("approvalRuleOverriddenEventMetadata", targetDepth))
                {
                    var unmarshaller = ApprovalRuleOverriddenEventMetadataUnmarshaller.Instance;
                    unmarshalledObject.ApprovalRuleOverriddenEventMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("approvalStateChangedEventMetadata", targetDepth))
                {
                    var unmarshaller = ApprovalStateChangedEventMetadataUnmarshaller.Instance;
                    unmarshalledObject.ApprovalStateChangedEventMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EventDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pullRequestCreatedEventMetadata", targetDepth))
                {
                    var unmarshaller = PullRequestCreatedEventMetadataUnmarshaller.Instance;
                    unmarshalledObject.PullRequestCreatedEventMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pullRequestEventType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PullRequestEventType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pullRequestId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PullRequestId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pullRequestMergedStateChangedEventMetadata", targetDepth))
                {
                    var unmarshaller = PullRequestMergedStateChangedEventMetadataUnmarshaller.Instance;
                    unmarshalledObject.PullRequestMergedStateChangedEventMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pullRequestSourceReferenceUpdatedEventMetadata", targetDepth))
                {
                    var unmarshaller = PullRequestSourceReferenceUpdatedEventMetadataUnmarshaller.Instance;
                    unmarshalledObject.PullRequestSourceReferenceUpdatedEventMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pullRequestStatusChangedEventMetadata", targetDepth))
                {
                    var unmarshaller = PullRequestStatusChangedEventMetadataUnmarshaller.Instance;
                    unmarshalledObject.PullRequestStatusChangedEventMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PullRequestEventUnmarshaller _instance = new PullRequestEventUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PullRequestEventUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}