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
    /// Query is your hints question. Relevant is the relevant snippets. Answer is the previous answer.(that we are asking a hint up for.)  Query and Answer are both optional here because, you may pass over relevant snippets over ahead of hand if you already have them to answer your questions.
    /// </summary>
    [DataContract(Name = "QGPTHintsInput")]
    public partial class QGPTHintsInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QGPTHintsInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QGPTHintsInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QGPTHintsInput" /> class.
        /// </summary>
        /// <param name="query">query.</param>
        /// <param name="answer">answer.</param>
        /// <param name="relevant">relevant (required).</param>
        /// <param name="application">optional application id.</param>
        /// <param name="model">optional model id.</param>
        public QGPTHintsInput(string query = default(string), QGPTQuestionAnswer answer = default(QGPTQuestionAnswer), RelevantQGPTSeeds relevant = default(RelevantQGPTSeeds), string application = default(string), string model = default(string))
        {
            // to ensure "relevant" is required (not null)
            if (relevant == null)
            {
                throw new ArgumentNullException("relevant is a required property for QGPTHintsInput and cannot be null");
            }
            this.Relevant = relevant;
            this.Query = query;
            this.Answer = answer;
            this.Application = application;
            this.Model = model;
        }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name = "query", EmitDefaultValue = false)]
        public string Query { get; set; }

        /// <summary>
        /// Gets or Sets Answer
        /// </summary>
        [DataMember(Name = "answer", EmitDefaultValue = false)]
        public QGPTQuestionAnswer Answer { get; set; }

        /// <summary>
        /// Gets or Sets Relevant
        /// </summary>
        [DataMember(Name = "relevant", IsRequired = true, EmitDefaultValue = true)]
        public RelevantQGPTSeeds Relevant { get; set; }

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
            sb.Append("class QGPTHintsInput {\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Answer: ").Append(Answer).Append("\n");
            sb.Append("  Relevant: ").Append(Relevant).Append("\n");
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
