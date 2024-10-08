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
    /// Specifically supported renderings...usually between generic types
    /// </summary>
    /// <value>Specifically supported renderings...usually between generic types</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClassificationRenderingEnum
    {
        /// <summary>
        /// Enum HTML for value: HTML
        /// </summary>
        [EnumMember(Value = "HTML")]
        HTML = 1,

        /// <summary>
        /// Enum TWENTYFOURBITANSIESCAPEDSEQUENCES for value: TWENTY_FOUR_BIT_ANSI_ESCAPED_SEQUENCES
        /// </summary>
        [EnumMember(Value = "TWENTY_FOUR_BIT_ANSI_ESCAPED_SEQUENCES")]
        TWENTYFOURBITANSIESCAPEDSEQUENCES = 2,

        /// <summary>
        /// Enum HIGHLIGHTJSHTML for value: HIGHLIGHT_JS_HTML
        /// </summary>
        [EnumMember(Value = "HIGHLIGHT_JS_HTML")]
        HIGHLIGHTJSHTML = 3
    }

}
