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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// These settings control how the service handles timecodes throughout the job. These
    /// settings don't affect input clipping.
    /// </summary>
    public partial class TimecodeConfig
    {
        private string _anchor;
        private TimecodeSource _source;
        private string _start;
        private string _timestampOffset;

        /// <summary>
        /// Gets and sets the property Anchor. If you use an editing platform that relies on an
        /// anchor timecode, use Anchor Timecode to specify a timecode that will match the input
        /// video frame to the output video frame. Use 24-hour format with frame number, (HH:MM:SS:FF)
        /// or (HH:MM:SS;FF). This setting ignores frame rate conversion. System behavior for
        /// Anchor Timecode varies depending on your setting for Source. * If Source is set to
        /// Specified Start, the first input frame is the specified value in Start Timecode. Anchor
        /// Timecode and Start Timecode are used calculate output timecode. * If Source is set
        /// to Start at 0 the first frame is 00:00:00:00. * If Source is set to Embedded, the
        /// first frame is the timecode value on the first input frame of the input.
        /// </summary>
        public string Anchor
        {
            get { return this._anchor; }
            set { this._anchor = value; }
        }

        // Check to see if Anchor property is set
        internal bool IsSetAnchor()
        {
            return this._anchor != null;
        }

        /// <summary>
        /// Gets and sets the property Source. Use Source to set how timecodes are handled within
        /// this job. To make sure that your video, audio, captions, and markers are synchronized
        /// and that time-based features, such as image inserter, work correctly, choose the Timecode
        /// source option that matches your assets. All timecodes are in a 24-hour format with
        /// frame number (HH:MM:SS:FF). * Embedded - Use the timecode that is in the input video.
        /// If no embedded timecode is in the source, the service will use Start at 0 instead.
        /// * Start at 0 - Set the timecode of the initial frame to 00:00:00:00. * Specified Start
        /// - Set the timecode of the initial frame to a value other than zero. You use Start
        /// timecode to provide this value.
        /// </summary>
        public TimecodeSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Start. Only use when you set Source to Specified start.
        /// Use Start timecode to specify the timecode for the initial frame. Use 24-hour format
        /// with frame number, (HH:MM:SS:FF) or (HH:MM:SS;FF).
        /// </summary>
        public string Start
        {
            get { return this._start; }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampOffset. Only applies to outputs that support program-date-time
        /// stamp. Use Timestamp offset to overwrite the timecode date without affecting the time
        /// and frame number. Provide the new date as a string in the format "yyyy-mm-dd". To
        /// use Timestamp offset, you must also enable Insert program-date-time in the output
        /// settings. For example, if the date part of your timecodes is 2002-1-25 and you want
        /// to change it to one year later, set Timestamp offset to 2003-1-25.
        /// </summary>
        public string TimestampOffset
        {
            get { return this._timestampOffset; }
            set { this._timestampOffset = value; }
        }

        // Check to see if TimestampOffset property is set
        internal bool IsSetTimestampOffset()
        {
            return this._timestampOffset != null;
        }

    }
}