namespace PddOpenSdk.Models.Response.Refund;
public partial class GetRefundListIncrementResponse : PddResponseModel
{

    /// <summary>
    /// 售后增量订单列表对象
    /// </summary>
    [JsonPropertyName("refund_increment_get_response")]
    public RefundIncrementGetResponseResponse RefundIncrementGetResponse { get; set; }
    public partial class RefundIncrementGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 售后列表对象
        /// </summary>
        [JsonPropertyName("refund_list")]
        public List<RefundListResponse> RefundList { get; set; }

        /// <summary>
        /// 返回的售后订单列表总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }
        public partial class RefundListResponse : PddResponseModel
        {

            /// <summary>
            /// 极速退款状态，"1"：有极速退款资格，"2"：极速退款失败, "3" 表示极速退款成功，其他表示非极速退款
            /// </summary>
            [JsonPropertyName("speed_refund_status")]
            public string SpeedRefundStatus { get; set; }

            /// <summary>
            /// 售后原因
            /// </summary>
            [JsonPropertyName("after_sale_reason")]
            public string AfterSaleReason { get; set; }

            /// <summary>
            /// 售后状态 0：无售后 2：买家申请退款，待商家处理 3：退货退款，待商家处理 4：商家同意退款，退款中 5：平台同意退款，退款中 6：驳回退款，待买家处理 7：已同意退货退款,待用户发货 8：平台处理中 9：平台拒绝退款，退款关闭 10：退款成功 11：买家撤销 12：买家逾期未处理，退款失败 13：买家逾期，超过有效期 14：换货补寄待商家处理 15：换货补寄待用户处理 16：换货补寄成功 17：换货补寄失败 18：换货补寄待用户确认完成 21：待商家同意维修 22：待用户确认发货 24：维修关闭 25：维修成功 27：待用户确认收货 31：已同意拒收退款，待用户拒收 32：补寄待商家发货
            /// </summary>
            [JsonPropertyName("after_sales_status")]
            public int? AfterSalesStatus { get; set; }

            /// <summary>
            /// 售后类型
            /// </summary>
            [JsonPropertyName("after_sales_type")]
            public int? AfterSalesType { get; set; }

            /// <summary>
            /// 成团时间
            /// </summary>
            [JsonPropertyName("confirm_time")]
            public string ConfirmTime { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [JsonPropertyName("created_time")]
            public string CreatedTime { get; set; }

            /// <summary>
            /// 订单折扣金额（元）
            /// </summary>
            [JsonPropertyName("discount_amount")]
            public string DiscountAmount { get; set; }

            /// <summary>
            /// 商品图片
            /// </summary>
            [JsonPropertyName("good_image")]
            public string GoodImage { get; set; }

            /// <summary>
            /// 商品编码
            /// </summary>
            [JsonPropertyName("goods_id")]
            public long? GoodsId { get; set; }

            /// <summary>
            /// 商品名称
            /// </summary>
            [JsonPropertyName("goods_name")]
            public string GoodsName { get; set; }

            /// <summary>
            /// 商品数量
            /// </summary>
            [JsonPropertyName("goods_number")]
            public string GoodsNumber { get; set; }

            /// <summary>
            /// 商品单价
            /// </summary>
            [JsonPropertyName("goods_price")]
            public string GoodsPrice { get; set; }

            /// <summary>
            /// 售后编号
            /// </summary>
            [JsonPropertyName("id")]
            public long? Id { get; set; }

            /// <summary>
            /// 订单金额（元）
            /// </summary>
            [JsonPropertyName("order_amount")]
            public string OrderAmount { get; set; }

            /// <summary>
            /// 订单编号
            /// </summary>
            [JsonPropertyName("order_sn")]
            public string OrderSn { get; set; }

            /// <summary>
            /// 商家外部编码（商品）
            /// </summary>
            [JsonPropertyName("outer_goods_id")]
            public string OuterGoodsId { get; set; }

            /// <summary>
            /// 商家外部编码（sku）
            /// </summary>
            [JsonPropertyName("outer_id")]
            public string OuterId { get; set; }

            /// <summary>
            /// 退款金额（元）
            /// </summary>
            [JsonPropertyName("refund_amount")]
            public string RefundAmount { get; set; }

            /// <summary>
            /// 商品规格ID
            /// </summary>
            [JsonPropertyName("sku_id")]
            public string SkuId { get; set; }

            /// <summary>
            /// 快递运单号
            /// </summary>
            [JsonPropertyName("tracking_number")]
            public string TrackingNumber { get; set; }

            /// <summary>
            /// 更新时间
            /// </summary>
            [JsonPropertyName("updated_time")]
            public string UpdatedTime { get; set; }

            /// <summary>
            /// 极速退款标志位 1：极速退款，0：非极速退款
            /// </summary>
            [JsonPropertyName("speed_refund_flag")]
            public int? SpeedRefundFlag { get; set; }

            /// <summary>
            /// 退货物流公司名称
            /// </summary>
            [JsonPropertyName("shipping_name")]
            public string ShippingName { get; set; }

            /// <summary>
            /// 0-未勾选 1-消费者选择的收货状态为未收到货 2-消费者选择的收货状态为已收到货
            /// </summary>
            [JsonPropertyName("user_shipping_status")]
            public string UserShippingStatus { get; set; }

            /// <summary>
            /// 1纠纷退款 0非纠纷退款
            /// </summary>
            [JsonPropertyName("dispute_refund_status")]
            public int? DisputeRefundStatus { get; set; }

        }

    }

}

