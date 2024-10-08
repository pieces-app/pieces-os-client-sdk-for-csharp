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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Pieces.Os.Core.Client.OpenAPIDateConverter;

namespace Pieces.Os.Core.SdkModel
{
    /// <summary>
    /// EXTERNAL_RESOURCE_REFERENCE can be thought of as anything such as URL, URI, UNIX PATH, etc
    /// </summary>
    /// <value>EXTERNAL_RESOURCE_REFERENCE can be thought of as anything such as URL, URI, UNIX PATH, etc</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClassificationGenericEnum
    {
        /// <summary>
        /// Enum CODE for value: CODE
        /// </summary>
        [EnumMember(Value = "CODE")]
        CODE = 1,

        /// <summary>
        /// Enum TEXT for value: TEXT
        /// </summary>
        [EnumMember(Value = "TEXT")]
        TEXT = 2,

        /// <summary>
        /// Enum IMAGE for value: IMAGE
        /// </summary>
        [EnumMember(Value = "IMAGE")]
        IMAGE = 3,

        /// <summary>
        /// Enum VIDEO for value: VIDEO
        /// </summary>
        [EnumMember(Value = "VIDEO")]
        VIDEO = 4,

        /// <summary>
        /// Enum EXTERNALRESOURCEREFERENCE for value: EXTERNAL_RESOURCE_REFERENCE
        /// </summary>
        [EnumMember(Value = "EXTERNAL_RESOURCE_REFERENCE")]
        EXTERNALRESOURCEREFERENCE = 5,

        /// <summary>
        /// Enum UNKNOWN for value: UNKNOWN
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 6,

        /// <summary>
        /// Enum FILE for value: FILE
        /// </summary>
        [EnumMember(Value = "FILE")]
        FILE = 7
    }

}
