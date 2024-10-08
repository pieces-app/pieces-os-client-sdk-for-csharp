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
    /// A SeededUEAsset is the minimum data sent from UE required to create an asset within Pieces.  Fragment &amp; file are both optional properties however we will throw an internal error if both fragment and file are passed through or if both are undefined.
    /// </summary>
    [DataContract(Name = "SeededUltraSuiteAsset")]
    public partial class SeededUltraSuiteAsset : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Ext
        /// </summary>
        [DataMember(Name = "ext", EmitDefaultValue = false)]
        public ClassificationSpecificEnum? Ext { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededUltraSuiteAsset" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SeededUltraSuiteAsset() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededUltraSuiteAsset" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="name">(optional) name is the name of the file.</param>
        /// <param name="ext">ext.</param>
        /// <param name="format">format (required).</param>
        /// <param name="description">description.</param>
        public SeededUltraSuiteAsset(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string name = default(string), ClassificationSpecificEnum? ext = default(ClassificationSpecificEnum?), SeededFormat format = default(SeededFormat), string description = default(string))
        {
            // to ensure "format" is required (not null)
            if (format == null)
            {
                throw new ArgumentNullException("format is a required property for SeededUltraSuiteAsset and cannot be null");
            }
            this.Format = format;
            this.Schema = schema;
            this.Name = name;
            this.Ext = ext;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// (optional) name is the name of the file
        /// </summary>
        /// <value>(optional) name is the name of the file</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name = "format", IsRequired = true, EmitDefaultValue = true)]
        public SeededFormat Format { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeededUltraSuiteAsset {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
