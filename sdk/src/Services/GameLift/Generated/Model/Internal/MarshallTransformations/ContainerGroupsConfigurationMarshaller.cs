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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ContainerGroupsConfiguration Marshaller
    /// </summary>
    public class ContainerGroupsConfigurationMarshaller : IRequestMarshaller<ContainerGroupsConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ContainerGroupsConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConnectionPortRange())
            {
                context.Writer.WritePropertyName("ConnectionPortRange");
                context.Writer.WriteObjectStart();

                var marshaller = ConnectionPortRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.ConnectionPortRange, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetContainerGroupDefinitionNames())
            {
                context.Writer.WritePropertyName("ContainerGroupDefinitionNames");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectContainerGroupDefinitionNamesListValue in requestObject.ContainerGroupDefinitionNames)
                {
                        context.Writer.Write(requestObjectContainerGroupDefinitionNamesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDesiredReplicaContainerGroupsPerInstance())
            {
                context.Writer.WritePropertyName("DesiredReplicaContainerGroupsPerInstance");
                context.Writer.Write(requestObject.DesiredReplicaContainerGroupsPerInstance);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ContainerGroupsConfigurationMarshaller Instance = new ContainerGroupsConfigurationMarshaller();

    }
}