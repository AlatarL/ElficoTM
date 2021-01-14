namespace ElficoTM.Pages
{
    internal record Word
    {
        public string Elven { get; }
        public string Lang { get; }
        public string Meaning { get; }

        public Word(string elven, string lang, string meaning)
        {
            Elven = elven;
            Lang = lang;
            Meaning = meaning;
        }
    }
}
