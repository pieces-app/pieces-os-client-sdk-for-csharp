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
    /// A collection of Assets specific to the authenticated user. [DAG Compatible - Directed Acyclic Graph Data Structure]  FlattenedAssets prevent Cycles in Reference because all outbound references are strings as opposed to crosspollinated objects.  i.e. Asset asset &#x3D; FlattenedAssets.iterable[0] &#x3D;&gt; Format format &#x3D; asset.preview &#x3D;&gt; String id &#x3D; format.asset &#x3D;&gt; String id
    /// </summary>
    [DataContract(Name = "FlattenedAssets")]
    public partial class FlattenedAssets : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedAssets" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="iterable">iterable.</param>
        /// <param name="indices">This is a Map&lt;String, int&gt; where the the key is an asset id..</param>
        /// <param name="score">score.</param>
        public FlattenedAssets(EmbeddedModelSchema schema = default(EmbeddedModelSchema), List<ReferencedAsset> iterable = default(List<ReferencedAsset>), Dictionary<string, int> indices = default(Dictionary<string, int>), Score score = default(Score))
        {
            this.Schema = schema;
            this.Iterable = iterable;
            this.Indices = indices;
            this.Score = score;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Iterable
        /// </summary>
        [DataMember(Name = "iterable", EmitDefaultValue = false)]
        public List<ReferencedAsset> Iterable { get; set; }

        /// <summary>
        /// This is a Map&lt;String, int&gt; where the the key is an asset id.
        /// </summary>
        /// <value>This is a Map&lt;String, int&gt; where the the key is an asset id.</value>
        [DataMember(Name = "indices", EmitDefaultValue = false)]
        public Dictionary<string, int> Indices { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public Score Score { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlattenedAssets {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Iterable: ").Append(Iterable).Append("\n");
            sb.Append("  Indices: ").Append(Indices).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
