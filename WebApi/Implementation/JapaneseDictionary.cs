using WebApi.DAL;
using WebApi.DTO;

namespace WebApi.Implementation
{
    public class JapaneseDictionary : IJapaneseDictionary
    {
        private readonly JapaneseDictionaryContext _entites;

        public JapaneseDictionary(JapaneseDictionaryContext japaneseDictionaryContext)
        {
            _entites = japaneseDictionaryContext;
        }
      
        public List<DefinitionDto> GetDefinition(string searchedWord)
        {
            try
            {
                List<DefinitionDto> definitionDtos = new List<DefinitionDto> { };
                List<KanjisDto> kanjisDtos = new List<KanjisDto> { };
                List<CommentaryDto> commentaryDtos = new List<CommentaryDto>();
                var formAdj = new FormAdj();
                var formVerb = new FormVerb();



                if (!String.IsNullOrEmpty(searchedWord))
                {
                    if ((0x3040 <= searchedWord[0]) && (searchedWord[0] <= 0x309F))
                    {
                        var foundWord = _entites.Words.Where(w => w.JpHiragana.Contains(searchedWord)).ToList();
                  
                        foreach(Word word in foundWord)
                        {
                            _entites.Entry(word).Reference(w => w.WordsFr).Load();

                            var arrayKanji = word.JpKanji.ToCharArray();

                           foreach(var k in arrayKanji)
                            {
                                var kanji = _entites.Kanjis.SingleOrDefault(k => k.Kanji1.Equals(k.ToString()));
                                if(kanji != null)
                                {
                                    GetKanjiToKankisDto(_entites, kanji, out var kanjisDto);
                                    kanjisDtos.Add(kanjisDto);
                                }

                            }

                           if(word.Type == "i" || word.Type == "na")
                            {
                               formAdj = _entites.FormAdjs.SingleOrDefault(f => f.Type.Equals(word.Type));
                               formVerb = null;
                            }
                           else if(word.Type == "godan" || word.Type == "ichidan" || word.Type == "irregular")
                            {
                                formVerb = _entites.FormVerbs.SingleOrDefault(f => f.Dan.Equals(word.Type) && f.Stem.Equals(word.JpHiragana.Substring(word.JpHiragana.Length-1)));
                                formAdj = null;
                            }
                            else
                            {
                                formVerb = null;
                                formAdj = null;
                            }

                            _entites.Entry(word).Collection(w => w.Commentaries).Load();

                            definitionDtos.Add(GetDefinitionDto(word, kanjisDtos, formAdj, formVerb));
                            kanjisDtos = new List<KanjisDto> { };
                        }
                        
                        return definitionDtos;
                    }
                    else if ((searchedWord[0] >= 0x30a0) && (searchedWord[0] <= 0x30ff))
                    {
                        var foundWord = _entites.Words.Where(w => w.JpKatakana.Contains(searchedWord)).ToList();
                        
                        foreach (Word word in foundWord)
                        {
                            _entites.Entry(word).Reference(w => w.WordsFr).Load();

                            var arrayKanji = word.JpKanji.ToCharArray();

                            foreach (var k in arrayKanji)
                            {
                                var kanji = _entites.Kanjis.SingleOrDefault(k => k.Kanji1.Equals(k.ToString()));
                                if (kanji != null)
                                {
                                    GetKanjiToKankisDto(_entites, kanji, out var kanjisDto);
                                    kanjisDtos.Add(kanjisDto);
                                }
                            }

                            if (word.Type == "i" || word.Type == "na")
                            {
                                formAdj = _entites.FormAdjs.SingleOrDefault(f => f.Type.Equals(word.Type));
                                formVerb = null;
                            }
                            else if (word.Type == "godan" || word.Type == "ichidan" || word.Type == "irregular")
                            {
                                formVerb = _entites.FormVerbs.SingleOrDefault(f => f.Dan.Equals(word.Type) && f.Stem.Equals(word.JpHiragana.Substring(word.JpHiragana.Length - 1)));
                                formVerb = null;
                            }
                            else
                            {
                                formVerb = null;
                                formAdj = null;
                            }

                            _entites.Entry(word).Collection(w => w.Commentaries).Load();

                            definitionDtos.Add(GetDefinitionDto(word, kanjisDtos, formAdj, formVerb));
                            kanjisDtos = new List<KanjisDto> { };
                        }

                        return definitionDtos;
                    }
                    else if ((searchedWord[0] >= 0x4e00) && (searchedWord[0] <= 0x9faf))
                    {
                        var foundWord = _entites.Words.Where(w => w.JpKanji.Contains(searchedWord)).ToList();
                        
                        foreach (Word word in foundWord)
                        {
                            _entites.Entry(word).Reference(w => w.WordsFr).Load();

                            var arrayKanji = word.JpKanji.ToCharArray();

                            foreach (var k in arrayKanji)
                            {
                                var kanji = _entites.Kanjis.SingleOrDefault(r => r.Kanji1.Equals(k.ToString()));
                                if (kanji != null)
                                {
                                    GetKanjiToKankisDto(_entites, kanji, out var kanjisDto);
                                    kanjisDtos.Add(kanjisDto);
                                }
                            }

                            if (word.Type == "i" || word.Type == "na")
                            {
                                formAdj = _entites.FormAdjs.SingleOrDefault(f => f.Type.Equals(word.Type));
                                formVerb = null;
                            }
                            else if (word.Type == "godan" || word.Type == "ichidan" || word.Type == "irregular")
                            {
                                formVerb = _entites.FormVerbs.SingleOrDefault(f => f.Dan.Equals(word.Type) && f.Stem.Equals(word.JpHiragana.Substring(word.JpHiragana.Length - 1)));
                                formAdj = null;
                            }
                            else
                            {
                                formVerb = null;
                                formAdj = null;
                            }

                            _entites.Entry(word).Collection(w => w.Commentaries).Load();

                            definitionDtos.Add(GetDefinitionDto(word, kanjisDtos, formAdj, formVerb));
                            kanjisDtos = new List<KanjisDto> { };

                        }

                        return definitionDtos;
                    }
                    else
                    {
                        var foundWord = _entites.Words.Where(w => w.WordsFr.French.Contains(searchedWord)).ToList();
                        if (foundWord.Count == 0)
                        {
                            foundWord = _entites.Words.Where(w => w.JpRomanji.Contains(searchedWord)).ToList();
                        }

                        foreach (Word word in foundWord)
                        {
                            _entites.Entry(word).Reference(w => w.WordsFr).Load();

                            var arrayKanji = word.JpKanji.ToCharArray();

                            foreach (var k in arrayKanji)
                            {
                                var kanji = _entites.Kanjis.SingleOrDefault(r => r.Kanji1.Equals(k.ToString()));
                                if (kanji != null)
                                { 
                                    GetKanjiToKankisDto(_entites, kanji, out var kanjisDto);
                                    kanjisDtos.Add(kanjisDto);
                                }  
                            }

                            if (word.Type == "i" || word.Type == "na")
                            {
                                formAdj = _entites.FormAdjs.SingleOrDefault(f => f.Type.Equals(word.Type));
                                formVerb = null;
                            }
                            else if (word.Type == "godan" || word.Type == "ichidan" || word.Type == "irregular")
                            {
                                formVerb = _entites.FormVerbs.SingleOrDefault(f => f.Dan.Equals(word.Type) && f.StemHi.Equals(word.JpHiragana.Substring(word.JpHiragana.Length - 1)));
                                formAdj = null;
                            }
                            else
                            {
                                formVerb = null;
                                formAdj = null;
                            }

                            _entites.Entry(word).Collection(w => w.Commentaries).Load();

                            definitionDtos.Add(GetDefinitionDto(word, kanjisDtos, formAdj, formVerb));
                            kanjisDtos = new List<KanjisDto> { };
                        }

                        return definitionDtos;
                    }
                }

                return definitionDtos;
            }
            catch
            {
                throw;
            }
        }

        private void GetKanjiToKankisDto(JapaneseDictionaryContext entites, Kanji kanji, out KanjisDto kanjisDto)
        {
            entites.Entry(kanji).Reference(b => b.KanjisFr).Load();
            KanjisFrDto kanjisFrDto = new KanjisFrDto(kanji.KanjisFr.OnFr, kanji.KanjisFr.KunFr, kanji.KanjisFr.SKunFr, kanji.KanjisFr.SOnFr, kanji.KanjisFr.SKunFr2, kanji.KanjisFr.SOnFr2, kanji.KanjisFr.SKunFr3);
            kanjisDto = new KanjisDto(kanji.Jlpt, kanji.Kanji1, kanji.NbStrokes, kanji.On, kanji.OnKa, kanji.OnRo, kanji.Kun, kanji.KunRo,
            kanji.SKun, kanji.SKunRo, kanji.SOn, kanji.SOnKa, kanji.SOnRo, kanji.SKun2, kanji.SKunRo2, kanji.SOn2,
            kanji.SOnKa2, kanji.SOnRo2, kanji.SKun3, kanji.SKunRo3, kanjisFrDto);
            
        }

        private DefinitionDto GetDefinitionDto(Word word, List<KanjisDto> kanjisDto, FormAdj? formAdj, FormVerb? formVerb)
        {
            DefinitionDto definitionDto = new DefinitionDto();

            WordDto wordDto = new WordDto(word.JpRomanji, word.JpHiragana, word.JpKatakana, word.JpKanji, word.NbRo, word.NbHi, word.Type, word.States,
                                             word.Filters, word.JpDefinition, word.JpDefinitionRo, word.Tense, word.Commentaries.ToList<Commentary>());
            WordsFrDto wordsFrDto = new WordsFrDto(word.WordsFr.French, word.WordsFr.FrExplication, word.WordsFr.FrDefinition, word.WordsFr.BlueWord);
            definitionDto.wordDto = wordDto;
            definitionDto.wordsFrDto = wordsFrDto;
            definitionDto.kanjiDtos = kanjisDto;
            definitionDto.formVerb = formVerb;
            definitionDto.formAdj = formAdj;

            return definitionDto;
        }
    }
}
