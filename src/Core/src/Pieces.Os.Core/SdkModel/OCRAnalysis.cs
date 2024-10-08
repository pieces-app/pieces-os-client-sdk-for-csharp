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
    /// This is the data collected during the ocr analysis of an image.
    /// </summary>
    [DataContract(Name = "OCRAnalysis")]
    public partial class OCRAnalysis : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OCRAnalysis" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OCRAnalysis() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OCRAnalysis" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="id">id (required).</param>
        /// <param name="raw">raw (required).</param>
        /// <param name="hocr">hocr (required).</param>
        /// <param name="image">this is a reference the the imageAnalysis. (required).</param>
        /// <param name="model">model (required).</param>
        public OCRAnalysis(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string id = default(string), Format raw = default(Format), Format hocr = default(Format), string image = default(string), Model model = default(Model))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for OCRAnalysis and cannot be null");
            }
            this.Id = id;
            // to ensure "raw" is required (not null)
            if (raw == null)
            {
                throw new ArgumentNullException("raw is a required property for OCRAnalysis and cannot be null");
            }
            this.Raw = raw;
            // to ensure "hocr" is required (not null)
            if (hocr == null)
            {
                throw new ArgumentNullException("hocr is a required property for OCRAnalysis and cannot be null");
            }
            this.Hocr = hocr;
            // to ensure "image" is required (not null)
            if (image == null)
            {
                throw new ArgumentNullException("image is a required property for OCRAnalysis and cannot be null");
            }
            this.Image = image;
            // to ensure "model" is required (not null)
            if (model == null)
            {
                throw new ArgumentNullException("model is a required property for OCRAnalysis and cannot be null");
            }
            this.Model = model;
            this.Schema = schema;
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
        /// Gets or Sets Raw
        /// </summary>
        [DataMember(Name = "raw", IsRequired = true, EmitDefaultValue = true)]
        public Format Raw { get; set; }

        /// <summary>
        /// Gets or Sets Hocr
        /// </summary>
        [DataMember(Name = "hocr", IsRequired = true, EmitDefaultValue = true)]
        public Format Hocr { get; set; }

        /// <summary>
        /// this is a reference the the imageAnalysis.
        /// </summary>
        /// <value>this is a reference the the imageAnalysis.</value>
        [DataMember(Name = "image", IsRequired = true, EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", IsRequired = true, EmitDefaultValue = true)]
        public Model Model { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OCRAnalysis {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Raw: ").Append(Raw).Append("\n");
            sb.Append("  Hocr: ").Append(Hocr).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
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
