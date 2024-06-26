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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoIdentity.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateIdentityPool Request Marshaller
    /// </summary>       
    public class CreateIdentityPoolRequestMarshaller : IMarshaller<IRequest, CreateIdentityPoolRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateIdentityPoolRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateIdentityPoolRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentity");
            string target = "AWSCognitoIdentityService.CreateIdentityPool";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-06-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAllowClassicFlow())
                {
                    context.Writer.WritePropertyName("AllowClassicFlow");
                    context.Writer.Write(publicRequest.AllowClassicFlow);
                }

                if(publicRequest.IsSetAllowUnauthenticatedIdentities())
                {
                    context.Writer.WritePropertyName("AllowUnauthenticatedIdentities");
                    context.Writer.Write(publicRequest.AllowUnauthenticatedIdentities);
                }

                if(publicRequest.IsSetCognitoIdentityProviders())
                {
                    context.Writer.WritePropertyName("CognitoIdentityProviders");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCognitoIdentityProvidersListValue in publicRequest.CognitoIdentityProviders)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CognitoIdentityProviderInfoMarshaller.Instance;
                        marshaller.Marshall(publicRequestCognitoIdentityProvidersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDeveloperProviderName())
                {
                    context.Writer.WritePropertyName("DeveloperProviderName");
                    context.Writer.Write(publicRequest.DeveloperProviderName);
                }

                if(publicRequest.IsSetIdentityPoolName())
                {
                    context.Writer.WritePropertyName("IdentityPoolName");
                    context.Writer.Write(publicRequest.IdentityPoolName);
                }

                if(publicRequest.IsSetIdentityPoolTags())
                {
                    context.Writer.WritePropertyName("IdentityPoolTags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestIdentityPoolTagsKvp in publicRequest.IdentityPoolTags)
                    {
                        context.Writer.WritePropertyName(publicRequestIdentityPoolTagsKvp.Key);
                        var publicRequestIdentityPoolTagsValue = publicRequestIdentityPoolTagsKvp.Value;

                            context.Writer.Write(publicRequestIdentityPoolTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOpenIdConnectProviderARNs())
                {
                    context.Writer.WritePropertyName("OpenIdConnectProviderARNs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOpenIdConnectProviderARNsListValue in publicRequest.OpenIdConnectProviderARNs)
                    {
                            context.Writer.Write(publicRequestOpenIdConnectProviderARNsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSamlProviderARNs())
                {
                    context.Writer.WritePropertyName("SamlProviderARNs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSamlProviderARNsListValue in publicRequest.SamlProviderARNs)
                    {
                            context.Writer.Write(publicRequestSamlProviderARNsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSupportedLoginProviders())
                {
                    context.Writer.WritePropertyName("SupportedLoginProviders");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestSupportedLoginProvidersKvp in publicRequest.SupportedLoginProviders)
                    {
                        context.Writer.WritePropertyName(publicRequestSupportedLoginProvidersKvp.Key);
                        var publicRequestSupportedLoginProvidersValue = publicRequestSupportedLoginProvidersKvp.Value;

                            context.Writer.Write(publicRequestSupportedLoginProvidersValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateIdentityPoolRequestMarshaller _instance = new CreateIdentityPoolRequestMarshaller();        

        internal static CreateIdentityPoolRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateIdentityPoolRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}