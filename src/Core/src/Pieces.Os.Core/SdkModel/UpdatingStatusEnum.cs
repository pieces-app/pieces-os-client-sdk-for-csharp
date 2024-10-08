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
    /// This is a simple enum used to determine the status of the Updating process.(of PiecesOS)  UpdatingStatusEnum(READY_TO_RESTART, AVAILABLE(but not downloaded), DOWNLOADING, UNKNOWN, UP_TO_DATE)  UNKNOWN: should never be the case  These are some enums that are currently not implemented but are for future support( REINSTALL_REQUIRED, CONTACT_SUPPORT)
    /// </summary>
    /// <value>This is a simple enum used to determine the status of the Updating process.(of PiecesOS)  UpdatingStatusEnum(READY_TO_RESTART, AVAILABLE(but not downloaded), DOWNLOADING, UNKNOWN, UP_TO_DATE)  UNKNOWN: should never be the case  These are some enums that are currently not implemented but are for future support( REINSTALL_REQUIRED, CONTACT_SUPPORT)</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UpdatingStatusEnum
    {
        /// <summary>
        /// Enum READYTORESTART for value: READY_TO_RESTART
        /// </summary>
        [EnumMember(Value = "READY_TO_RESTART")]
        READYTORESTART = 1,

        /// <summary>
        /// Enum AVAILABLE for value: AVAILABLE
        /// </summary>
        [EnumMember(Value = "AVAILABLE")]
        AVAILABLE = 2,

        /// <summary>
        /// Enum DOWNLOADING for value: DOWNLOADING
        /// </summary>
        [EnumMember(Value = "DOWNLOADING")]
        DOWNLOADING = 3,

        /// <summary>
        /// Enum UNKNOWN for value: UNKNOWN
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 4,

        /// <summary>
        /// Enum UPTODATE for value: UP_TO_DATE
        /// </summary>
        [EnumMember(Value = "UP_TO_DATE")]
        UPTODATE = 5,

        /// <summary>
        /// Enum REINSTALLREQUIRED for value: REINSTALL_REQUIRED
        /// </summary>
        [EnumMember(Value = "REINSTALL_REQUIRED")]
        REINSTALLREQUIRED = 6,

        /// <summary>
        /// Enum CONTACTSUPPORT for value: CONTACT_SUPPORT
        /// </summary>
        [EnumMember(Value = "CONTACT_SUPPORT")]
        CONTACTSUPPORT = 7
    }

}
