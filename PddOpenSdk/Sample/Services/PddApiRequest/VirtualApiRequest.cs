using App.Models.PddApiResult;
using App.Models.PddApiResponse;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace App.Services.PddApiRequest
{
    public class VirtualApiRequest : PddRequest {
        /// <summary>
/// 虚拟类目发货通知接口
/// </summary>
public async Task<NotifyVirtualMobileChargeResponseModel> NotifyVirtualMobileChargeAsync(NotifyVirtualMobileChargeRequestModel notifyVirtualMobileCharge)
{
    var result = await PostAsync<NotifyVirtualMobileChargeRequestModel,NotifyVirtualMobileChargeResponseModel>("pdd.virtual.mobile.charge.notify",notifyVirtualMobileCharge);
    return result;
}

    }
}
