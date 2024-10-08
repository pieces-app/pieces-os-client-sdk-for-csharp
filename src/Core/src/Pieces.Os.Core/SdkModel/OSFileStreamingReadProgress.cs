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
    /// This is the progress for the OSFileStreamingRead
    /// </summary>
    [DataContract(Name = "OSFileStreamingReadProgress")]
    public partial class OSFileStreamingReadProgress : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OSFileStreamingReadProgress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OSFileStreamingReadProgress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OSFileStreamingReadProgress" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="total">total (required).</param>
        /// <param name="transferred">transferred (required).</param>
        public OSFileStreamingReadProgress(EmbeddedModelSchema schema = default(EmbeddedModelSchema), ByteDescriptor total = default(ByteDescriptor), ByteDescriptor transferred = default(ByteDescriptor))
        {
            // to ensure "total" is required (not null)
            if (total == null)
            {
                throw new ArgumentNullException("total is a required property for OSFileStreamingReadProgress and cannot be null");
            }
            this.Total = total;
            // to ensure "transferred" is required (not null)
            if (transferred == null)
            {
                throw new ArgumentNullException("transferred is a required property for OSFileStreamingReadProgress and cannot be null");
            }
            this.Transferred = transferred;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public ByteDescriptor Total { get; set; }

        /// <summary>
        /// Gets or Sets Transferred
        /// </summary>
        [DataMember(Name = "transferred", IsRequired = true, EmitDefaultValue = true)]
        public ByteDescriptor Transferred { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OSFileStreamingReadProgress {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Transferred: ").Append(Transferred).Append("\n");
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
