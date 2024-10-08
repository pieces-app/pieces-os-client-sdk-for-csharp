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
    /// This is used for /qgpt/persons/related.  will accept a seed, or conversation all optionally. 
    /// </summary>
    [DataContract(Name = "QGPTPersonsRelatedInput")]
    public partial class QGPTPersonsRelatedInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QGPTPersonsRelatedInput" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="seed">seed.</param>
        /// <param name="conversation">conversation.</param>
        /// <param name="application">optional application id.</param>
        /// <param name="model">optional model id.</param>
        public QGPTPersonsRelatedInput(EmbeddedModelSchema schema = default(EmbeddedModelSchema), Seed seed = default(Seed), QGPTConversation conversation = default(QGPTConversation), string application = default(string), string model = default(string))
        {
            this.Schema = schema;
            this.Seed = seed;
            this.Conversation = conversation;
            this.Application = application;
            this.Model = model;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Seed
        /// </summary>
        [DataMember(Name = "seed", EmitDefaultValue = false)]
        public Seed Seed { get; set; }

        /// <summary>
        /// Gets or Sets Conversation
        /// </summary>
        [DataMember(Name = "conversation", EmitDefaultValue = false)]
        public QGPTConversation Conversation { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QGPTPersonsRelatedInput {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Seed: ").Append(Seed).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
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
