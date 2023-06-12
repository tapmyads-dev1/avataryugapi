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
  public class LoginWithEmailAddressRequest {
    /// <summary>
    /// Gets or Sets EmailID
    /// </summary>
    [DataMember(Name="EmailID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmailID")]
    public string EmailID { get; set; }

    /// <summary>
    /// Gets or Sets Password
    /// </summary>
    [DataMember(Name="Password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Password")]
    public string Password { get; set; }

    /// <summary>
    /// Gets or Sets CreateAccount
    /// </summary>
    [DataMember(Name="CreateAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreateAccount")]
    public bool? CreateAccount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LoginWithEmailAddressRequest {\n");
      sb.Append("  EmailID: ").Append(EmailID).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  CreateAccount: ").Append(CreateAccount).Append("\n");
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
