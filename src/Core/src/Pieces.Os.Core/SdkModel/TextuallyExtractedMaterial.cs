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
    /// This is an extraction, this was a person/website/anchor that was extracted  this will return the text location where this was found within the extraction.  as well return the material itself that was extracted.  Note: - seeds: will only be extracted people if provided, because the website/anchors will be created if extracted. - basically only thing that is different about the extracted people, if that if we extract a person that was not already saved,   then we will not save them, however if there are related people then we will add them as well.
    /// </summary>
    [DataContract(Name = "TextuallyExtractedMaterial")]
    public partial class TextuallyExtractedMaterial : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextuallyExtractedMaterial" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextuallyExtractedMaterial() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextuallyExtractedMaterial" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="match">match (required).</param>
        /// <param name="websites">websites.</param>
        /// <param name="anchors">anchors.</param>
        /// <param name="persons">persons.</param>
        /// <param name="seeds">seeds.</param>
        public TextuallyExtractedMaterial(EmbeddedModelSchema schema = default(EmbeddedModelSchema), TextLocation match = default(TextLocation), FlattenedWebsites websites = default(FlattenedWebsites), FlattenedAnchors anchors = default(FlattenedAnchors), FlattenedPersons persons = default(FlattenedPersons), Seeds seeds = default(Seeds))
        {
            // to ensure "match" is required (not null)
            if (match == null)
            {
                throw new ArgumentNullException("match is a required property for TextuallyExtractedMaterial and cannot be null");
            }
            this.Match = match;
            this.Schema = schema;
            this.Websites = websites;
            this.Anchors = anchors;
            this.Persons = persons;
            this.Seeds = seeds;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Match
        /// </summary>
        [DataMember(Name = "match", IsRequired = true, EmitDefaultValue = true)]
        public TextLocation Match { get; set; }

        /// <summary>
        /// Gets or Sets Websites
        /// </summary>
        [DataMember(Name = "websites", EmitDefaultValue = false)]
        public FlattenedWebsites Websites { get; set; }

        /// <summary>
        /// Gets or Sets Anchors
        /// </summary>
        [DataMember(Name = "anchors", EmitDefaultValue = false)]
        public FlattenedAnchors Anchors { get; set; }

        /// <summary>
        /// Gets or Sets Persons
        /// </summary>
        [DataMember(Name = "persons", EmitDefaultValue = false)]
        public FlattenedPersons Persons { get; set; }

        /// <summary>
        /// Gets or Sets Seeds
        /// </summary>
        [DataMember(Name = "seeds", EmitDefaultValue = false)]
        public Seeds Seeds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TextuallyExtractedMaterial {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Match: ").Append(Match).Append("\n");
            sb.Append("  Websites: ").Append(Websites).Append("\n");
            sb.Append("  Anchors: ").Append(Anchors).Append("\n");
            sb.Append("  Persons: ").Append(Persons).Append("\n");
            sb.Append("  Seeds: ").Append(Seeds).Append("\n");
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
