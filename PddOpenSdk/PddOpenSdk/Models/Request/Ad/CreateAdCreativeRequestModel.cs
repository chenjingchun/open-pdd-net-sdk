using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ad
{
    public partial class CreateAdCreativeRequestModel : PddRequestModel
    {
        /// <summary>
        /// 单元id
        /// </summary>
        [JsonProperty("unit_id")]
        public long UnitId { get; set; }
        /// <summary>
        /// 0:搜索广告
        /// </summary>
        [JsonProperty("scene_type")]
        public int SceneType { get; set; }
        /// <summary>
        /// jsonObject 的json string。示例：{"title":"ceshi","image_id":123L}
        /// </summary>
        [JsonProperty("creative")]
        public CreativeRequestModel Creative { get; set; }
        public partial class CreativeRequestModel : PddRequestModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("title")]
            public string Title { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("image_id")]
            public long ImageId { get; set; }

        }

    }

}