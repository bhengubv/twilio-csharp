/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// InteractionResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.FlexApi.V1
{

    public class InteractionResource : Resource
    {
        private static Request BuildFetchRequest(FetchInteractionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                "/v1/Interactions/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Interaction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Interaction </returns>
        public static InteractionResource Fetch(FetchInteractionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Interaction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Interaction </returns>
        public static async System.Threading.Tasks.Task<InteractionResource> FetchAsync(FetchInteractionOptions options,
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Interaction </returns>
        public static InteractionResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchInteractionOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Interaction </returns>
        public static async System.Threading.Tasks.Task<InteractionResource> FetchAsync(string pathSid,
                                                                                        ITwilioRestClient client = null)
        {
            var options = new FetchInteractionOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateInteractionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                "/v1/Interactions",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Create a new Interaction.
        /// </summary>
        /// <param name="options"> Create Interaction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Interaction </returns>
        public static InteractionResource Create(CreateInteractionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new Interaction.
        /// </summary>
        /// <param name="options"> Create Interaction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Interaction </returns>
        public static async System.Threading.Tasks.Task<InteractionResource> CreateAsync(CreateInteractionOptions options,
                                                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new Interaction.
        /// </summary>
        /// <param name="channel"> The Interaction's channel </param>
        /// <param name="routing"> The Interaction's routing logic </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Interaction </returns>
        public static InteractionResource Create(object channel, object routing, ITwilioRestClient client = null)
        {
            var options = new CreateInteractionOptions(channel, routing);
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new Interaction.
        /// </summary>
        /// <param name="channel"> The Interaction's channel </param>
        /// <param name="routing"> The Interaction's routing logic </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Interaction </returns>
        public static async System.Threading.Tasks.Task<InteractionResource> CreateAsync(object channel,
                                                                                         object routing,
                                                                                         ITwilioRestClient client = null)
        {
            var options = new CreateInteractionOptions(channel, routing);
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a InteractionResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> InteractionResource object represented by the provided JSON </returns>
        public static InteractionResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<InteractionResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The Interaction's channel
        /// </summary>
        [JsonProperty("channel")]
        public object Channel { get; private set; }
        /// <summary>
        /// A JSON Object representing the routing rules for the Interaction Channel
        /// </summary>
        [JsonProperty("routing")]
        public object Routing { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private InteractionResource()
        {

        }
    }

}