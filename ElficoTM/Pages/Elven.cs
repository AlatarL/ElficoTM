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
            new ("Aàye", "Saluto d'arrivo. Salve"),
            new ("Acharn", "Vendetta. Nome dell'arco di Suldanas", S),
            new ("Adan", "Umano", S),
            new ("Aearedhel", "Elfo marino. Teler", S),
            new ("Aearedhil", "Elfi marini. Teleri", S),
            new ("Aiya", "Saluto d'arrivo. Salve", Q),
            new ("Annon lle", "Prego", Q),
            new ("Aran", "Re (singolare)", Q),
            new ("Aran Tumno", "Re del profondo. Earlann in forma di balena"),
            new ("Arani", "Re (plurale)", Q),
            new ("Atan", "Umano", Q),
            new ("Atani", "Umani", Q),
            new ("Atar", "Padre. Suldanas, per estensione, in quando padre degli dei"),
            new ("Ay" , "Sì"),
            // B
            new ("Bala", "Dio", T),
            new ("Balai", "Dei", T),
            new ("Balain", "Dei", S),
            new ("Balan", "Dio", S),
            new ("Beltaine", "“Dea della vita e delle foreste”, “regina della luce”, “la grande madre”"),
            new ("Bereth", "Regina", S),
            new ("Berith", "Regine", S),
            // C
            new ("Calaquendi", "Elfi della luce. Quenya"),
            new ("Calen", "Verde. Tiond"),
            new ("Caran-Carch", "Zanna-Rossa. Suldanas in forma di lupo"),
            // D
            new ("Diolla lle", "Grazie"),
            new ("Doriath", "Terra inghirlandata dal mare. Terra degli elfi"),
            // E
            new ("Earlann", "“Dio delle acque e della meditazione”, “signore dei mari”, “il sempre saggio”"),
            new ("Earost", "Fortezza del mare. Rotiniel", S),
            new ("Edain", "Umani", S),
            new ("Edhel", "Elfo", S),
            new ("Edhel Mhithren", "Elfo grigio. Sindar", S),
            new ("Edhil", "Elfi", S),
            new ("Edhil Mhithrin", "Elfi grigi. Sindarin", S),
            new ("Elda", "Elfo", Q),
            new ("Eldar", "Elfi", Q),
            // F
            new ("Fara Aer", "Caccia sacra"),
            // G
            new ("Galedhel", "Elfo della luce. Quenya", S),
            new ("Galedhil", "Elfi della luce. Quenya", S),
            new ("Gondolin", "Pietre cantanti. Ondolinde", S),
            new ("Gwador", " Fratello (solo tra sindarin o elfi a cui si sentono particolarmente vicini)", S),
            new ("Gwathel", "Sorella (solo tra sindarin o elfi a cui si sentono particolarmente vicini)", S),
            new ("Gwedeir", "Fratelli (solo tra sindarin o elfi a cui si sentono particolarmente vicini)", S),
            new ("Gwethil", "Sorelle (solo tra sindarin o elfi a cui si sentono particolarmente vicini)", S),
            // H
            new ("Haran", "Re (singolare)", S),
            new ("Herain", "Re (plurale)", S),
            new ("Hildoriath", "Terra degli elfi. Doriath", S),
            // I
            // J
            // K
            new ("Kelthra", "“Regina dei ragni”, “la figlia di Luugh”, “regina di veleno e malattie”"),
            // L
            new ("Lass Galen", "Foglia verde. Regina", S),
            new ("Lasse Calen", "Foglia Verde. Regina (arcaico)", S),
            new ("Lestanore", "Terra degli elfi. Doriath", Q),
            new ("Lle creoso", "Prego", S),
            new ("Linda", "Cantore"),
            new ("Lindar", "Cantori. Teleri"),
            new ("Luugh", "“Dio dell’odio e della sofferenza”, “signore del dolore”, “l’invidioso”, “il perfetto”, “l’unico”"),
            // M
            new ("Mae govannen", "Ben incontrato"),
            new ("Maer andune", "Buon pomeriggio", S),
            new ("Maer dome", "Buon pomeriggio", S),
            new ("Maer du", "Buona sera", S),
            new ("Maer fara", "Buona caccia", S),
            new ("Maer kaima", "Buon riposo", S),
            new ("Maer re", "Buon giorno", S),
            new ("Marilla", "Perla. Rotiniel"),
            new ("Mor'Quessir", "Drow (plurale)"),
            new ("Morrigan", "“Dea della magia e della dissimulazione”, “signora degli inganni”, “regina delle stelle”"),
            // N
            new ("Naàmarie", "saluto di congedo"),
            new ("Nay", "No"),
            new ("Nelya", "Terzo"),
            new ("Nelyar", "Terzi. Teleri"),
            new ("Nimphel", "Perla. Rotiniel", S),
            // O
            new ("Orme Falmalion", "Furia delle onde. Nome del tridente di Earlann", Q),
            // P
            new ("Peredhel", "Mezz'elfo", S),
            new ("Peredhil", "Mezz'elfi", S),
            new ("Perelda", "Mezz'elfo", Q),
            new ("Pereldar", "Mezz'elfi", Q),
            // Q
            new ("Quel andune", "Buon pomeriggio", Q),
            new ("Quel dome", "Buon pomeriggio", Q),
            new ("Quel du", "Buona sera", Q),
            new ("Quel fara", "Buona caccia", Q),
            new ("Quel kaima", "Buon riposo", Q),
            new ("Quel kiruva", "Buona navigazione", Q),
            new ("Quel re", "Buon giorno", Q),
            // R
            new ("Rotinrim", "Cittadini di rotiniel"),
            // S
            new ("Sèler", "Sorella (solo tra elfi)"),
            new ("Sèlerin", "Sorelle (solo tra elfi)"),
            new ("Silala", "Splendente. Ondolinde"),
            new ("Suldanas", "“Padre degli dei”, “dio dello spirito animale, della furia della foresta e delle virtù della natura”, “dio della vendetta”, “dio cacciatore”"),
            // T
            new ("Tari", "Regina", Q),
            new ("Tarir", "Regine", Q),
            new ("Tawar", "Elfo silvano. Sindar", S),
            new ("Tawarwaith", "Elfi silvani. Sindarin", S),
            new ("Tereldar", "Elfi alti. Quenya", Q),
            new ("Tindu", "Crepuscolo stellato (arcaico)", S),
            new ("Tòr", "Fratello (solo tra elfi)"),
            new ("Tòronin", "Fratelli (solo tra elfi)"),
            // U
            new ("Únótimë lar", "Innumerevoli riccheze. Tipico saluto tra mercanti", T),
            // V
            new ("Vàla", "Dio", Q),
            new ("Vàlar" , "Dei", Q),
            new ("Valìe", "Dea", Q),
            new ("Valìer" , "Dee", Q),
            new ("Veduì", "Saluto d'arrivo formale", Q),
            // W
            // X
            // Y
            // Z
        };
    }
}
