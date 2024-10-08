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
    /// snippet: these are extracted code blocks selection: here is a copy/paste/selection  note: recommended that you pass in the md version of the webpage  note: please dont pass in all three html,md,text, just pass in 1.
    /// </summary>
    [DataContract(Name = "BrowserTabValue")]
    public partial class BrowserTabValue : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserTabValue" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="html">html.</param>
        /// <param name="md">md.</param>
        /// <param name="text">text.</param>
        /// <param name="snippet">snippet.</param>
        /// <param name="selection">selection.</param>
        public BrowserTabValue(EmbeddedModelSchema schema = default(EmbeddedModelSchema), TransferableString html = default(TransferableString), TransferableString md = default(TransferableString), TransferableString text = default(TransferableString), BrowserSelection snippet = default(BrowserSelection), BrowserSelection selection = default(BrowserSelection))
        {
            this.Schema = schema;
            this.Html = html;
            this.Md = md;
            this.Text = text;
            this.Snippet = snippet;
            this.Selection = selection;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Html
        /// </summary>
        [DataMember(Name = "html", EmitDefaultValue = false)]
        public TransferableString Html { get; set; }

        /// <summary>
        /// Gets or Sets Md
        /// </summary>
        [DataMember(Name = "md", EmitDefaultValue = false)]
        public TransferableString Md { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public TransferableString Text { get; set; }

        /// <summary>
        /// Gets or Sets Snippet
        /// </summary>
        [DataMember(Name = "snippet", EmitDefaultValue = false)]
        public BrowserSelection Snippet { get; set; }

        /// <summary>
        /// Gets or Sets Selection
        /// </summary>
        [DataMember(Name = "selection", EmitDefaultValue = false)]
        public BrowserSelection Selection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BrowserTabValue {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            sb.Append("  Md: ").Append(Md).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Snippet: ").Append(Snippet).Append("\n");
            sb.Append("  Selection: ").Append(Selection).Append("\n");
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
