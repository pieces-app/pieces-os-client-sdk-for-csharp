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
    /// This is the input body for the /code_gpt/relevance endpoint.  There are a couple different options that you may take with this Model.  First we will talk about the space in which you will compare your query too. These are the following cases for the space. 1. provide an absolute path on the users machine that we can use locally. 2. provide Seeds that you want to compare to, which will be ONLY fragment/string values(all other values will be ignored) 3. provide assets, here you can provide an iterable of the asset id, and we will do the rest 4. you can set your database boolean to true which will tell us to use your entire DB as the query space.  Note: - for ease of use, we have an additional boolean called &#39;question&#39;, which will also ask your question to gpt3.5, and compare to the relevant snippets that we found. That way you dont need to call /code_gpt/question. Otherwise the next step would be is to take the results and feed them into /code_gpt/question. to get your question answered.
    /// </summary>
    [DataContract(Name = "QGPTRelevanceInput")]
    public partial class QGPTRelevanceInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QGPTRelevanceInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QGPTRelevanceInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QGPTRelevanceInput" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="query">This is the question that the user is asking. (required).</param>
        /// <param name="paths">This is an optional list of file || folder paths..</param>
        /// <param name="seeds">seeds.</param>
        /// <param name="assets">assets.</param>
        /// <param name="messages">messages.</param>
        /// <param name="options">options.</param>
        /// <param name="application">optional application id.</param>
        /// <param name="model">optional model id.</param>
        /// <param name="temporal">temporal.</param>
        /// <param name="anchors">anchors.</param>
        public QGPTRelevanceInput(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string query = default(string), List<string> paths = default(List<string>), Seeds seeds = default(Seeds), FlattenedAssets assets = default(FlattenedAssets), FlattenedConversationMessages messages = default(FlattenedConversationMessages), QGPTRelevanceInputOptions options = default(QGPTRelevanceInputOptions), string application = default(string), string model = default(string), TemporalRangeGrounding temporal = default(TemporalRangeGrounding), FlattenedAnchors anchors = default(FlattenedAnchors))
        {
            // to ensure "query" is required (not null)
            if (query == null)
            {
                throw new ArgumentNullException("query is a required property for QGPTRelevanceInput and cannot be null");
            }
            this.Query = query;
            this.Schema = schema;
            this.Paths = paths;
            this.Seeds = seeds;
            this.Assets = assets;
            this.Messages = messages;
            this.Options = options;
            this.Application = application;
            this.Model = model;
            this.Temporal = temporal;
            this.Anchors = anchors;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// This is the question that the user is asking.
        /// </summary>
        /// <value>This is the question that the user is asking.</value>
        [DataMember(Name = "query", IsRequired = true, EmitDefaultValue = true)]
        public string Query { get; set; }

        /// <summary>
        /// This is an optional list of file || folder paths.
        /// </summary>
        /// <value>This is an optional list of file || folder paths.</value>
        [DataMember(Name = "paths", EmitDefaultValue = false)]
        public List<string> Paths { get; set; }

        /// <summary>
        /// Gets or Sets Seeds
        /// </summary>
        [DataMember(Name = "seeds", EmitDefaultValue = false)]
        public Seeds Seeds { get; set; }

        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name = "assets", EmitDefaultValue = false)]
        public FlattenedAssets Assets { get; set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name = "messages", EmitDefaultValue = false)]
        public FlattenedConversationMessages Messages { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public QGPTRelevanceInputOptions Options { get; set; }

        /// <summary>
        /// optional application id
        /// </summary>
        /// <value>optional application id</value>
        [DataMember(Name = "application", EmitDefaultValue = false)]
        public string Application { get; set; }

        /// <summary>
        /// optional model id
        /// </summary>
        /// <value>optional model id</value>
        [DataMember(Name = "model", EmitDefaultValue = false)]
        public string Model { get; set; }

        /// <summary>
        /// Gets or Sets Temporal
        /// </summary>
        [DataMember(Name = "temporal", EmitDefaultValue = false)]
        public TemporalRangeGrounding Temporal { get; set; }

        /// <summary>
        /// Gets or Sets Anchors
        /// </summary>
        [DataMember(Name = "anchors", EmitDefaultValue = false)]
        public FlattenedAnchors Anchors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QGPTRelevanceInput {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Paths: ").Append(Paths).Append("\n");
            sb.Append("  Seeds: ").Append(Seeds).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Temporal: ").Append(Temporal).Append("\n");
            sb.Append("  Anchors: ").Append(Anchors).Append("\n");
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
