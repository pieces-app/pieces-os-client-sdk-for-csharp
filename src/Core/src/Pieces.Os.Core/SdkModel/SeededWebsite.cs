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
    /// This is the minimum information required to create a website for a specific asset.  you can optionally add an asset, or person id to attach this website directly to it  TODO consider updating these asset,format to referenced Models
    /// </summary>
    [DataContract(Name = "SeededWebsite")]
    public partial class SeededWebsite : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Mechanism
        /// </summary>
        [DataMember(Name = "mechanism", EmitDefaultValue = false)]
        public MechanismEnum? Mechanism { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededWebsite" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SeededWebsite() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededWebsite" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="asset">This is the specific asset that this website is going to get attached to!!.</param>
        /// <param name="conversation">This is the specific conversation that this website is going to get attached to!!.</param>
        /// <param name="url">this is the url of the website. (required).</param>
        /// <param name="name">name of the website.(customizable and updateable as well.) (required).</param>
        /// <param name="mechanism">mechanism.</param>
        /// <param name="person">this is a uuid of a person that we are going to add the website too..</param>
        public SeededWebsite(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string asset = default(string), string conversation = default(string), string url = default(string), string name = default(string), MechanismEnum? mechanism = default(MechanismEnum?), string person = default(string))
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for SeededWebsite and cannot be null");
            }
            this.Url = url;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SeededWebsite and cannot be null");
            }
            this.Name = name;
            this.Schema = schema;
            this.Asset = asset;
            this.Conversation = conversation;
            this.Mechanism = mechanism;
            this.Person = person;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// This is the specific asset that this website is going to get attached to!!
        /// </summary>
        /// <value>This is the specific asset that this website is going to get attached to!!</value>
        [DataMember(Name = "asset", EmitDefaultValue = false)]
        public string Asset { get; set; }

        /// <summary>
        /// This is the specific conversation that this website is going to get attached to!!
        /// </summary>
        /// <value>This is the specific conversation that this website is going to get attached to!!</value>
        [DataMember(Name = "conversation", EmitDefaultValue = false)]
        public string Conversation { get; set; }

        /// <summary>
        /// this is the url of the website.
        /// </summary>
        /// <value>this is the url of the website.</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// name of the website.(customizable and updateable as well.)
        /// </summary>
        /// <value>name of the website.(customizable and updateable as well.)</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// this is a uuid of a person that we are going to add the website too.
        /// </summary>
        /// <value>this is a uuid of a person that we are going to add the website too.</value>
        [DataMember(Name = "person", EmitDefaultValue = false)]
        public string Person { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeededWebsite {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Mechanism: ").Append(Mechanism).Append("\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
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
