using System.Text.Json.Serialization;

namespace WebApi.DTO
{
    public class DefinitionDto
    {
        [JsonPropertyName("Word")]
        public WordDto? wordDto { get; set; }
        [JsonPropertyName("Wordfr")]
        public WordsFrDto? wordsFrDto { get; set; }
        [JsonPropertyName("Kanjis")]
        public List<KanjisDto>? kanjiDtos { get; set; }
        public FormAdj? formAdj { get; set; }
        public FormVerb? formVerb { get; set; }
    }
}
