using System.Collections.Generic;

namespace ElficoTM.Pages
{
    internal static class Elven
    {
        private const string Q = "quenya";
        private const string S = "sindarin";
        private const string T = "telerin";

        public static List<Word> Words = new List<Word>
        {
            // A
            new ("Acharn", "Vendetta. Nome dell'arco di Suldanas", S),
            new ("Aran Tumno", "Re del profondo. Earlann in forma di balena"),
            new ("Atar", "Padre. Per estensione, Suldanas in quando padre degli dei"),
            new ("Ay" , "Sì"),
            // B
            new ("Bala", "Dio", T),
            new ("Balai", "Dei", T),
            new ("Balain", "Dei", S),
            new ("Balan", "Dio", S),
            new ("Beltaine", "“Dea della vita e delle foreste”, “regina della luce”, “la grande madre”"),
            // C
            new ("Caran-Carch", "Zanna-Rossa. Suldanas in forma di lupo"),
            // D
            // E
            new ("Earlann", "“Dio delle acque e della meditazione”, “signore dei mari”, “il sempre saggio”"),
            // F
            new ("Fara Aer", "Caccia sacra"),
            // G
            // H
            // I
            // J
            // K
            new ("Kelthra", "“Regina dei ragni”, “la figlia di Luugh”, “regina di veleno e malattie”"),
            // L
            new ("Luugh", "“Dio dell’odio e della sofferenza”, “signore del dolore”, “l’invidioso”, “il perfetto”, “l’unico”"),
            // M
            new ("Morrigan", "“Dea della magia e della dissimulazione”, “signora degli inganni”, “regina delle stelle”"),
            // N
            new ("Nay", "No"),
            // O
            new ("Orme Falmalion", "Furia delle onde. Tridente di Earlann", Q),
            // P
            // Q
            // R
            // S
            new ("Suldanas", "“Padre degli dei”, “dio dello spirito animale, della furia della foresta e delle virtù della natura”, “dio della vendetta”, “dio cacciatore”"),
            // T
            // U
            // V
            new ("Vàla", "Dio"),
            new ("Vàlar" , "Dei"),
            new ("Valìe", "Dea"),
            new ("Valìer" , "Dee"),
            // W
            // X
            // Y
            // Z
        };
    }
}
