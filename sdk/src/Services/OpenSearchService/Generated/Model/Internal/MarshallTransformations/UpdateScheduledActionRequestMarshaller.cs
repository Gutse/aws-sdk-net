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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpenSearchService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.OpenSearchService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateScheduledAction Request Marshaller
    /// </summary>       
    public class UpdateScheduledActionRequestMarshaller : IMarshaller<IRequest, UpdateScheduledActionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateScheduledActionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateScheduledActionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpenSearchService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-01-01";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetDomainName())
                throw new AmazonOpenSearchServiceException("Request object does not have required field DomainName set");
            request.AddPathResource("{DomainName}", StringUtils.FromString(publicRequest.DomainName));
            request.ResourcePath = "/2021-01-01/opensearch/domain/{DomainName}/scheduledAction/update";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActionID())
                {
                    context.Writer.WritePropertyName("ActionID");
                    context.Writer.Write(publicRequest.ActionID);
                }

                if(publicRequest.IsSetActionType())
                {
                    context.Writer.WritePropertyName("ActionType");
                    context.Writer.Write(publicRequest.ActionType);
                }

                if(publicRequest.IsSetDesiredStartTime())
                {
                    context.Writer.WritePropertyName("DesiredStartTime");
                    context.Writer.Write(publicRequest.DesiredStartTime);
                }

                if(publicRequest.IsSetScheduleAt())
                {
                    context.Writer.WritePropertyName("ScheduleAt");
                    context.Writer.Write(publicRequest.ScheduleAt);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateScheduledActionRequestMarshaller _instance = new UpdateScheduledActionRequestMarshaller();        

        internal static UpdateScheduledActionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateScheduledActionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}