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
    /// This is a published Github Gist.
    /// </summary>
    [DataContract(Name = "GitHubGistDistribution")]
    public partial class GitHubGistDistribution : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GitHubGistDistribution" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GitHubGistDistribution() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GitHubGistDistribution" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="recipients">recipients (required).</param>
        /// <param name="varPublic">This will let us know if the gist is public or private. (required).</param>
        /// <param name="description">This is the description of the Gist Distribution.</param>
        /// <param name="name">This is the name of the gist you will add. (required).</param>
        /// <param name="created">created (required).</param>
        /// <param name="updated">updated (required).</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="githubId">This is the id that github uses to represent the gist. (required).</param>
        /// <param name="url">This is the url where the gist is. (required).</param>
        public GitHubGistDistribution(EmbeddedModelSchema schema = default(EmbeddedModelSchema), Recipients recipients = default(Recipients), bool varPublic = default(bool), string description = default(string), string name = default(string), GroupedTimestamp created = default(GroupedTimestamp), GroupedTimestamp updated = default(GroupedTimestamp), GroupedTimestamp deleted = default(GroupedTimestamp), string githubId = default(string), string url = default(string))
        {
            // to ensure "recipients" is required (not null)
            if (recipients == null)
            {
                throw new ArgumentNullException("recipients is a required property for GitHubGistDistribution and cannot be null");
            }
            this.Recipients = recipients;
            this.Public = varPublic;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for GitHubGistDistribution and cannot be null");
            }
            this.Name = name;
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new ArgumentNullException("created is a required property for GitHubGistDistribution and cannot be null");
            }
            this.Created = created;
            // to ensure "updated" is required (not null)
            if (updated == null)
            {
                throw new ArgumentNullException("updated is a required property for GitHubGistDistribution and cannot be null");
            }
            this.Updated = updated;
            // to ensure "githubId" is required (not null)
            if (githubId == null)
            {
                throw new ArgumentNullException("githubId is a required property for GitHubGistDistribution and cannot be null");
            }
            this.GithubId = githubId;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for GitHubGistDistribution and cannot be null");
            }
            this.Url = url;
            this.Schema = schema;
            this.Description = description;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Recipients
        /// </summary>
        [DataMember(Name = "recipients", IsRequired = true, EmitDefaultValue = true)]
        public Recipients Recipients { get; set; }

        /// <summary>
        /// This will let us know if the gist is public or private.
        /// </summary>
        /// <value>This will let us know if the gist is public or private.</value>
        [DataMember(Name = "public", IsRequired = true, EmitDefaultValue = true)]
        public bool Public { get; set; }

        /// <summary>
        /// This is the description of the Gist Distribution
        /// </summary>
        /// <value>This is the description of the Gist Distribution</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// This is the name of the gist you will add.
        /// </summary>
        /// <value>This is the name of the gist you will add.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = true)]
        public GroupedTimestamp Created { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name = "updated", IsRequired = true, EmitDefaultValue = true)]
        public GroupedTimestamp Updated { get; set; }

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = false)]
        public GroupedTimestamp Deleted { get; set; }

        /// <summary>
        /// This is the id that github uses to represent the gist.
        /// </summary>
        /// <value>This is the id that github uses to represent the gist.</value>
        [DataMember(Name = "github_id", IsRequired = true, EmitDefaultValue = true)]
        public string GithubId { get; set; }

        /// <summary>
        /// This is the url where the gist is.
        /// </summary>
        /// <value>This is the url where the gist is.</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GitHubGistDistribution {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  GithubId: ").Append(GithubId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
