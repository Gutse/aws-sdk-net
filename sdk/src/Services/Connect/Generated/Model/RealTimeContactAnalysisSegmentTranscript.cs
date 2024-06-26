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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// The analyzed transcript segment.
    /// </summary>
    public partial class RealTimeContactAnalysisSegmentTranscript
    {
        private string _content;
        private string _contentType;
        private string _displayName;
        private string _id;
        private string _participantId;
        private ParticipantRole _participantRole;
        private RealTimeContactAnalysisTranscriptItemRedaction _redaction;
        private RealTimeContactAnalysisSentimentLabel _sentiment;
        private RealTimeContactAnalysisTimeData _time;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the transcript. Can be redacted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16384)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The type of content of the item. For example, <c>text/plain</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the participant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the transcript.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// The identifier of the participant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ParticipantId
        {
            get { return this._participantId; }
            set { this._participantId = value; }
        }

        // Check to see if ParticipantId property is set
        internal bool IsSetParticipantId()
        {
            return this._participantId != null;
        }

        /// <summary>
        /// Gets and sets the property ParticipantRole. 
        /// <para>
        /// The role of the participant. For example, is it a customer, agent, or system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ParticipantRole ParticipantRole
        {
            get { return this._participantRole; }
            set { this._participantRole = value; }
        }

        // Check to see if ParticipantRole property is set
        internal bool IsSetParticipantRole()
        {
            return this._participantRole != null;
        }

        /// <summary>
        /// Gets and sets the property Redaction. 
        /// <para>
        /// Object describing redaction that was applied to the transcript. If transcript has
        /// the field it means part of the transcript was redacted.
        /// </para>
        /// </summary>
        public RealTimeContactAnalysisTranscriptItemRedaction Redaction
        {
            get { return this._redaction; }
            set { this._redaction = value; }
        }

        // Check to see if Redaction property is set
        internal bool IsSetRedaction()
        {
            return this._redaction != null;
        }

        /// <summary>
        /// Gets and sets the property Sentiment. 
        /// <para>
        /// The sentiment detected for this piece of transcript.
        /// </para>
        /// </summary>
        public RealTimeContactAnalysisSentimentLabel Sentiment
        {
            get { return this._sentiment; }
            set { this._sentiment = value; }
        }

        // Check to see if Sentiment property is set
        internal bool IsSetSentiment()
        {
            return this._sentiment != null;
        }

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// Field describing the time of the event. It can have different representations of time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RealTimeContactAnalysisTimeData Time
        {
            get { return this._time; }
            set { this._time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this._time != null;
        }

    }
}