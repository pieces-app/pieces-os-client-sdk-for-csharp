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
    ///  Class for testing ConversationMessageApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ConversationMessageApiTests : IDisposable
    {
        private ConversationMessageApi instance;

        public ConversationMessageApiTests()
        {
            instance = new ConversationMessageApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConversationMessageApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ConversationMessageApi
            //Assert.IsType<ConversationMessageApi>(instance);
        }

        /// <summary>
        /// Test MessageAssociateAnnotation
        /// </summary>
        [Fact]
        public void MessageAssociateAnnotationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string annotation = null;
            //string message = null;
            //instance.MessageAssociateAnnotation(annotation, message);
        }

        /// <summary>
        /// Test MessageDisassociateAnnotation
        /// </summary>
        [Fact]
        public void MessageDisassociateAnnotationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string annotation = null;
            //string message = null;
            //instance.MessageDisassociateAnnotation(annotation, message);
        }

        /// <summary>
        /// Test MessageScoresIncrement
        /// </summary>
        [Fact]
        public void MessageScoresIncrementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string message = null;
            //SeededScoreIncrement seededScoreIncrement = null;
            //instance.MessageScoresIncrement(message, seededScoreIncrement);
        }

        /// <summary>
        /// Test MessageSpecificMessageSnapshot
        /// </summary>
        [Fact]
        public void MessageSpecificMessageSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string message = null;
            //bool? transferables = null;
            //var response = instance.MessageSpecificMessageSnapshot(message, transferables);
            //Assert.IsType<ConversationMessage>(response);
        }

        /// <summary>
        /// Test MessageSpecificMessageUpdate
        /// </summary>
        [Fact]
        public void MessageSpecificMessageUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? transferables = null;
            //ConversationMessage conversationMessage = null;
            //var response = instance.MessageSpecificMessageUpdate(transferables, conversationMessage);
            //Assert.IsType<ConversationMessage>(response);
        }

        /// <summary>
        /// Test MessageUpdateValue
        /// </summary>
        [Fact]
        public void MessageUpdateValueTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? transferables = null;
            //ConversationMessage conversationMessage = null;
            //var response = instance.MessageUpdateValue(transferables, conversationMessage);
            //Assert.IsType<ConversationMessage>(response);
        }
    }
}
