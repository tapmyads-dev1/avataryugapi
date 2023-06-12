using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UpdateAvatarUrlRequest {
    /// <summary>
    /// Unique AvatarYug assigned ID of the user on whom the operation will be performed.
    /// </summary>
    /// <value>Unique AvatarYug assigned ID of the user on whom the operation will be performed.</value>
    [DataMember(Name="UserID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserID")]
    public string UserID { get; set; }

    /// <summary>
    /// 3D Avatar Url for the user.
    /// </summary>
    /// <value>3D Avatar Url for the user.</value>
    [DataMember(Name="MeshUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MeshUrl")]
    public string MeshUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpdateAvatarUrlRequest {\n");
      sb.Append("  UserID: ").Append(UserID).Append("\n");
      sb.Append("  MeshUrl: ").Append(MeshUrl).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
    }

}
}
