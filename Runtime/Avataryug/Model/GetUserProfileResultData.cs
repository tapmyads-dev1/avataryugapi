using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class GetUserProfileResultData
    {
        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ID")]
        public string ID { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "UpdatedAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "UpdatedAt")]
        public string UpdatedAt { get; set; }

        [DataMember(Name = "ThumbURL", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ThumbURL")]
        public string ThumbURL { get; set; }

        [DataMember(Name = "AvatarURL", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "AvatarURL")]
        public string AvatarURL { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUserProfileResultData {\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ThumbURL: ").Append(ThumbURL).Append("\n");
            sb.Append("  AvatarURL: ").Append(AvatarURL).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

    }
}
