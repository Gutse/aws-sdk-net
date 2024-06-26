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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeDeploy.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDeploymentGroup Request Marshaller
    /// </summary>       
    public class UpdateDeploymentGroupRequestMarshaller : IMarshaller<IRequest, UpdateDeploymentGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDeploymentGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDeploymentGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeDeploy");
            string target = "CodeDeploy_20141006.UpdateDeploymentGroup";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-10-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAlarmConfiguration())
                {
                    context.Writer.WritePropertyName("alarmConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = AlarmConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AlarmConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetApplicationName())
                {
                    context.Writer.WritePropertyName("applicationName");
                    context.Writer.Write(publicRequest.ApplicationName);
                }

                if(publicRequest.IsSetAutoRollbackConfiguration())
                {
                    context.Writer.WritePropertyName("autoRollbackConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = AutoRollbackConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AutoRollbackConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAutoScalingGroups())
                {
                    context.Writer.WritePropertyName("autoScalingGroups");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAutoScalingGroupsListValue in publicRequest.AutoScalingGroups)
                    {
                            context.Writer.Write(publicRequestAutoScalingGroupsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetBlueGreenDeploymentConfiguration())
                {
                    context.Writer.WritePropertyName("blueGreenDeploymentConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = BlueGreenDeploymentConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.BlueGreenDeploymentConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCurrentDeploymentGroupName())
                {
                    context.Writer.WritePropertyName("currentDeploymentGroupName");
                    context.Writer.Write(publicRequest.CurrentDeploymentGroupName);
                }

                if(publicRequest.IsSetDeploymentConfigName())
                {
                    context.Writer.WritePropertyName("deploymentConfigName");
                    context.Writer.Write(publicRequest.DeploymentConfigName);
                }

                if(publicRequest.IsSetDeploymentStyle())
                {
                    context.Writer.WritePropertyName("deploymentStyle");
                    context.Writer.WriteObjectStart();

                    var marshaller = DeploymentStyleMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeploymentStyle, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEc2TagFilters())
                {
                    context.Writer.WritePropertyName("ec2TagFilters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEc2TagFiltersListValue in publicRequest.Ec2TagFilters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = EC2TagFilterMarshaller.Instance;
                        marshaller.Marshall(publicRequestEc2TagFiltersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEc2TagSet())
                {
                    context.Writer.WritePropertyName("ec2TagSet");
                    context.Writer.WriteObjectStart();

                    var marshaller = EC2TagSetMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Ec2TagSet, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEcsServices())
                {
                    context.Writer.WritePropertyName("ecsServices");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEcsServicesListValue in publicRequest.EcsServices)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ECSServiceMarshaller.Instance;
                        marshaller.Marshall(publicRequestEcsServicesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetLoadBalancerInfo())
                {
                    context.Writer.WritePropertyName("loadBalancerInfo");
                    context.Writer.WriteObjectStart();

                    var marshaller = LoadBalancerInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LoadBalancerInfo, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNewDeploymentGroupName())
                {
                    context.Writer.WritePropertyName("newDeploymentGroupName");
                    context.Writer.Write(publicRequest.NewDeploymentGroupName);
                }

                if(publicRequest.IsSetOnPremisesInstanceTagFilters())
                {
                    context.Writer.WritePropertyName("onPremisesInstanceTagFilters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOnPremisesInstanceTagFiltersListValue in publicRequest.OnPremisesInstanceTagFilters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagFilterMarshaller.Instance;
                        marshaller.Marshall(publicRequestOnPremisesInstanceTagFiltersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOnPremisesTagSet())
                {
                    context.Writer.WritePropertyName("onPremisesTagSet");
                    context.Writer.WriteObjectStart();

                    var marshaller = OnPremisesTagSetMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OnPremisesTagSet, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOutdatedInstancesStrategy())
                {
                    context.Writer.WritePropertyName("outdatedInstancesStrategy");
                    context.Writer.Write(publicRequest.OutdatedInstancesStrategy);
                }

                if(publicRequest.IsSetServiceRoleArn())
                {
                    context.Writer.WritePropertyName("serviceRoleArn");
                    context.Writer.Write(publicRequest.ServiceRoleArn);
                }

                if(publicRequest.IsSetTerminationHookEnabled())
                {
                    context.Writer.WritePropertyName("terminationHookEnabled");
                    context.Writer.Write(publicRequest.TerminationHookEnabled);
                }

                if(publicRequest.IsSetTriggerConfigurations())
                {
                    context.Writer.WritePropertyName("triggerConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTriggerConfigurationsListValue in publicRequest.TriggerConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TriggerConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestTriggerConfigurationsListValue, context);

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
        private static UpdateDeploymentGroupRequestMarshaller _instance = new UpdateDeploymentGroupRequestMarshaller();        

        internal static UpdateDeploymentGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDeploymentGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}