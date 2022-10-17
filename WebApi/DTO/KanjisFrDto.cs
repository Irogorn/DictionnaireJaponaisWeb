namespace WebApi.DTO
{
    public class KanjisFrDto
    {
        public KanjisFrDto(string onFr, string kunFr, string sKunFr, string sOnFr, string sKunFr2, string sOnFr2, string sKunFr3)
        {
            OnFr = onFr;
            KunFr = kunFr;
            SKunFr = sKunFr;
            SOnFr = sOnFr;
            SKunFr2 = sKunFr2;
            SOnFr2 = sOnFr2;
            SKunFr3 = sKunFr3;
        }

        public string OnFr { get; set; }
        public string KunFr { get; set; }
        public string SKunFr { get; set; }
        public string SOnFr { get; set; }
        public string SKunFr2 { get; set; }
        public string SOnFr2 { get; set; }
        public string SKunFr3 { get; set; }
    }
}
