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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Rekognition.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchUsers Request Marshaller
    /// </summary>       
    public class SearchUsersRequestMarshaller : IMarshaller<IRequest, SearchUsersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchUsersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SearchUsersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Rekognition");
            string target = "RekognitionService.SearchUsers";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-06-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCollectionId())
                {
                    context.Writer.WritePropertyName("CollectionId");
                    context.Writer.Write(publicRequest.CollectionId);
                }

                if(publicRequest.IsSetFaceId())
                {
                    context.Writer.WritePropertyName("FaceId");
                    context.Writer.Write(publicRequest.FaceId);
                }

                if(publicRequest.IsSetMaxUsers())
                {
                    context.Writer.WritePropertyName("MaxUsers");
                    context.Writer.Write(publicRequest.MaxUsers);
                }

                if(publicRequest.IsSetUserId())
                {
                    context.Writer.WritePropertyName("UserId");
                    context.Writer.Write(publicRequest.UserId);
                }

                if(publicRequest.IsSetUserMatchThreshold())
                {
                    context.Writer.WritePropertyName("UserMatchThreshold");
                    if(StringUtils.IsSpecialFloatValue(publicRequest.UserMatchThreshold))
                    {
                        context.Writer.Write(StringUtils.FromSpecialFloatValue(publicRequest.UserMatchThreshold));
                    }
                    else
                    {
                        context.Writer.Write(publicRequest.UserMatchThreshold);
                    }
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SearchUsersRequestMarshaller _instance = new SearchUsersRequestMarshaller();        

        internal static SearchUsersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchUsersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}