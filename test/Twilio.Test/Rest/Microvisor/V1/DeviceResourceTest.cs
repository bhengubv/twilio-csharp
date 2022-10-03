/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Microvisor.V1;

namespace Twilio.Tests.Rest.Microvisor.V1
{

    [TestFixture]
    public class DeviceTest : TwilioTest
    {
        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Microvisor,
                "/v1/Devices",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                DeviceResource.Read(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"devices\": [],\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://microvisor.twilio.com/v1/Devices?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://microvisor.twilio.com/v1/Devices?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"devices\"}}"
                                     ));

            var response = DeviceResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"devices\": [{\"sid\": \"UVaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"unique_name\": \"This is my device; there are many like it.\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"app\": {\"target_sid\": \"KAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"target_hash\": null,\"date_targeted\": \"2021-01-01T12:34:56Z\",\"update_status\": \"up-to-date\",\"update_error_code\": 0,\"reported_sid\": \"KAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_reported\": \"2021-01-01T12:34:56Z\"},\"logging\": {\"enabled\": true,\"date_expires\": \"2021-01-01T12:34:56Z\"},\"date_created\": \"2021-01-01T12:34:56Z\",\"date_updated\": \"2021-01-01T12:34:56Z\",\"url\": \"https://microvisor.twilio.com/v1/Devices/UVaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}],\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://microvisor.twilio.com/v1/Devices?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://microvisor.twilio.com/v1/Devices?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"devices\"}}"
                                     ));

            var response = DeviceResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Microvisor,
                "/v1/Devices/UVXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                DeviceResource.Fetch("UVXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"UVaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"unique_name\": \"This is my device; there are many like it.\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"app\": {\"target_sid\": \"KAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"target_hash\": null,\"date_targeted\": \"2021-01-01T12:34:56Z\",\"update_status\": \"up-to-date\",\"update_error_code\": 0,\"reported_sid\": \"KAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_reported\": \"2021-01-01T12:34:56Z\"},\"logging\": {\"enabled\": true,\"date_expires\": \"2021-01-01T12:34:56Z\"},\"date_created\": \"2021-01-01T12:34:56Z\",\"date_updated\": \"2021-01-01T12:34:56Z\",\"url\": \"https://microvisor.twilio.com/v1/Devices/UVaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = DeviceResource.Fetch("UVXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Microvisor,
                "/v1/Devices/UVXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                DeviceResource.Update("UVXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"UVaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"unique_name\": \"UniqueName\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"app\": {\"target_sid\": \"KAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"target_hash\": null,\"date_targeted\": \"2021-01-01T12:34:56Z\",\"update_status\": \"pending\",\"update_error_code\": 0,\"reported_sid\": null,\"date_reported\": \"2021-01-01T12:34:56Z\"},\"logging\": {\"enabled\": false,\"date_expires\": null},\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"url\": \"https://microvisor.twilio.com/v1/Devices/UVaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = DeviceResource.Update("UVXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}