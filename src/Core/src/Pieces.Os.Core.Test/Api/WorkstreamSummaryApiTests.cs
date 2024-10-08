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
    ///  Class for testing WorkstreamSummaryApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WorkstreamSummaryApiTests : IDisposable
    {
        private WorkstreamSummaryApi instance;

        public WorkstreamSummaryApiTests()
        {
            instance = new WorkstreamSummaryApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WorkstreamSummaryApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WorkstreamSummaryApi
            //Assert.IsType<WorkstreamSummaryApi>(instance);
        }

        /// <summary>
        /// Test WorkstreamSummariesSpecificWorkstreamSummarySnapshot
        /// </summary>
        [Fact]
        public void WorkstreamSummariesSpecificWorkstreamSummarySnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workstreamSummary = null;
            //bool? transferables = null;
            //var response = instance.WorkstreamSummariesSpecificWorkstreamSummarySnapshot(workstreamSummary, transferables);
            //Assert.IsType<WorkstreamSummary>(response);
        }

        /// <summary>
        /// Test WorkstreamSummaryAssociateAnchor
        /// </summary>
        [Fact]
        public void WorkstreamSummaryAssociateAnchorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workstreamSummary = null;
            //string anchor = null;
            //instance.WorkstreamSummaryAssociateAnchor(workstreamSummary, anchor);
        }

        /// <summary>
        /// Test WorkstreamSummaryAssociateAsset
        /// </summary>
        [Fact]
        public void WorkstreamSummaryAssociateAssetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workstreamSummary = null;
            //Guid asset = null;
            //instance.WorkstreamSummaryAssociateAsset(workstreamSummary, asset);
        }

        /// <summary>
        /// Test WorkstreamSummaryAssociateConversation
        /// </summary>
        [Fact]
        public void WorkstreamSummaryAssociateConversationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workstreamSummary = null;
            //string conversation = null;
            //instance.WorkstreamSummaryAssociateConversation(workstreamSummary, conversation);
        }

        /// <summary>
        /// Test WorkstreamSummaryAssociatePerson
        /// </summary>
        [Fact]
        public void WorkstreamSummaryAssociatePersonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workstreamSummary = null;
            //string person = null;
            //instance.WorkstreamSummaryAssociatePerson(workstreamSummary, person);
        }

        /// <summary>
        /// Test WorkstreamSummaryAssociateRange
        /// </summary>
        [Fact]
        public void WorkstreamSummaryAssociateRangeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workstreamSummary = null;
            //string range = null;
            //instance.WorkstreamSummaryAssociateRange(workstreamSummary, range);
        }

        /// <summary>
        /// Test WorkstreamSummaryAssociateWebsite
        /// </summary>
        [Fact]
        public void WorkstreamSummaryAssociateWebsiteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workstreamSummary = null;
            //string website = null;
            //instance.WorkstreamSummaryAssociateWebsite(workstreamSummary, website);
        }

        /// <summary>
        /// Test WorkstreamSummaryAssociateWorkstreamEvent
        /// </summary>
        [Fact]
        public void WorkstreamSummaryAssociateWorkstreamEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workstreamSummary = null;
            //string workstreamEvent = null;
            //instance.WorkstreamSummaryAssociateWorkstreamEvent(workstreamSummary, workstreamEvent);
        }

        /// <summary>
        /// Test WorkstreamSummaryDisassociateAnchor
        /// </summary>
        [Fact]
        public void WorkstreamSummaryDisassociateAnchorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workstreamSummary = null;
            //string anchor = null;
            //instance.WorkstreamSummaryDisassociateAnchor(workstreamSummary, anchor);
        }

        /// <summary>
        /// Test WorkstreamSummaryDisassociateAsset
        /// </summary>
        [Fact]
        public void WorkstreamSummaryDisassociateAssetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workstreamSummary = null;
            //Guid asset = null;
            //instance.WorkstreamSummaryDisassociateAsset(workstreamSummary, asset);
        }

        /// <summary>
        /// Test WorkstreamSummaryDisassociateConversation
        /// </summary>
        [Fact]
        public void WorkstreamSummaryDisassociateConversationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workstreamSummary = null;
            //string conversation = null;
            //instance.WorkstreamSummaryDisassociateConversation(workstreamSummary, conversation);
        }

        /// <summary>
        /// Test WorkstreamSummaryDisassociatePerson
        /// </summary>
        [Fact]
        public void WorkstreamSummaryDisassociatePersonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workstreamSummary = null;
            //string person = null;
            //instance.WorkstreamSummaryDisassociatePerson(workstreamSummary, person);
        }

        /// <summary>
        /// Test WorkstreamSummaryDisassociateRange
        /// </summary>
        [Fact]
        public void WorkstreamSummaryDisassociateRangeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workstreamSummary = null;
            //string range = null;
            //instance.WorkstreamSummaryDisassociateRange(workstreamSummary, range);
        }

        /// <summary>
        /// Test WorkstreamSummaryDisassociateWebsite
        /// </summary>
        [Fact]
        public void WorkstreamSummaryDisassociateWebsiteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workstreamSummary = null;
            //string website = null;
            //instance.WorkstreamSummaryDisassociateWebsite(workstreamSummary, website);
        }

        /// <summary>
        /// Test WorkstreamSummaryDisassociateWorkstreamEvent
        /// </summary>
        [Fact]
        public void WorkstreamSummaryDisassociateWorkstreamEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workstreamSummary = null;
            //string workstreamEvent = null;
            //instance.WorkstreamSummaryDisassociateWorkstreamEvent(workstreamSummary, workstreamEvent);
        }

        /// <summary>
        /// Test WorkstreamSummaryScoresIncrement
        /// </summary>
        [Fact]
        public void WorkstreamSummaryScoresIncrementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workstreamSummary = null;
            //SeededScoreIncrement seededScoreIncrement = null;
            //instance.WorkstreamSummaryScoresIncrement(workstreamSummary, seededScoreIncrement);
        }

        /// <summary>
        /// Test WorkstreamSummaryUpdate
        /// </summary>
        [Fact]
        public void WorkstreamSummaryUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? transferables = null;
            //WorkstreamSummary workstreamSummary = null;
            //var response = instance.WorkstreamSummaryUpdate(transferables, workstreamSummary);
            //Assert.IsType<WorkstreamSummary>(response);
        }
    }
}
