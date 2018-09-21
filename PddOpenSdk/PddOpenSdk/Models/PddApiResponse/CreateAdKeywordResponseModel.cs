using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class CreateAdKeywordResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("ad_keyword_create_response")]
        public AdKeywordCreateResponseResponseModel AdKeywordCreateResponse { get; set; }

        public partial class AdKeywordCreateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 是否成功
            /// </summary>
            [JsonProperty("is_success")]
            public object IsSuccess { get; set; }

        }

    }
}