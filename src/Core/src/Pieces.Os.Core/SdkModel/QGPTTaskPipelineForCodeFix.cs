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
    /// This task is for fixing a bit of code.  This is a class so that we can add optional properties in the future.  Note: the snippet &amp;&amp; language that needs to be fixed should be within the QGPTQuestionInput.relevant.
    /// </summary>
    [DataContract(Name = "QGPTTaskPipelineForCodeFix")]
    public partial class QGPTTaskPipelineForCodeFix : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QGPTTaskPipelineForCodeFix" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="error">This is the error message provided from the IDE, that we can use to provide the solution..</param>
        public QGPTTaskPipelineForCodeFix(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string error = default(string))
        {
            this.Schema = schema;
            this.Error = error;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// This is the error message provided from the IDE, that we can use to provide the solution.
        /// </summary>
        /// <value>This is the error message provided from the IDE, that we can use to provide the solution.</value>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QGPTTaskPipelineForCodeFix {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
