using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class GetLogisticsAddressRequestModel : PddRequestModel
    {
        /// <summary>
/// 该值为：pdd.logistics.address.get
/// </summary>
[JsonProperty("type")]
public string Type {get;set;}
}
}

