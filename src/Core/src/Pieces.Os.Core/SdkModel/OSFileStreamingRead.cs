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
    /// This is a model to return stream progress for a file read.
    /// </summary>
    [DataContract(Name = "OSFileStreamingRead")]
    public partial class OSFileStreamingRead : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public ModelDownloadProgressStatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OSFileStreamingRead" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OSFileStreamingRead() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OSFileStreamingRead" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="status">status (required).</param>
        /// <param name="percentage">Optionally if the download is in progress you will receive a download percent(from 0-100)..</param>
        /// <param name="path">path (required).</param>
        /// <param name="id">This is a generated UUID that represents this current stream in progress(can be used to cancel this in the future) (required).</param>
        /// <param name="bytes">bytes.</param>
        /// <param name="progress">progress.</param>
        public OSFileStreamingRead(EmbeddedModelSchema schema = default(EmbeddedModelSchema), ModelDownloadProgressStatusEnum status = default(ModelDownloadProgressStatusEnum), decimal? percentage = default(decimal?), string path = default(string), string id = default(string), TransferableBytes bytes = default(TransferableBytes), OSFileStreamingReadProgress progress = default(OSFileStreamingReadProgress))
        {
            this.Status = status;
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new ArgumentNullException("path is a required property for OSFileStreamingRead and cannot be null");
            }
            this.Path = path;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for OSFileStreamingRead and cannot be null");
            }
            this.Id = id;
            this.Schema = schema;
            this.Percentage = percentage;
            this.Bytes = bytes;
            this.Progress = progress;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Optionally if the download is in progress you will receive a download percent(from 0-100).
        /// </summary>
        /// <value>Optionally if the download is in progress you will receive a download percent(from 0-100).</value>
        [DataMember(Name = "percentage", EmitDefaultValue = true)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// This is a generated UUID that represents this current stream in progress(can be used to cancel this in the future)
        /// </summary>
        /// <value>This is a generated UUID that represents this current stream in progress(can be used to cancel this in the future)</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Bytes
        /// </summary>
        [DataMember(Name = "bytes", EmitDefaultValue = false)]
        public TransferableBytes Bytes { get; set; }

        /// <summary>
        /// Gets or Sets Progress
        /// </summary>
        [DataMember(Name = "progress", EmitDefaultValue = false)]
        public OSFileStreamingReadProgress Progress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OSFileStreamingRead {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Bytes: ").Append(Bytes).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
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
