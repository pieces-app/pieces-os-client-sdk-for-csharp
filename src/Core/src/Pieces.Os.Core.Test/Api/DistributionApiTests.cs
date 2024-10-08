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
    ///  Class for testing DistributionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DistributionApiTests : IDisposable
    {
        private DistributionApi instance;

        public DistributionApiTests()
        {
            instance = new DistributionApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DistributionApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DistributionApi
            //Assert.IsType<DistributionApi>(instance);
        }

        /// <summary>
        /// Test DistributionUpdate
        /// </summary>
        [Fact]
        public void DistributionUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Distribution distribution = null;
            //var response = instance.DistributionUpdate(distribution);
            //Assert.IsType<Distribution>(response);
        }

        /// <summary>
        /// Test DistributionsSpecificDistributionSnapshot
        /// </summary>
        [Fact]
        public void DistributionsSpecificDistributionSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string distribution = null;
            //var response = instance.DistributionsSpecificDistributionSnapshot(distribution);
            //Assert.IsType<Distribution>(response);
        }
    }
}
