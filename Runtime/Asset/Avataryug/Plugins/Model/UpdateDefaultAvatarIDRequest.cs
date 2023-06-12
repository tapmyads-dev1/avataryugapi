/*
 * Client
 *
 * AvatarYug Client side API
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */



using System.Runtime.Serialization;
using System.Text;


namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// UpdateDefaultAvatarIDRequest
    /// </summary>
    [DataContract]
    public class UpdateDefaultAvatarIDRequest
    {

        /// <summary>
        /// Gets or Sets DefualtAvatarID
        /// </summary>
        [DataMember(Name = "DefualtAvatarID", EmitDefaultValue = false)]
        public string DefualtAvatarID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateDefaultAvatarIDRequest {\n");
            sb.Append("  DefualtAvatarID: ").Append(DefualtAvatarID).Append("\n");
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



    }

}
