namespace DecrypterWebApp.Controllers
{
    public class ResponseData
    {
        public int ROT { get; set; }
        public bool IsConsiderLetterCase { get; set; }
        public Alphabet CurrentAlphabet { get; set; }
        public bool IsEncodeText { get; set; }
        public string? Keyword { get; set; }
        public string? Input { get; set; }
        public string? Output { get; set; }
        public string? Convert { get; set; }
    }
}