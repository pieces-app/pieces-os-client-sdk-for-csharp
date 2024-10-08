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
    /// AssetsSearchWithFiltersInput
    /// </summary>
    [DataContract(Name = "AssetsSearchWithFiltersInput")]
    public partial class AssetsSearchWithFiltersInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetsSearchWithFiltersInput" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="query">query.</param>
        /// <param name="space">space.</param>
        /// <param name="filters">filters.</param>
        /// <param name="casing">This is an optional bool that will let us know, if we want to ignore case or not.(default is to allow casing)ie casing:true..</param>
        public AssetsSearchWithFiltersInput(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string query = default(string), AssetSearchSpace space = default(AssetSearchSpace), AssetFilters filters = default(AssetFilters), bool casing = default(bool))
        {
            this.Schema = schema;
            this.Query = query;
            this.Space = space;
            this.Filters = filters;
            this.Casing = casing;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name = "query", EmitDefaultValue = false)]
        public string Query { get; set; }

        /// <summary>
        /// Gets or Sets Space
        /// </summary>
        [DataMember(Name = "space", EmitDefaultValue = false)]
        public AssetSearchSpace Space { get; set; }

        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name = "filters", EmitDefaultValue = false)]
        public AssetFilters Filters { get; set; }

        /// <summary>
        /// This is an optional bool that will let us know, if we want to ignore case or not.(default is to allow casing)ie casing:true.
        /// </summary>
        /// <value>This is an optional bool that will let us know, if we want to ignore case or not.(default is to allow casing)ie casing:true.</value>
        [DataMember(Name = "casing", EmitDefaultValue = true)]
        public bool Casing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssetsSearchWithFiltersInput {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Space: ").Append(Space).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Casing: ").Append(Casing).Append("\n");
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
