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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UpdateMaintenanceWindow operation
    /// </summary>  
    public class UpdateMaintenanceWindowResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            UpdateMaintenanceWindowResponse response = new UpdateMaintenanceWindowResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AllowUnassociatedTargets", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.AllowUnassociatedTargets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Cutoff", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.Cutoff = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Duration", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.Duration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Enabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.Enabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EndDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Schedule", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Schedule = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScheduleOffset", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.ScheduleOffset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScheduleTimezone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ScheduleTimezone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.StartDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WindowId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.WindowId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("DoesNotExistException"))
                {
                    return DoesNotExistExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerError"))
                {
                    return InternalServerErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonSimpleSystemsManagementException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static UpdateMaintenanceWindowResponseUnmarshaller _instance = new UpdateMaintenanceWindowResponseUnmarshaller();        

        internal static UpdateMaintenanceWindowResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMaintenanceWindowResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}