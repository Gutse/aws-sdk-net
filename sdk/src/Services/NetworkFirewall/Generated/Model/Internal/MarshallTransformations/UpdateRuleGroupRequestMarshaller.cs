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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateRuleGroup Request Marshaller
    /// </summary>       
    public class UpdateRuleGroupRequestMarshaller : IMarshaller<IRequest, UpdateRuleGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateRuleGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateRuleGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFirewall");
            string target = "NetworkFirewall_20201112.UpdateRuleGroup";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-12";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDryRun())
                {
                    context.Writer.WritePropertyName("DryRun");
                    context.Writer.Write(publicRequest.DryRun);
                }

                if(publicRequest.IsSetEncryptionConfiguration())
                {
                    context.Writer.WritePropertyName("EncryptionConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = EncryptionConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRuleGroup())
                {
                    context.Writer.WritePropertyName("RuleGroup");
                    context.Writer.WriteObjectStart();

                    var marshaller = RuleGroupMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RuleGroup, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRuleGroupArn())
                {
                    context.Writer.WritePropertyName("RuleGroupArn");
                    context.Writer.Write(publicRequest.RuleGroupArn);
                }

                if(publicRequest.IsSetRuleGroupName())
                {
                    context.Writer.WritePropertyName("RuleGroupName");
                    context.Writer.Write(publicRequest.RuleGroupName);
                }

                if(publicRequest.IsSetRules())
                {
                    context.Writer.WritePropertyName("Rules");
                    context.Writer.Write(publicRequest.Rules);
                }

                if(publicRequest.IsSetSourceMetadata())
                {
                    context.Writer.WritePropertyName("SourceMetadata");
                    context.Writer.WriteObjectStart();

                    var marshaller = SourceMetadataMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SourceMetadata, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetType())
                {
                    context.Writer.WritePropertyName("Type");
                    context.Writer.Write(publicRequest.Type);
                }

                if(publicRequest.IsSetUpdateToken())
                {
                    context.Writer.WritePropertyName("UpdateToken");
                    context.Writer.Write(publicRequest.UpdateToken);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateRuleGroupRequestMarshaller _instance = new UpdateRuleGroupRequestMarshaller();        

        internal static UpdateRuleGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateRuleGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}