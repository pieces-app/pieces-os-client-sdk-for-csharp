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
    /// This is a Semantic Version Enum that will reflect the Semantic version of the api.
    /// </summary>
    /// <value>This is a Semantic Version Enum that will reflect the Semantic version of the api.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EmbeddedModelSchemaSemanticVersionEnum
    {
        /// <summary>
        /// Enum MAJOR0MINOR0PATCH1 for value: MAJOR_0_MINOR_0_PATCH_1
        /// </summary>
        [EnumMember(Value = "MAJOR_0_MINOR_0_PATCH_1")]
        MAJOR0MINOR0PATCH1 = 1
    }

}
