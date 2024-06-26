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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeBuild.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CodeCoverage Object
    /// </summary>  
    public class CodeCoverageUnmarshaller : IUnmarshaller<CodeCoverage, XmlUnmarshallerContext>, IUnmarshaller<CodeCoverage, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CodeCoverage IUnmarshaller<CodeCoverage, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CodeCoverage Unmarshall(JsonUnmarshallerContext context)
        {
            CodeCoverage unmarshalledObject = new CodeCoverage();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("branchCoveragePercentage", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.BranchCoveragePercentage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("branchesCovered", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BranchesCovered = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("branchesMissed", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BranchesMissed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("expired", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.Expired = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("filePath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FilePath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lineCoveragePercentage", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.LineCoveragePercentage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("linesCovered", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.LinesCovered = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("linesMissed", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.LinesMissed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("reportARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReportARN = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CodeCoverageUnmarshaller _instance = new CodeCoverageUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CodeCoverageUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}