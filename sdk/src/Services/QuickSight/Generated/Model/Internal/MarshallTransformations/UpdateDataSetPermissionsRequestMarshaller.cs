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
    /// UpdateDataSetPermissions Request Marshaller
    /// </summary>       
    public class UpdateDataSetPermissionsRequestMarshaller : IMarshaller<IRequest, UpdateDataSetPermissionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDataSetPermissionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDataSetPermissionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAwsAccountId())
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));
            if (!publicRequest.IsSetDataSetId())
                throw new AmazonQuickSightException("Request object does not have required field DataSetId set");
            request.AddPathResource("{DataSetId}", StringUtils.FromString(publicRequest.DataSetId));
            request.ResourcePath = "/accounts/{AwsAccountId}/data-sets/{DataSetId}/permissions";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetGrantPermissions())
                {
                    context.Writer.WritePropertyName("GrantPermissions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestGrantPermissionsListValue in publicRequest.GrantPermissions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ResourcePermissionMarshaller.Instance;
                        marshaller.Marshall(publicRequestGrantPermissionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRevokePermissions())
                {
                    context.Writer.WritePropertyName("RevokePermissions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRevokePermissionsListValue in publicRequest.RevokePermissions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ResourcePermissionMarshaller.Instance;
                        marshaller.Marshall(publicRequestRevokePermissionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateDataSetPermissionsRequestMarshaller _instance = new UpdateDataSetPermissionsRequestMarshaller();        

        internal static UpdateDataSetPermissionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDataSetPermissionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}