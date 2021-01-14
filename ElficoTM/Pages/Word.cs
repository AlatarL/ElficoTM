namespace ElficoTM.Pages
{
    internal record Word
    {
        public string Elven { get; }
        public string Lang { get; }
        public string Meaning { get; }

        public Word(string elven, string meaning, string lang = null)
        {
            Elven = elven;
            Lang = lang ?? "elfico";
            Meaning = meaning;
        }
    }
}
