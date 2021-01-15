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
            new ("Algul", "Magia proibita", S),
            new ("Amanie Earenya", "Ministro. Titolo di Rotiniel"),
            new ("Amil en Morrigan", "Matriarca/Patriarca di Morrigan"),
            new ("Annon lle", "Prego", Q),
            new ("Aran", "Re (singolare)", Q),
            new ("Aran Tumno", "Re del profondo. Earlann in forma di balena"),
            new ("Arani", "Re (plurale)", Q),
            new ("Arwe Earenya", "Custode delle riserve. Titolo di Rotiniel"),
            new ("Atan", "Umano", Q),
            new ("Atani", "Umani", Q),
            new ("Atar", "Padre. Suldanas, per estensione, in quando padre degli dei"),
            new ("Athar Earenya", "Gran cerimoniere. Titolo di Rotiniel"),
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
            new ("Calaquende", "Elfo della luce. Quenya"),
            new ("Calaquendi", "Elfi della luce. Quenya"),
            new ("Calen", "Verde. Tiond"),
            new ("Caran-Carch", "Zanna-Rossa. Suldanas in forma di lupo"),
            new ("Curu", "Arte arcana"),
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
            new ("Edhil Mhithrin", "Elfi grigi. Sindar", S),
            new ("Elda", "Elfo", Q),
            new ("Eldar", "Elfi", Q),
            new ("Elen", "Stella"),
            new ("Eleni", "Stelle"),
            new ("Elentari", "Regina delle stelle. Morrigan"),
            new ("Eruanna", "Dono di Morrigan. Magia"),
            // F
            new ("Fara Aer", "Caccia sacra"),
            // G
            new ("Galedhel", "Elfo della luce. Quenya", S),
            new ("Galedhil", "Elfi della luce. Quenya", S),
            new ("Gondolin", "Pietre cantanti. Ondolinde", S),
            new ("Gul", "Magia", S),
            new ("Gwador", " Fratello (solo tra sindar o elfi a cui si sentono particolarmente vicini)", S),
            new ("Gwathel", "Sorella (solo tra sindar o elfi a cui si sentono particolarmente vicini)", S),
            new ("Gwedeir", "Fratelli (solo tra sindar o elfi a cui si sentono particolarmente vicini)", S),
            new ("Gwethil", "Sorelle (solo tra sindar o elfi a cui si sentono particolarmente vicini)", S),
            // H
            new ("Haran", "Re (singolare)", S),
            new ("Haryon hosseo", "Ammiraglio della flotta. Titolo di Rotiniel"),
            new ("Hera hosseo", "Capitano della flotta. Titolo di Rotiniel"),
            new ("Herain", "Re (plurale)", S),
            new ("Heru ciryan", "Quartiermastro. Titolo di Rotiniel"),
            new ("Hildoriath", "Terra degli elfi. Doriath", S),
            new ("Hirao", "Iniziato. Titolo di Rotiniel"),
            new ("Hosse", "Flotta", Q),
            // I
            new ("Ingol", "Magia", Q),
            new ("Ista Hosseo", "Veterano della flotta. Titolo di Rotiniel"),
            new ("Istar", "Mago"),
            new ("Istari", "Maghi"),
            // J
            // K
            new ("Kelthra", "“Regina dei ragni”, “la figlia di Luugh”, “regina di veleno e malattie”"),
            new ("Khalna", "Maestro (di magia)"),
            new ("Kuru Raen", "Sapiente della luna. Titolo di Valinor"),
            // L
            new ("Langol", "Magia proibita", Q),
            new ("Lass Galen", "Foglia verde. Regina", S),
            new ("Lasse Calen", "Foglia Verde. Regina (arcaico)", S),
            new ("Leylar Earenya", "Mercante errante. Titolo di Rotiniel"),
            new ("Lestanore", "Terra degli elfi. Doriath", Q),
            new ("Linna Earenya", "Incaricato di lega. Titolo di Rotiniel"),
            new ("Lle creoso", "Prego", S),
            new ("Linda", "Cantore"),
            new ("Lindar", "Cantori. Teleri"),
            new ("Luinfear", "Anima/spirito azzurro"),
            new ("Luinfari", "Anime/spiriti azzurri"),
            new ("Luinquendi", "Elfi azzurri. Unendosi con i quenya diedero vita ai teleri"),
            new ("Luugh", "“Dio dell’odio e della sofferenza”, “signore del dolore”, “l’invidioso”, “il perfetto”, “l’unico”"),
            // M
            new ("Mae govannen", "Ben incontrato"),
            new ("Maethorim", "Flotta", Q),
            new ("Maer andune", "Buon pomeriggio", S),
            new ("Maer dome", "Buon pomeriggio", S),
            new ("Maer du", "Buona sera", S),
            new ("Maer fara", "Buona caccia", S),
            new ("Maer kaima", "Buon riposo", S),
            new ("Maer re", "Buon giorno", S),
            new ("Mandear", "Guardiamarina. Titolo di Rotiniel"),
            new ("Marilla", "Perla. Rotiniel"),
            new ("Mire Earenya", "Tesoriere"),
            new ("Mor'Quessir", "Drow (plurale)"),
            new ("Morgul", "Magia nera", S),
            new ("Moringul", "Magia nera", Q),
            new ("Morrigan", "“Dea della magia e della dissimulazione”, “signora degli inganni”, “regina delle stelle”"),
            // N
            new ("Naàmarie", "saluto di congedo"),
            new ("Nauco", "Nano"),
            new ("Naucor", "Nano"),
            new ("Nay", "No"),
            new ("Nelya", "Terzo"),
            new ("Nelyar", "Terzi. Teleri"),
            new ("Nimphel", "Perla. Rotiniel", S),
            new ("Noltar hosseo", "Maestro d'arme della flotta. Titolo di Rotiniel"),
            // O
            new ("Ondolindelor", "Cittadini di Ondolinde"),
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
            new ("Quendilen", "???ribellione dei \"Quendilen\"???"),
            new ("Quistaher ", "Giudice. Titolo di Rotiniel"),
            // R
            new ("Roquen Earion", "Cavaliere dei mari. Titolo di Rotiniel"),
            new ("Rotinrim", "Cittadini di rotiniel"),
            new ("Rotto nelyar", "Grotta dei terzi. Luogo sacro ai teleri"),
            // S
            new ("Samnar", "Cardine. Titolo di Rotiniel"),
            new ("Sèler", "Sorella (solo tra elfi)"),
            new ("Sèlerin", "Sorelle (solo tra elfi)"),
            new ("Silala", "Splendente. Ondolinde"),
            new ("Suldanas", "“Padre degli dei”, “dio dello spirito animale, della furia della foresta e delle virtù della natura”, “dio della vendetta”, “dio cacciatore”"),
            // T
            new ("Tari", "Regina", Q),
            new ("Tarir", "Regine", Q),
            new ("Tanwe Earenya", "Mastro artigiano. Titolo di Rotiniel"),
            new ("Tawar", "Elfo silvano. Sindar", S),
            new ("Tawarwaith", "Elfi silvani. Sindar", S),
            new ("Tereldar", "Elfi alti. Quenya", Q),
            new ("Tindu", "Crepuscolo stellato (arcaico)", S),
            new ("Tirith Earenya", "Consigliere mercantile. Titolo di Rotiniel"),
            new ("Tòr", "Fratello (solo tra elfi)"),
            new ("Tòronin", "Fratelli (solo tra elfi)"),
            // U
            new ("Únótimë lar", "Innumerevoli riccheze. Tipico saluto tra mercanti", T),
            // V
            new ("Vàla", "Dio", Q),
            new ("Vàlar" , "Dei", Q),
            new ("Valìe", "Dea", Q),
            new ("Valìer" , "Dee", Q),
            new ("Valinrim", "Membri di Valinor"),
            new ("Veduì", "Saluto d'arrivo formale", Q),
            // W
            // X
            // Y
            new ("Yelven londeo", "Recluta portuale. Titolo di Rotiniel"),
            // Z
        };
    }
}
