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
    /// OPEN: Means that privacy is fully open CLOSED: Means that privacy is fully locked down, and private ANONYMOUS: Means that we are allowed to collect information but it cannot get attached to me as the user.
    /// </summary>
    /// <value>OPEN: Means that privacy is fully open CLOSED: Means that privacy is fully locked down, and private ANONYMOUS: Means that we are allowed to collect information but it cannot get attached to me as the user.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrivacyEnum
    {
        /// <summary>
        /// Enum OPEN for value: OPEN
        /// </summary>
        [EnumMember(Value = "OPEN")]
        OPEN = 1,

        /// <summary>
        /// Enum CLOSED for value: CLOSED
        /// </summary>
        [EnumMember(Value = "CLOSED")]
        CLOSED = 2,

        /// <summary>
        /// Enum ANONYMOUS for value: ANONYMOUS
        /// </summary>
        [EnumMember(Value = "ANONYMOUS")]
        ANONYMOUS = 3
    }

}
