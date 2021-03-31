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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateEndpointAccess operation
    /// </summary>  
    public class CreateEndpointAccessResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            CreateEndpointAccessResponse response = new CreateEndpointAccessResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("CreateEndpointAccessResult", 2))
                    {
                        UnmarshallResult(context, response);                        
                        continue;
                    }
                    
                    if (context.TestExpression("ResponseMetadata", 2))
                    {
                        response.ResponseMetadata = ResponseMetadataUnmarshaller.Instance.Unmarshall(context);
                    }
                }
            }

            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, CreateEndpointAccessResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("Address", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Address = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClusterIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ClusterIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EndpointCreateTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        response.EndpointCreateTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EndpointName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.EndpointName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EndpointStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.EndpointStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Port", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.Port = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResourceOwner", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ResourceOwner = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SubnetGroupName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.SubnetGroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VpcEndpoint", targetDepth))
                    {
                        var unmarshaller = VpcEndpointUnmarshaller.Instance;
                        response.VpcEndpoint = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VpcSecurityGroups/VpcSecurityGroup", targetDepth))
                    {
                        var unmarshaller = VpcSecurityGroupMembershipUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        response.VpcSecurityGroups.Add(item);
                        continue;
                    }
                } 
           }

            return;
        }


        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessToClusterDenied"))
                {
                    return AccessToClusterDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ClusterNotFound"))
                {
                    return ClusterNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ClusterSubnetGroupNotFoundFault"))
                {
                    return ClusterSubnetGroupNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("EndpointAlreadyExists"))
                {
                    return EndpointAlreadyExistsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("EndpointsPerAuthorizationLimitExceeded"))
                {
                    return EndpointsPerAuthorizationLimitExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("EndpointsPerClusterLimitExceeded"))
                {
                    return EndpointsPerClusterLimitExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidClusterSecurityGroupState"))
                {
                    return InvalidClusterSecurityGroupStateExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidClusterState"))
                {
                    return InvalidClusterStateExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("UnauthorizedOperation"))
                {
                    return UnauthorizedOperationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("UnsupportedOperation"))
                {
                    return UnsupportedOperationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonRedshiftException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static CreateEndpointAccessResponseUnmarshaller _instance = new CreateEndpointAccessResponseUnmarshaller();        

        internal static CreateEndpointAccessResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEndpointAccessResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}