namespace PddOpenSdk.Models.Request.LogisticsCompany;
public partial class NotifyLogisticsTicket
{

    /// <summary>
    /// 附件url,示例：["http://testimg.yangkeduo.com/pdd_oms/2018-01-16/411068e948835ae053a86c13f8ebb5ee.jpg"]
    /// </summary>
    [JsonPropertyName("attach_path_list")]
    public List<string> AttachPathList { get; set; }

    /// <summary>
    /// 工单id
    /// </summary>
    [JsonPropertyName("ticket_id")]
    public long TicketId { get; set; }

    /// <summary>
    /// 运单号
    /// </summary>
    [JsonPropertyName("waybill_no")]
    public string WaybillNo { get; set; }

    /// <summary>
    /// 处理结果
    /// </summary>
    [JsonPropertyName("handle_result")]
    public string HandleResult { get; set; }

    /// <summary>
    /// 签收状态，0:默认,1:未签收,2:已签收
    /// </summary>
    [JsonPropertyName("sign_state")]
    public int SignState { get; set; }

    /// <summary>
    /// 是否赔付，0:默认,1:未赔付,2:已赔付
    /// </summary>
    [JsonPropertyName("compensate_state")]
    public int CompensateState { get; set; }

    /// <summary>
    /// 赔付金额(单位:分)
    /// </summary>
    [JsonPropertyName("compensate_amount")]
    public long CompensateAmount { get; set; }

    /// <summary>
    /// 责任方，0:默认, 1:消费者,2:商家,3:快递公司,4:其他
    /// </summary>
    [JsonPropertyName("duty")]
    public int? Duty { get; set; }

    /// <summary>
    /// 处理人
    /// </summary>
    [JsonPropertyName("express_dealer")]
    public string ExpressDealer { get; set; }

    /// <summary>
    /// 处理人联系方式
    /// </summary>
    [JsonPropertyName("express_dealer_contact")]
    public string ExpressDealerContact { get; set; }

}

