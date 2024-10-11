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
    /// TLPCodeSnippetTagifyCode
    /// </summary>
    [DataContract(Name = "TLPCodeSnippetTagifyCode")]
    public partial class TLPCodeSnippetTagifyCode : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TLPCodeSnippetTagifyCode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TLPCodeSnippetTagifyCode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TLPCodeSnippetTagifyCode" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="distribution">stringified array of numbers (required).</param>
        /// <param name="inferredDistribution">stringified array of numbers (required).</param>
        /// <param name="tags">stringified array of strings (required).</param>
        /// <param name="inferredTags">stringified array of strings (required).</param>
        /// <param name="model">this is the model version  (required).</param>
        /// <param name="labelVersion">This is the version of the file that we are using that contains all the possible tags (required).</param>
        /// <param name="threshold">this is the minimum score from the model that a tag needs to have to be included in the tags array. (required).</param>
        /// <param name="inferredThreshold">this is the minimum score from the postprocessing that a tag needs to have to be included in the inferred_tags array. (required).</param>
        /// <param name="context">this is the origin in which this asset was created, application(string representation) (required).</param>
        /// <param name="asset">This is the asset id. (required).</param>
        /// <param name="os">os (required).</param>
        public TLPCodeSnippetTagifyCode(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string distribution = default(string), string inferredDistribution = default(string), string tags = default(string), string inferredTags = default(string), string model = default(string), string labelVersion = default(string), decimal threshold = default(decimal), decimal inferredThreshold = default(decimal), string context = default(string), string asset = default(string), string os = default(string))
        {
            // to ensure "distribution" is required (not null)
            if (distribution == null)
            {
                throw new ArgumentNullException("distribution is a required property for TLPCodeSnippetTagifyCode and cannot be null");
            }
            this.Distribution = distribution;
            // to ensure "inferredDistribution" is required (not null)
            if (inferredDistribution == null)
            {
                throw new ArgumentNullException("inferredDistribution is a required property for TLPCodeSnippetTagifyCode and cannot be null");
            }
            this.InferredDistribution = inferredDistribution;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for TLPCodeSnippetTagifyCode and cannot be null");
            }
            this.Tags = tags;
            // to ensure "inferredTags" is required (not null)
            if (inferredTags == null)
            {
                throw new ArgumentNullException("inferredTags is a required property for TLPCodeSnippetTagifyCode and cannot be null");
            }
            this.InferredTags = inferredTags;
            // to ensure "model" is required (not null)
            if (model == null)
            {
                throw new ArgumentNullException("model is a required property for TLPCodeSnippetTagifyCode and cannot be null");
            }
            this.Model = model;
            // to ensure "labelVersion" is required (not null)
            if (labelVersion == null)
            {
                throw new ArgumentNullException("labelVersion is a required property for TLPCodeSnippetTagifyCode and cannot be null");
            }
            this.LabelVersion = labelVersion;
            this.Threshold = threshold;
            this.InferredThreshold = inferredThreshold;
            // to ensure "context" is required (not null)
            if (context == null)
            {
                throw new ArgumentNullException("context is a required property for TLPCodeSnippetTagifyCode and cannot be null");
            }
            this.Context = context;
            // to ensure "asset" is required (not null)
            if (asset == null)
            {
                throw new ArgumentNullException("asset is a required property for TLPCodeSnippetTagifyCode and cannot be null");
            }
            this.Asset = asset;
            // to ensure "os" is required (not null)
            if (os == null)
            {
                throw new ArgumentNullException("os is a required property for TLPCodeSnippetTagifyCode and cannot be null");
            }
            this.Os = os;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// stringified array of numbers
        /// </summary>
        /// <value>stringified array of numbers</value>
        [DataMember(Name = "distribution", IsRequired = true, EmitDefaultValue = true)]
        public string Distribution { get; set; }

        /// <summary>
        /// stringified array of numbers
        /// </summary>
        /// <value>stringified array of numbers</value>
        [DataMember(Name = "inferred_distribution", IsRequired = true, EmitDefaultValue = true)]
        public string InferredDistribution { get; set; }

        /// <summary>
        /// stringified array of strings
        /// </summary>
        /// <value>stringified array of strings</value>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public string Tags { get; set; }

        /// <summary>
        /// stringified array of strings
        /// </summary>
        /// <value>stringified array of strings</value>
        [DataMember(Name = "inferred_tags", IsRequired = true, EmitDefaultValue = true)]
        public string InferredTags { get; set; }

        /// <summary>
        /// this is the model version 
        /// </summary>
        /// <value>this is the model version </value>
        [DataMember(Name = "model", IsRequired = true, EmitDefaultValue = true)]
        public string Model { get; set; }

        /// <summary>
        /// This is the version of the file that we are using that contains all the possible tags
        /// </summary>
        /// <value>This is the version of the file that we are using that contains all the possible tags</value>
        [DataMember(Name = "label_version", IsRequired = true, EmitDefaultValue = true)]
        public string LabelVersion { get; set; }

        /// <summary>
        /// this is the minimum score from the model that a tag needs to have to be included in the tags array.
        /// </summary>
        /// <value>this is the minimum score from the model that a tag needs to have to be included in the tags array.</value>
        [DataMember(Name = "threshold", IsRequired = true, EmitDefaultValue = true)]
        public decimal Threshold { get; set; }

        /// <summary>
        /// this is the minimum score from the postprocessing that a tag needs to have to be included in the inferred_tags array.
        /// </summary>
        /// <value>this is the minimum score from the postprocessing that a tag needs to have to be included in the inferred_tags array.</value>
        [DataMember(Name = "inferred_threshold", IsRequired = true, EmitDefaultValue = true)]
        public decimal InferredThreshold { get; set; }

        /// <summary>
        /// this is the origin in which this asset was created, application(string representation)
        /// </summary>
        /// <value>this is the origin in which this asset was created, application(string representation)</value>
        [DataMember(Name = "context", IsRequired = true, EmitDefaultValue = true)]
        public string Context { get; set; }

        /// <summary>
        /// This is the asset id.
        /// </summary>
        /// <value>This is the asset id.</value>
        [DataMember(Name = "asset", IsRequired = true, EmitDefaultValue = true)]
        public string Asset { get; set; }

        /// <summary>
        /// Gets or Sets Os
        /// </summary>
        [DataMember(Name = "os", IsRequired = true, EmitDefaultValue = true)]
        public string Os { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TLPCodeSnippetTagifyCode {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Distribution: ").Append(Distribution).Append("\n");
            sb.Append("  InferredDistribution: ").Append(InferredDistribution).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  InferredTags: ").Append(InferredTags).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  LabelVersion: ").Append(LabelVersion).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
            sb.Append("  InferredThreshold: ").Append(InferredThreshold).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
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
