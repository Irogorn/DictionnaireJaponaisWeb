using System.Text.Json.Serialization;

namespace WebApi.DTO
{
    public class WordDto
    {
        public WordDto(string jpRomanji, string jpHiragana, string jpKatakana, string jpKanji, string nbRo, string nbHi, string type,  string? states, string filters, string jpDefinition, string jpDefinitionRo, string tense, List<Commentary> commentaries)
        {
            JpRomanji = jpRomanji;
            JpHiragana = jpHiragana;
            JpKatakana = jpKatakana;
            JpKanji = jpKanji;
            NbRo = nbRo;
            NbHi = nbHi;
            Type = type;
            States = states;
            Filters = filters;
            JpDefinition = jpDefinition;
            JpDefinitionRo = jpDefinitionRo;
            Tense = tense;
            if(commentaries.Count > 0)
            {
                CommentaryDtos = new List<CommentaryDto>();
                foreach (var commentary in commentaries)
                {
                    CommentaryDto commentaryDto = new CommentaryDto();
                    commentaryDto.WordId = commentary.WordId;
                    commentaryDto.UserId = commentary.UserId;
                    commentaryDto.Commentary1 = commentary.Commentary1;
                    CommentaryDtos.Add(commentaryDto);
                }
            }   
        }

        public string JpRomanji { get; set; }
        public string JpHiragana { get; set; }
        public string JpKatakana { get; set; }
        public string JpKanji { get; set; }
        public string NbRo { get; set; }
        public string NbHi { get; set; }
        public string Type { get; set; }
        public string States { get; set; }
        public string Filters { get; set; }
        public string JpDefinition { get; set; }
        public string JpDefinitionRo { get; set; }
        public string Tense { get; set; }
        [JsonPropertyName("Commentaries")]
        public List<CommentaryDto>? CommentaryDtos { get; set; }
    }
}
