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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the TestInvokeAuthorizer operation.
    /// Tests a custom authorization behavior by invoking a specified custom authorizer. Use
    /// this to test and debug the custom authorization behavior of devices that connect to
    /// the IoT device gateway.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">TestInvokeAuthorizer</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class TestInvokeAuthorizerRequest : AmazonIoTRequest
    {
        private string _authorizerName;
        private HttpContext _httpContext;
        private MqttContext _mqttContext;
        private TlsContext _tlsContext;
        private string _token;
        private string _tokenSignature;

        /// <summary>
        /// Gets and sets the property AuthorizerName. 
        /// <para>
        /// The custom authorizer name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string AuthorizerName
        {
            get { return this._authorizerName; }
            set { this._authorizerName = value; }
        }

        // Check to see if AuthorizerName property is set
        internal bool IsSetAuthorizerName()
        {
            return this._authorizerName != null;
        }

        /// <summary>
        /// Gets and sets the property HttpContext. 
        /// <para>
        /// Specifies a test HTTP authorization request.
        /// </para>
        /// </summary>
        public HttpContext HttpContext
        {
            get { return this._httpContext; }
            set { this._httpContext = value; }
        }

        // Check to see if HttpContext property is set
        internal bool IsSetHttpContext()
        {
            return this._httpContext != null;
        }

        /// <summary>
        /// Gets and sets the property MqttContext. 
        /// <para>
        /// Specifies a test MQTT authorization request.
        /// </para>
        /// </summary>
        public MqttContext MqttContext
        {
            get { return this._mqttContext; }
            set { this._mqttContext = value; }
        }

        // Check to see if MqttContext property is set
        internal bool IsSetMqttContext()
        {
            return this._mqttContext != null;
        }

        /// <summary>
        /// Gets and sets the property TlsContext. 
        /// <para>
        /// Specifies a test TLS authorization request.
        /// </para>
        /// </summary>
        public TlsContext TlsContext
        {
            get { return this._tlsContext; }
            set { this._tlsContext = value; }
        }

        // Check to see if TlsContext property is set
        internal bool IsSetTlsContext()
        {
            return this._tlsContext != null;
        }

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The token returned by your custom authentication service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6144)]
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this._token != null;
        }

        /// <summary>
        /// Gets and sets the property TokenSignature. 
        /// <para>
        /// The signature made with the token and your custom authentication service's private
        /// key. This value must be Base-64-encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2560)]
        public string TokenSignature
        {
            get { return this._tokenSignature; }
            set { this._tokenSignature = value; }
        }

        // Check to see if TokenSignature property is set
        internal bool IsSetTokenSignature()
        {
            return this._tokenSignature != null;
        }

    }
}