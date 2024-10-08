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
    /// this will let us know specific hardware information
    /// </summary>
    [DataContract(Name = "OSDeviceHardwareInformation")]
    public partial class OSDeviceHardwareInformation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OSDeviceHardwareInformation" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="cpu">cpu.</param>
        /// <param name="gpu">gpu.</param>
        public OSDeviceHardwareInformation(EmbeddedModelSchema schema = default(EmbeddedModelSchema), OSDeviceCPUHardwareInformation cpu = default(OSDeviceCPUHardwareInformation), OSDeviceGPUHardwareInformation gpu = default(OSDeviceGPUHardwareInformation))
        {
            this.Schema = schema;
            this.Cpu = cpu;
            this.Gpu = gpu;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Cpu
        /// </summary>
        [DataMember(Name = "cpu", EmitDefaultValue = false)]
        public OSDeviceCPUHardwareInformation Cpu { get; set; }

        /// <summary>
        /// Gets or Sets Gpu
        /// </summary>
        [DataMember(Name = "gpu", EmitDefaultValue = false)]
        public OSDeviceGPUHardwareInformation Gpu { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OSDeviceHardwareInformation {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Cpu: ").Append(Cpu).Append("\n");
            sb.Append("  Gpu: ").Append(Gpu).Append("\n");
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
