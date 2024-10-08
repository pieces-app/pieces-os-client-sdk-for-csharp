/*
 * Pieces Isomorphic OpenAPI
 *
 * Endpoints for Assets, Formats, Users, Asset, Format, User.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: tsavo@pieces.app
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Pieces.Os.Core.Client;
using Pieces.Os.Core.Api;
// uncomment below to import models
//using Pieces.Os.Core.SdkModel;

namespace Pieces.Os.Core.Test.Api
{
    /// <summary>
    ///  Class for testing AllocationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AllocationsApiTests : IDisposable
    {
        private AllocationsApi instance;

        public AllocationsApiTests()
        {
            instance = new AllocationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AllocationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AllocationsApi
            //Assert.IsType<AllocationsApi>(instance);
        }

        /// <summary>
        /// Test AllocationsConnectNewCloud
        /// </summary>
        [Fact]
        public void AllocationsConnectNewCloudTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserProfile userProfile = null;
            //var response = instance.AllocationsConnectNewCloud(userProfile);
            //Assert.IsType<AllocationCloud>(response);
        }

        /// <summary>
        /// Test AllocationsCreateNewAllocation
        /// </summary>
        [Fact]
        public void AllocationsCreateNewAllocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AllocationCloud allocationCloud = null;
            //var response = instance.AllocationsCreateNewAllocation(allocationCloud);
            //Assert.IsType<AllocationCloud>(response);
        }

        /// <summary>
        /// Test AllocationsDeleteAllocation
        /// </summary>
        [Fact]
        public void AllocationsDeleteAllocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AllocationCloud allocationCloud = null;
            //var response = instance.AllocationsDeleteAllocation(allocationCloud);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test AllocationsDisconnectCloud
        /// </summary>
        [Fact]
        public void AllocationsDisconnectCloudTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AllocationCloud allocationCloud = null;
            //var response = instance.AllocationsDisconnectCloud(allocationCloud);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test AllocationsReconnectCloud
        /// </summary>
        [Fact]
        public void AllocationsReconnectCloudTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AllocationCloud allocationCloud = null;
            //var response = instance.AllocationsReconnectCloud(allocationCloud);
            //Assert.IsType<AllocationCloud>(response);
        }

        /// <summary>
        /// Test AllocationsSnapshot
        /// </summary>
        [Fact]
        public void AllocationsSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AllocationsSnapshot();
            //Assert.IsType<Allocations>(response);
        }
    }
}
