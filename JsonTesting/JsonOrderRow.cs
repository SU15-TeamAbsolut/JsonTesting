using Newtonsoft.Json;

namespace JsonTesting
{
    public class JsonOrderRow
    {
        [JsonProperty(Required = Required.Always)]
        public int ArticleId { get; set; }
        [JsonProperty(Required = Required.Always)]
        public int Amount { get; set; }
    }
}