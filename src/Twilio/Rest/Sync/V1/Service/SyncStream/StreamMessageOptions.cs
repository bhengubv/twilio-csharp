/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Sync.V1.Service.SyncStream
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Create a new Stream Message.
    /// </summary>
    public class CreateStreamMessageOptions : IOptions<StreamMessageResource>
    {
        /// <summary>
        /// The SID of the Sync Service to create the new Stream Message in
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Sync Stream to create the new Stream Message resource for
        /// </summary>
        public string PathStreamSid { get; }
        /// <summary>
        /// A JSON string that represents an arbitrary, schema-less object that makes up the Stream Message body
        /// </summary>
        public object Data { get; }

        /// <summary>
        /// Construct a new CreateStreamMessageOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service to create the new Stream Message in </param>
        /// <param name="pathStreamSid"> The SID of the Sync Stream to create the new Stream Message resource for </param>
        /// <param name="data"> A JSON string that represents an arbitrary, schema-less object that makes up the Stream Message
        ///            body </param>
        public CreateStreamMessageOptions(string pathServiceSid, string pathStreamSid, object data)
        {
            PathServiceSid = pathServiceSid;
            PathStreamSid = pathStreamSid;
            Data = data;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Data != null)
            {
                p.Add(new KeyValuePair<string, string>("Data", Serializers.JsonObject(Data)));
            }

            return p;
        }
    }

}