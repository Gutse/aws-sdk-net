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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamQuery.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.TimestreamQuery.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Endpoint discovery parameters for DescribeAccountSettings operation
    /// </summary>  
    public class DescribeAccountSettingsEndpointDiscoveryMarshaller : IMarshaller<EndpointDiscoveryDataBase, DescribeAccountSettingsRequest> , IMarshaller<EndpointDiscoveryDataBase,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the endpoint discovery object.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public EndpointDiscoveryDataBase Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeAccountSettingsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public EndpointDiscoveryDataBase Marshall(DescribeAccountSettingsRequest publicRequest)
        {
            var endpointDiscoveryData = new EndpointDiscoveryData(true);

            return endpointDiscoveryData;
        }
        
        private static DescribeAccountSettingsEndpointDiscoveryMarshaller _instance = new DescribeAccountSettingsEndpointDiscoveryMarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeAccountSettingsEndpointDiscoveryMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
      
    }
}