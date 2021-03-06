using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IntelligentPromoShopSummaryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IntelligentPromoShopSummaryInfo : AlipayObject
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [JsonProperty("shop_id")]
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 全店名
        /// </summary>
        [JsonProperty("shop_name")]
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
