using Newtonsoft.Json;

namespace TesteApiRefit
{
    public class UserResponse
    {
        //[JsonProperty("user")]
        //public string User { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("avatar_url")]
        public string Avatar { get; set; }
        [JsonProperty("html_url")]
        public string Link { get; set; }
        [JsonProperty("location")]
        public string Local { get; set; }
    }
}
