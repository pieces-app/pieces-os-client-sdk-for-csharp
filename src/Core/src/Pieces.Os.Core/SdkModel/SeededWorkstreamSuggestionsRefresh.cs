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
    /// This is used in the input of the /workstream/feed/refresh  The application here will let us know if what scope you would like to refresh the stream for. IE an Application will  provide bias in the items that are displayed.  note: context can be used here to provide further bias to the suggestions.
    /// </summary>
    [DataContract(Name = "SeededWorkstreamSuggestionsRefresh")]
    public partial class SeededWorkstreamSuggestionsRefresh : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededWorkstreamSuggestionsRefresh" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SeededWorkstreamSuggestionsRefresh() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededWorkstreamSuggestionsRefresh" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="application">application (required).</param>
        /// <param name="context">context.</param>
        public SeededWorkstreamSuggestionsRefresh(EmbeddedModelSchema schema = default(EmbeddedModelSchema), Application application = default(Application), WorkstreamEventContext context = default(WorkstreamEventContext))
        {
            // to ensure "application" is required (not null)
            if (application == null)
            {
                throw new ArgumentNullException("application is a required property for SeededWorkstreamSuggestionsRefresh and cannot be null");
            }
            this.Application = application;
            this.Schema = schema;
            this.Context = context;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Application
        /// </summary>
        [DataMember(Name = "application", IsRequired = true, EmitDefaultValue = true)]
        public Application Application { get; set; }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name = "context", EmitDefaultValue = false)]
        public WorkstreamEventContext Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeededWorkstreamSuggestionsRefresh {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
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
