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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for WorkDocsConfiguration Object
    /// </summary>  
    public class WorkDocsConfigurationUnmarshaller : IUnmarshaller<WorkDocsConfiguration, XmlUnmarshallerContext>, IUnmarshaller<WorkDocsConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        WorkDocsConfiguration IUnmarshaller<WorkDocsConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public WorkDocsConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            WorkDocsConfiguration unmarshalledObject = new WorkDocsConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CrawlComments", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CrawlComments = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExclusionPatterns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ExclusionPatterns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FieldMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.FieldMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InclusionPatterns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InclusionPatterns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OrganizationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OrganizationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseChangeLog", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseChangeLog = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static WorkDocsConfigurationUnmarshaller _instance = new WorkDocsConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static WorkDocsConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}