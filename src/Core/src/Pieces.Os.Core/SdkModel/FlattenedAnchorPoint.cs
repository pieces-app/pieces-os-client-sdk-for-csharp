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
    /// FlattenedAnchorPoint
    /// </summary>
    [DataContract(Name = "FlattenedAnchorPoint")]
    public partial class FlattenedAnchorPoint : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", EmitDefaultValue = false)]
        public PlatformEnum? Platform { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedAnchorPoint" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlattenedAnchorPoint() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedAnchorPoint" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="id">id (required).</param>
        /// <param name="verified">verified.</param>
        /// <param name="fullpath">This is the text of the path. (required).</param>
        /// <param name="created">created (required).</param>
        /// <param name="updated">updated (required).</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="platform">platform.</param>
        /// <param name="anchor">anchor (required).</param>
        /// <param name="score">score.</param>
        public FlattenedAnchorPoint(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string id = default(string), bool verified = default(bool), string fullpath = default(string), GroupedTimestamp created = default(GroupedTimestamp), GroupedTimestamp updated = default(GroupedTimestamp), GroupedTimestamp deleted = default(GroupedTimestamp), PlatformEnum? platform = default(PlatformEnum?), ReferencedAnchor anchor = default(ReferencedAnchor), Score score = default(Score))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for FlattenedAnchorPoint and cannot be null");
            }
            this.Id = id;
            // to ensure "fullpath" is required (not null)
            if (fullpath == null)
            {
                throw new ArgumentNullException("fullpath is a required property for FlattenedAnchorPoint and cannot be null");
            }
            this.Fullpath = fullpath;
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new ArgumentNullException("created is a required property for FlattenedAnchorPoint and cannot be null");
            }
            this.Created = created;
            // to ensure "updated" is required (not null)
            if (updated == null)
            {
                throw new ArgumentNullException("updated is a required property for FlattenedAnchorPoint and cannot be null");
            }
            this.Updated = updated;
            // to ensure "anchor" is required (not null)
            if (anchor == null)
            {
                throw new ArgumentNullException("anchor is a required property for FlattenedAnchorPoint and cannot be null");
            }
            this.Anchor = anchor;
            this.Schema = schema;
            this.Verified = verified;
            this.Deleted = deleted;
            this.Platform = platform;
            this.Score = score;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Verified
        /// </summary>
        [DataMember(Name = "verified", EmitDefaultValue = true)]
        public bool Verified { get; set; }

        /// <summary>
        /// This is the text of the path.
        /// </summary>
        /// <value>This is the text of the path.</value>
        [DataMember(Name = "fullpath", IsRequired = true, EmitDefaultValue = true)]
        public string Fullpath { get; set; }

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
        /// Gets or Sets Anchor
        /// </summary>
        [DataMember(Name = "anchor", IsRequired = true, EmitDefaultValue = true)]
        public ReferencedAnchor Anchor { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public Score Score { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlattenedAnchorPoint {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
            sb.Append("  Fullpath: ").Append(Fullpath).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Anchor: ").Append(Anchor).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
