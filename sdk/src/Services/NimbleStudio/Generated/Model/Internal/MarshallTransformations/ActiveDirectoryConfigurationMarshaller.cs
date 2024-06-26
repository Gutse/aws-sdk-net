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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NimbleStudio.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.NimbleStudio.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ActiveDirectoryConfiguration Marshaller
    /// </summary>
    public class ActiveDirectoryConfigurationMarshaller : IRequestMarshaller<ActiveDirectoryConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ActiveDirectoryConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComputerAttributes())
            {
                context.Writer.WritePropertyName("computerAttributes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectComputerAttributesListValue in requestObject.ComputerAttributes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ActiveDirectoryComputerAttributeMarshaller.Instance;
                    marshaller.Marshall(requestObjectComputerAttributesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDirectoryId())
            {
                context.Writer.WritePropertyName("directoryId");
                context.Writer.Write(requestObject.DirectoryId);
            }

            if(requestObject.IsSetOrganizationalUnitDistinguishedName())
            {
                context.Writer.WritePropertyName("organizationalUnitDistinguishedName");
                context.Writer.Write(requestObject.OrganizationalUnitDistinguishedName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ActiveDirectoryConfigurationMarshaller Instance = new ActiveDirectoryConfigurationMarshaller();

    }
}