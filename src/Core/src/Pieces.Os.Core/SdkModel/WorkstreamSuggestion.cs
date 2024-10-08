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
    /// This is an individual material that is apart of the workstream feed. might want to also consider plural uuids ie top websites/tags/and others..  related: this is an optional field that will only be calculated for first degree relationships.          ie. an anchor may have related.iterable.first.persons that are not associated but related.          via the workstream patturn engine.  current: if current is defined then this is the current viewed object
    /// </summary>
    [DataContract(Name = "WorkstreamSuggestion")]
    public partial class WorkstreamSuggestion : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkstreamSuggestion" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="summary">summary.</param>
        /// <param name="asset">asset.</param>
        /// <param name="tag">tag.</param>
        /// <param name="website">website.</param>
        /// <param name="anchor">anchor.</param>
        /// <param name="conversation">conversation.</param>
        /// <param name="person">person.</param>
        /// <param name="seed">seed.</param>
        /// <param name="seeds">seeds.</param>
        /// <param name="summaries">summaries.</param>
        /// <param name="assets">assets.</param>
        /// <param name="tags">tags.</param>
        /// <param name="websites">websites.</param>
        /// <param name="anchors">anchors.</param>
        /// <param name="conversations">conversations.</param>
        /// <param name="persons">persons.</param>
        /// <param name="related">related.</param>
        /// <param name="current">current.</param>
        public WorkstreamSuggestion(EmbeddedModelSchema schema = default(EmbeddedModelSchema), ReferencedWorkstreamSummary summary = default(ReferencedWorkstreamSummary), ReferencedAsset asset = default(ReferencedAsset), ReferencedTag tag = default(ReferencedTag), ReferencedWebsite website = default(ReferencedWebsite), ReferencedAnchor anchor = default(ReferencedAnchor), ReferencedConversation conversation = default(ReferencedConversation), ReferencedPerson person = default(ReferencedPerson), Seed seed = default(Seed), Seeds seeds = default(Seeds), FlattenedWorkstreamSummaries summaries = default(FlattenedWorkstreamSummaries), FlattenedAssets assets = default(FlattenedAssets), FlattenedTags tags = default(FlattenedTags), FlattenedWebsites websites = default(FlattenedWebsites), FlattenedAnchors anchors = default(FlattenedAnchors), FlattenedConversations conversations = default(FlattenedConversations), FlattenedPersons persons = default(FlattenedPersons), WorkstreamSuggestions related = default(WorkstreamSuggestions), WorkstreamSuggestion current = default(WorkstreamSuggestion))
        {
            this.Schema = schema;
            this.Summary = summary;
            this.Asset = asset;
            this.Tag = tag;
            this.Website = website;
            this.Anchor = anchor;
            this.Conversation = conversation;
            this.Person = person;
            this.Seed = seed;
            this.Seeds = seeds;
            this.Summaries = summaries;
            this.Assets = assets;
            this.Tags = tags;
            this.Websites = websites;
            this.Anchors = anchors;
            this.Conversations = conversations;
            this.Persons = persons;
            this.Related = related;
            this.Current = current;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public ReferencedWorkstreamSummary Summary { get; set; }

        /// <summary>
        /// Gets or Sets Asset
        /// </summary>
        [DataMember(Name = "asset", EmitDefaultValue = false)]
        public ReferencedAsset Asset { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        public ReferencedTag Tag { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name = "website", EmitDefaultValue = false)]
        public ReferencedWebsite Website { get; set; }

        /// <summary>
        /// Gets or Sets Anchor
        /// </summary>
        [DataMember(Name = "anchor", EmitDefaultValue = false)]
        public ReferencedAnchor Anchor { get; set; }

        /// <summary>
        /// Gets or Sets Conversation
        /// </summary>
        [DataMember(Name = "conversation", EmitDefaultValue = false)]
        public ReferencedConversation Conversation { get; set; }

        /// <summary>
        /// Gets or Sets Person
        /// </summary>
        [DataMember(Name = "person", EmitDefaultValue = false)]
        public ReferencedPerson Person { get; set; }

        /// <summary>
        /// Gets or Sets Seed
        /// </summary>
        [DataMember(Name = "seed", EmitDefaultValue = false)]
        public Seed Seed { get; set; }

        /// <summary>
        /// Gets or Sets Seeds
        /// </summary>
        [DataMember(Name = "seeds", EmitDefaultValue = false)]
        public Seeds Seeds { get; set; }

        /// <summary>
        /// Gets or Sets Summaries
        /// </summary>
        [DataMember(Name = "summaries", EmitDefaultValue = false)]
        public FlattenedWorkstreamSummaries Summaries { get; set; }

        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name = "assets", EmitDefaultValue = false)]
        public FlattenedAssets Assets { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public FlattenedTags Tags { get; set; }

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
        /// Gets or Sets Conversations
        /// </summary>
        [DataMember(Name = "conversations", EmitDefaultValue = false)]
        public FlattenedConversations Conversations { get; set; }

        /// <summary>
        /// Gets or Sets Persons
        /// </summary>
        [DataMember(Name = "persons", EmitDefaultValue = false)]
        public FlattenedPersons Persons { get; set; }

        /// <summary>
        /// Gets or Sets Related
        /// </summary>
        [DataMember(Name = "related", EmitDefaultValue = false)]
        public WorkstreamSuggestions Related { get; set; }

        /// <summary>
        /// Gets or Sets Current
        /// </summary>
        [DataMember(Name = "current", EmitDefaultValue = false)]
        public WorkstreamSuggestion Current { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkstreamSuggestion {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  Anchor: ").Append(Anchor).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
            sb.Append("  Seed: ").Append(Seed).Append("\n");
            sb.Append("  Seeds: ").Append(Seeds).Append("\n");
            sb.Append("  Summaries: ").Append(Summaries).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Websites: ").Append(Websites).Append("\n");
            sb.Append("  Anchors: ").Append(Anchors).Append("\n");
            sb.Append("  Conversations: ").Append(Conversations).Append("\n");
            sb.Append("  Persons: ").Append(Persons).Append("\n");
            sb.Append("  Related: ").Append(Related).Append("\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
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
