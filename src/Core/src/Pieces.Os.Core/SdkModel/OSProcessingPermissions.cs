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
    /// These are the permissions relating to the vision models.
    /// </summary>
    [DataContract(Name = "OSProcessingPermissions")]
    public partial class OSProcessingPermissions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OSProcessingPermissions" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="vision">if true it is granted, if not then it is not granted..</param>
        /// <param name="accessibility">if true it is granted, if not then it is not granted..</param>
        public OSProcessingPermissions(EmbeddedModelSchema schema = default(EmbeddedModelSchema), bool vision = default(bool), bool accessibility = default(bool))
        {
            this.Schema = schema;
            this.Vision = vision;
            this.Accessibility = accessibility;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// if true it is granted, if not then it is not granted.
        /// </summary>
        /// <value>if true it is granted, if not then it is not granted.</value>
        [DataMember(Name = "vision", EmitDefaultValue = true)]
        public bool Vision { get; set; }

        /// <summary>
        /// if true it is granted, if not then it is not granted.
        /// </summary>
        /// <value>if true it is granted, if not then it is not granted.</value>
        [DataMember(Name = "accessibility", EmitDefaultValue = true)]
        public bool Accessibility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OSProcessingPermissions {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Vision: ").Append(Vision).Append("\n");
            sb.Append("  Accessibility: ").Append(Accessibility).Append("\n");
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
