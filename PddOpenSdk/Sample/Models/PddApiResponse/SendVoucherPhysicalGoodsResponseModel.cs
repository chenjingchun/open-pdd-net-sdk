using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class SendVoucherPhysicalGoodsResponseModel : PddResponseModel
    {
        /// <summary>
/// 0-失败，1-成功
/// </summary>
[JsonProperty("is_success")]
public object IsSuccess {get;set;}

}
}
