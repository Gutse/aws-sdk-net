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
using System;
using System.Net;
using System.Collections.Generic;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for AbortMultipartUpload operation
    /// </summary>
    public class AbortMultipartUploadResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Invoke the unmarshaller
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {
            AbortMultipartUploadResponse response = new AbortMultipartUploadResponse();
            IWebResponseData responseData = context.ResponseData;
            if (responseData.IsHeaderPresent(S3Constants.AmzHeaderRequestCharged))
                response.RequestCharged = RequestCharged.FindValue(responseData.GetHeaderValue(S3Constants.AmzHeaderRequestCharged));

            return response;
        }

        private static AbortMultipartUploadResponseUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static AbortMultipartUploadResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AbortMultipartUploadResponseUnmarshaller();
                }
                return _instance;
            }
        }
    
    }
}
    
