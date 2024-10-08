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
    /// Bytes is a Model for A FileFormat. Raw and file are the only 2 that are currently supported. Raw and file are an array of integers that represent the file.Typical conversion UTF8 -&gt; array[int] or UTF8 -&gt; array[bytes(in hexidecimal)] -&gt; array[int]. Either way you convert is up to you but the type we need here is an array of integers.  [NOT IMPLEMENTED] base64, base64_url, data_url [IMPLEMENTED] raw
    /// </summary>
    [DataContract(Name = "TransferableBytes")]
    public partial class TransferableBytes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferableBytes" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="raw">IMPLEMENTED.</param>
        /// <param name="base64">NOT IMPLEMENTED.</param>
        /// <param name="base64Url">NOT IMPLEMENTED.</param>
        /// <param name="dataUrl">NOT IMPLEMENTED.</param>
        public TransferableBytes(EmbeddedModelSchema schema = default(EmbeddedModelSchema), List<int> raw = default(List<int>), List<int> base64 = default(List<int>), List<int> base64Url = default(List<int>), List<int> dataUrl = default(List<int>))
        {
            this.Schema = schema;
            this.Raw = raw;
            this.Base64 = base64;
            this.Base64Url = base64Url;
            this.DataUrl = dataUrl;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// IMPLEMENTED
        /// </summary>
        /// <value>IMPLEMENTED</value>
        [DataMember(Name = "raw", EmitDefaultValue = false)]
        public List<int> Raw { get; set; }

        /// <summary>
        /// NOT IMPLEMENTED
        /// </summary>
        /// <value>NOT IMPLEMENTED</value>
        [DataMember(Name = "base64", EmitDefaultValue = false)]
        public List<int> Base64 { get; set; }

        /// <summary>
        /// NOT IMPLEMENTED
        /// </summary>
        /// <value>NOT IMPLEMENTED</value>
        [DataMember(Name = "base64_url", EmitDefaultValue = false)]
        public List<int> Base64Url { get; set; }

        /// <summary>
        /// NOT IMPLEMENTED
        /// </summary>
        /// <value>NOT IMPLEMENTED</value>
        [DataMember(Name = "data_url", EmitDefaultValue = false)]
        public List<int> DataUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferableBytes {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Raw: ").Append(Raw).Append("\n");
            sb.Append("  Base64: ").Append(Base64).Append("\n");
            sb.Append("  Base64Url: ").Append(Base64Url).Append("\n");
            sb.Append("  DataUrl: ").Append(DataUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

            /// <summary>
            /// To validate all properties of the instance
            /// </summary>
            /// <param name="validationContext">Validation context</param>
            /// <returns>Validation Result</returns>
            IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            {
            yield break;
        }
    }

}
