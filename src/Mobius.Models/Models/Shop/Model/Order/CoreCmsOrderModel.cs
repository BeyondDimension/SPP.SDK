namespace Mobius.Models.Shop;

public partial class CoreCmsOrderModel
{
    /// <summary>
    /// 订单号
    /// </summary>
    [JsonPropertyName("orderId")]
    public string OrderId { get; set; } = string.Empty;

    /// <summary>
    /// 商品总价
    /// </summary>
    [JsonPropertyName("goodsAmount")]
    public decimal GoodsAmount { get; set; }

    /// <summary>
    /// 已支付的金额
    /// </summary>
    [JsonPropertyName("payedAmount")]
    public decimal PayedAmount { get; set; }

    /// <summary>
    /// 订单实际销售总额
    /// </summary>
    [JsonPropertyName("orderAmount")]
    public decimal OrderAmount { get; set; }

    /// <summary>
    /// 支付状态
    /// </summary>
    [JsonPropertyName("payStatus")]
    public int PayStatus { get; set; }

    /// <summary>
    /// 发货状态
    /// </summary>
    [JsonPropertyName("shipStatus")]
    public int ShipStatus { get; set; }

    /// <summary>
    /// 订单状态
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }

    /// <summary>
    /// 订单类型
    /// </summary>
    [JsonPropertyName("orderType")]
    public int OrderType { get; set; }

    /// <summary>
    /// 收货方式
    /// </summary>
    [JsonPropertyName("receiptType")]
    public int ReceiptType { get; set; }

    /// <summary>
    /// 支付方式代码
    /// </summary>
    [JsonPropertyName("paymentCode")]
    public string PaymentCode { get; set; } = string.Empty;

    /// <summary>
    /// 支付时间
    /// </summary>
    [JsonPropertyName("paymentTime")]
    public DateTime? PaymentTime { get; set; }

    /// <summary>
    /// 配送方式ID 关联ship.id
    /// </summary>
    [JsonPropertyName("logisticsId")]
    public int LogisticsId { get; set; }

    /// <summary>
    /// 配送方式名称
    /// </summary>
    [JsonPropertyName("logisticsName")]
    public string LogisticsName { get; set; } = string.Empty;

    /// <summary>
    /// 配送费用
    /// </summary>
    [JsonPropertyName("costFreight")]
    public decimal CostFreight { get; set; }

    /// <summary>
    /// 用户ID 关联user.id
    /// </summary>
    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    /// <summary>
    /// 店铺ID 关联seller.id
    /// </summary>
    [JsonPropertyName("sellerId")]
    public int SellerId { get; set; }

    /// <summary>
    /// 售后状态
    /// </summary>
    [JsonPropertyName("confirmStatus")]
    public int ConfirmStatus { get; set; }

    /// <summary>
    /// 确认收货时间
    /// </summary>
    [JsonPropertyName("confirmTime")]
    public DateTime? ConfirmTime { get; set; }

    /// <summary>
    /// 自提门店ID，0就是不门店自提
    /// </summary>
    [JsonPropertyName("storeId")]
    public int StoreId { get; set; }

    /// <summary>
    /// 收货地区ID
    /// </summary>
    [JsonPropertyName("shipAreaId")]
    public int ShipAreaId { get; set; }

    /// <summary>
    /// 收货详细地址
    /// </summary>
    [JsonPropertyName("shipAddress")]
    public string ShipAddress { get; set; } = string.Empty;

    /// <summary>
    /// 收货人姓名
    /// </summary>
    [JsonPropertyName("shipName")]
    public string ShipName { get; set; } = string.Empty;

    /// <summary>
    /// 收货电话
    /// </summary>
    [JsonPropertyName("shipMobile")]
    public string ShipMobile { get; set; } = string.Empty;

    /// <summary>
    /// 商品总重量
    /// </summary>
    [JsonPropertyName("weight")]
    public decimal Weight { get; set; }

    /// <summary>
    /// 开发票
    /// </summary>
    [JsonPropertyName("taxType")]
    public int TaxType { get; set; }

    /// <summary>
    /// 税号
    /// </summary>
    [JsonPropertyName("taxCode")]
    public string TaxCode { get; set; } = string.Empty;

    /// <summary>
    /// 发票抬头
    /// </summary>
    [JsonPropertyName("taxTitle")]
    public string TaxTitle { get; set; } = string.Empty;

    /// <summary>
    /// 使用积分
    /// </summary>
    [JsonPropertyName("point")]
    public int Point { get; set; }

    /// <summary>
    /// 积分抵扣金额
    /// </summary>
    [JsonPropertyName("pointMoney")]
    public decimal PointMoney { get; set; }

    /// <summary>
    /// 订单优惠金额
    /// </summary>
    [JsonPropertyName("orderDiscountAmount")]
    public decimal OrderDiscountAmount { get; set; }

    /// <summary>
    /// 商品优惠金额
    /// </summary>
    [JsonPropertyName("goodsDiscountAmount")]
    public decimal GoodsDiscountAmount { get; set; }

    /// <summary>
    /// 优惠券优惠额度
    /// </summary>
    [JsonPropertyName("couponDiscountAmount")]
    public decimal CouponDiscountAmount { get; set; }

    /// <summary>
    /// 优惠券信息
    /// </summary>
    [JsonPropertyName("coupon")]
    public string Coupon { get; set; } = string.Empty;

    /// <summary>
    /// 优惠信息
    /// </summary>
    [JsonPropertyName("promotionList")]
    public string PromotionList { get; set; } = string.Empty;

    /// <summary>
    /// 买家备注
    /// </summary>
    [JsonPropertyName("memo")]
    public string Memo { get; set; } = string.Empty;

    /// <summary>
    /// 下单IP
    /// </summary>
    [JsonPropertyName("ip")]
    public string IP { get; set; } = string.Empty;

    /// <summary>
    /// 卖家备注
    /// </summary>
    [JsonPropertyName("mark")]
    public string Mark { get; set; } = string.Empty;

    /// <summary>
    /// 订单来源
    /// </summary>
    [JsonPropertyName("source")]
    public int Source { get; set; }

    /// <summary>
    /// 场景值
    /// </summary>
    [JsonPropertyName("scene")]
    public int Scene { get; set; }

    /// <summary>
    /// 是否评论
    /// </summary>
    [JsonPropertyName("isComment")]
    public bool IsComment { get; set; }

    /// <summary>
    /// 删除标志
    /// </summary>
    [JsonPropertyName("isdel")]
    public bool IsDel { get; set; }

    /// <summary>
    /// 关联营销类型对象序列
    /// </summary>
    [JsonPropertyName("objectId")]
    public int ObjectId { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    [JsonPropertyName("createTime")]
    public DateTime CreateTime { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    [JsonPropertyName("updateTime")]
    public DateTime? UpdateTime { get; set; }
}

public partial class CoreCmsOrderModel
{
    /// <summary>
    ///  订单详情
    /// </summary>
    [JsonPropertyName("items")]
    public List<CoreCmsOrderItemModel>? Items { get; set; }

    /// <summary>
    ///  订单详情用户信息
    /// </summary>
    [JsonPropertyName("user")]
    public CoreCmsUserModel? User { get; set; }

    /// <summary>
    ///  订单详情支付单关系
    /// </summary>
    [JsonPropertyName("paymentItem")]
    public List<CoreCmsBillPaymentsModel>? PaymentItem { get; set; }

    /// <summary>
    ///  订单详情退款单
    /// </summary>
    [JsonPropertyName("refundItem")]
    public List<CoreCmsBillRefundModel>? RefundItem { get; set; }

    /// <summary>
    ///  订单详情提货单
    /// </summary>
    [JsonPropertyName("ladingItem")]
    public List<CoreCmsBillLadingModel>? LadingItem { get; set; }

    /// <summary>
    ///  订单详情退货单
    /// </summary>
    [JsonPropertyName("returnItem")]
    public List<CoreCmsBillReshipItemModel>? ReturnItem { get; set; }

    /// <summary>
    ///  订单详情售后单
    /// </summary>
    [JsonPropertyName("aftersalesItem")]
    public List<CoreCmsBillAftersalesModel>? AftersalesItem { get; set; }

    /// <summary>
    ///  订单详情发货单
    /// </summary>
    [JsonPropertyName("delivery")]
    public List<CoreCmsBillDeliveryModel>? Delivery { get; set; }

    /// <summary>
    ///  订单详情门店
    /// </summary>
    [JsonPropertyName("store")]
    public CoreCmsStoreModel? Store { get; set; }

    /// <summary>
    ///  订单详情配送方式
    /// </summary>
    [JsonPropertyName("logistics")]
    public CoreCmsShipModel? Logistics { get; set; }

    /// <summary>
    ///  订单详情获取订单全局状态
    /// </summary>
    [JsonPropertyName("globalStatus")]
    public int GlobalStatus { get; set; }

    /// <summary>
    ///  订单详情获取订单全局状态描述
    /// </summary>
    [JsonPropertyName("globalStatusText")]
    public string GlobalStatusText { get; set; } = string.Empty;

    /// <summary>
    ///  订单详情收货地区地址
    /// </summary>
    [JsonPropertyName("shipAreaName")]
    public string ShipAreaName { get; set; } = string.Empty;

    /// <summary>
    ///  订单详情支付方式中文描述
    /// </summary>
    [JsonPropertyName("paymentName")]
    public string PaymentName { get; set; } = string.Empty;

    /// <summary>
    ///  订单详情优惠券列表
    /// </summary>
    [JsonPropertyName("couponObj")]
    public List<CoreCmsCouponModel>? CouponObj { get; set; }

    /// <summary>
    /// 促销信息
    /// </summary>
    [JsonPropertyName("promotionObj")]
    public Dictionary<int, WxNameTypeDto>? PromotionObj { get; set; }

    /// <summary>
    /// 倒计时标准时间
    /// </summary>
    [JsonPropertyName("remainingTime")]
    public DateTime? RemainingTime { get; set; }

    /// <summary>
    /// 倒计时文字说明
    /// </summary>
    [JsonPropertyName("remaining")]
    public string Remaining { get; set; } = string.Empty;

    /// <summary>
    /// 发票信息
    /// </summary>
    [JsonPropertyName("invoice")]
    public CoreCmsInvoiceModel? Invoice { get; set; }

    /// <summary>
    /// 售后单号
    /// </summary>
    [JsonPropertyName("billAftersalesId")]
    public string BillAftersalesId { get; set; } = string.Empty;

    /// <summary>
    /// 已经退过款的金额
    /// </summary>
    [JsonPropertyName("refunded")]
    public decimal Refunded { get; set; } = 0;

    /// <summary>
    /// 是否能发起售后
    /// </summary>
    [JsonPropertyName("addAftersalesStatus")]
    public bool AddAftersalesStatus { get; set; } = false;

    /// <summary>
    /// 操作日志
    /// </summary>
    [JsonPropertyName("orderLog")]
    public List<CoreCmsOrderLogModel>? OrderLog { get; set; }

    /// <summary>
    /// 状态说明
    /// </summary>
    [JsonPropertyName("statusText")]
    public string StatusText { get; set; } = string.Empty;

    /// <summary>
    /// 支付状态说明
    /// </summary>
    [JsonPropertyName("payStatusText")]
    public string PayStatusText { get; set; } = string.Empty;

    /// <summary>
    /// 发货状态说明
    /// </summary>
    [JsonPropertyName("shipStatusText")]
    public string ShipStatusText { get; set; } = string.Empty;

    /// <summary>
    /// 来源状态说明
    /// </summary>
    [JsonPropertyName("sourceText")]
    public string SourceText { get; set; } = string.Empty;

    /// <summary>
    /// 订单类型状态说明
    /// </summary>
    [JsonPropertyName("typeText")]
    public string TypeText { get; set; } = string.Empty;

    /// <summary>
    /// 发票类型
    /// </summary>
    [JsonPropertyName("taxTypeText")]
    public string TaxTypeText { get; set; } = string.Empty;

    /// <summary>
    /// 支付方式说明
    /// </summary>
    [JsonPropertyName("paymentCodeText")]
    public string PaymentCodeText { get; set; } = string.Empty;

    /// <summary>
    /// 确认收货状态说明
    /// </summary>
    [JsonPropertyName("confirmStatusText")]
    public string ConfirmStatusText { get; set; } = string.Empty;

    /// <summary>
    /// 操作码
    /// </summary>
    [JsonPropertyName("operating")]
    public string Operating { get; set; } = string.Empty;

    /// <summary>
    /// 售后情况
    /// </summary>
    [JsonPropertyName("afterSaleStatus")]
    public string AfterSaleStatus { get; set; } = string.Empty;

    /// <summary>
    /// 用户昵称
    /// </summary>
    [JsonPropertyName("userNickName")]
    public string UserNickName { get; set; } = string.Empty;

    /// <summary>
    /// 用于搜索的商品名
    /// </summary>
    [JsonPropertyName("productNameForSearch")]
    public string ProductNameForSearch { get; set; } = string.Empty;

    /// <summary>
    /// 交易组件订单
    /// </summary>
    [JsonPropertyName("tcOrder")]
    public WeChatTransactionComponentOrderModel? TcOrder { get; set; }
}
