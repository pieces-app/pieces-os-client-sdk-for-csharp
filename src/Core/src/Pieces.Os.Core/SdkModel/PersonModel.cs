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
    /// This is a PersonSpecific Model. and will let us know for all the assets that get attached to the person if, this person was attached via a model or just attached automatically.  explanation here are the reason why a Person was attached to an asset.
    /// </summary>
    [DataContract(Name = "PersonModel")]
    public partial class PersonModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonModel" /> class.
        /// </summary>
        /// <param name="asset">asset.</param>
        /// <param name="model">model.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="explanation">explanation.</param>
        public PersonModel(ReferencedAsset asset = default(ReferencedAsset), ReferencedModel model = default(ReferencedModel), GroupedTimestamp deleted = default(GroupedTimestamp), ReferencedAnnotation explanation = default(ReferencedAnnotation))
        {
            this.Asset = asset;
            this.Model = model;
            this.Deleted = deleted;
            this.Explanation = explanation;
        }

        /// <summary>
        /// Gets or Sets Asset
        /// </summary>
        [DataMember(Name = "asset", EmitDefaultValue = false)]
        public ReferencedAsset Asset { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", EmitDefaultValue = false)]
        public ReferencedModel Model { get; set; }

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = false)]
        public GroupedTimestamp Deleted { get; set; }

        /// <summary>
        /// Gets or Sets Explanation
        /// </summary>
        [DataMember(Name = "explanation", EmitDefaultValue = false)]
        public ReferencedAnnotation Explanation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PersonModel {\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Explanation: ").Append(Explanation).Append("\n");
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
