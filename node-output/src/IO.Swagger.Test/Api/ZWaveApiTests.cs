/* 
 * home-iot-api
 *
 * The API for the EatBacon IOT project
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ZWaveApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ZWaveApiTests
    {
        private ZWaveApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ZWaveApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ZWaveApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ZWaveApi
            //Assert.IsInstanceOfType(typeof(ZWaveApi), instance, "instance is a ZWaveApi");
        }

        /// <summary>
        /// Test GetLightingSummary
        /// </summary>
        [Test]
        public void GetLightingSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetLightingSummary();
            //Assert.IsInstanceOf<LightingSummary> (response, "response is LightingSummary");
        }
        /// <summary>
        /// Test GetSwitchState
        /// </summary>
        [Test]
        public void GetSwitchStateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deviceId = null;
            //var response = instance.GetSwitchState(deviceId);
            //Assert.IsInstanceOf<DeviceState> (response, "response is DeviceState");
        }
        /// <summary>
        /// Test SetDimmer
        /// </summary>
        [Test]
        public void SetDimmerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deviceId = null;
            //int? value = null;
            //var response = instance.SetDimmer(deviceId, value);
            //Assert.IsInstanceOf<ModelApiResponse> (response, "response is ModelApiResponse");
        }
        /// <summary>
        /// Test SetDimmerTimer
        /// </summary>
        [Test]
        public void SetDimmerTimerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deviceId = null;
            //int? value = null;
            //int? timeunit = null;
            //string units = null;
            //var response = instance.SetDimmerTimer(deviceId, value, timeunit, units);
            //Assert.IsInstanceOf<ModelApiResponse> (response, "response is ModelApiResponse");
        }
        /// <summary>
        /// Test SetSwitch
        /// </summary>
        [Test]
        public void SetSwitchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deviceId = null;
            //string value = null;
            //var response = instance.SetSwitch(deviceId, value);
            //Assert.IsInstanceOf<ModelApiResponse> (response, "response is ModelApiResponse");
        }
        /// <summary>
        /// Test SetSwitchTimer
        /// </summary>
        [Test]
        public void SetSwitchTimerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deviceId = null;
            //string value = null;
            //int? minutes = null;
            //var response = instance.SetSwitchTimer(deviceId, value, minutes);
            //Assert.IsInstanceOf<ModelApiResponse> (response, "response is ModelApiResponse");
        }
    }

}
