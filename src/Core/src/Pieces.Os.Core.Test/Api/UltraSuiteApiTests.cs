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
    ///  Class for testing UltraSuiteApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UltraSuiteApiTests : IDisposable
    {
        private UltraSuiteApi instance;

        public UltraSuiteApiTests()
        {
            instance = new UltraSuiteApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UltraSuiteApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UltraSuiteApi
            //Assert.IsType<UltraSuiteApi>(instance);
        }

        /// <summary>
        /// Test AssetsCreateUltraSuiteAsset
        /// </summary>
        [Fact]
        public void AssetsCreateUltraSuiteAssetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SeededUltraSuiteAsset seededUltraSuiteAsset = null;
            //var response = instance.AssetsCreateUltraSuiteAsset(seededUltraSuiteAsset);
            //Assert.IsType<Asset>(response);
        }
    }
}
