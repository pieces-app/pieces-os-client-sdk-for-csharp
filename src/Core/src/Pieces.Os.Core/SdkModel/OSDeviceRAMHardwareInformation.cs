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
    /// This will let us know specific hardware information related to the RAM.
    /// </summary>
    [DataContract(Name = "OSDeviceRAMHardwareInformation")]
    public partial class OSDeviceRAMHardwareInformation : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public OSDeviceRAMTypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OSDeviceRAMHardwareInformation" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="memory">memory.</param>
        /// <param name="speed">speed.</param>
        /// <param name="type">type.</param>
        public OSDeviceRAMHardwareInformation(EmbeddedModelSchema schema = default(EmbeddedModelSchema), decimal memory = default(decimal), decimal speed = default(decimal), OSDeviceRAMTypeEnum? type = default(OSDeviceRAMTypeEnum?))
        {
            this.Schema = schema;
            this.Memory = memory;
            this.Speed = speed;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Memory
        /// </summary>
        [DataMember(Name = "memory", EmitDefaultValue = false)]
        public decimal Memory { get; set; }

        /// <summary>
        /// Gets or Sets Speed
        /// </summary>
        [DataMember(Name = "speed", EmitDefaultValue = false)]
        public decimal Speed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OSDeviceRAMHardwareInformation {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Memory: ").Append(Memory).Append("\n");
            sb.Append("  Speed: ").Append(Speed).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
