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
    /// This is a specific model to the /backups/create/streamed.
    /// </summary>
    [DataContract(Name = "BackupStreamedProgress")]
    public partial class BackupStreamedProgress : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public ModelDownloadProgressStatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupStreamedProgress" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="status">status.</param>
        /// <param name="percentage">Optionally if the download is in progress you will recieve a download percent(from 0-100)..</param>
        /// <param name="backup">backup.</param>
        public BackupStreamedProgress(EmbeddedModelSchema schema = default(EmbeddedModelSchema), ModelDownloadProgressStatusEnum? status = default(ModelDownloadProgressStatusEnum?), decimal? percentage = default(decimal?), Backup backup = default(Backup))
        {
            this.Schema = schema;
            this.Status = status;
            this.Percentage = percentage;
            this.Backup = backup;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Optionally if the download is in progress you will recieve a download percent(from 0-100).
        /// </summary>
        /// <value>Optionally if the download is in progress you will recieve a download percent(from 0-100).</value>
        [DataMember(Name = "percentage", EmitDefaultValue = true)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Gets or Sets Backup
        /// </summary>
        [DataMember(Name = "backup", EmitDefaultValue = false)]
        public Backup Backup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BackupStreamedProgress {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  Backup: ").Append(Backup).Append("\n");
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
