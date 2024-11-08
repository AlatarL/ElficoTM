﻿using System.Collections.Generic;
using System.Data;

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
            new ("Alamandur", "Allevatore reale. Titolo di Rotiniel"),
            new ("Alda morn", "Albero nero. Tulip nero"),
            new ("Algul", "Magia proibita", S),
            new ("Aman Aire", "Sommo sole. Titolo di Valinor"),
            new ("Amanie earenya", "Ministro. Titolo di Rotiniel"),
            new ("Amanirme", "Sacerdote"),
            new ("Amart’hyanda", "La spada degli antichi"),
            new ("Amil en'Morrigan", "Matriarca di Morrigan. Titolo di Rotiniel", Q),
            new ("Amille valarion", "Madre degli dei. Beltaine"),
            new ("Amin", "Mio/a (caro/a)"),
            new ("Angul", "Magia proibita", S),
            new ("Anna feain", "Dono per le anime. Rito di Beltaine con Morrigan ed Earlann"),
            new ("Annon lle", "Prego", Q),
            new ("Aracano fanyaron", "Conduttrice dei cieli. Morrigan", T),
            new ("Aran", "Re (singolare)", Q),
            new ("Aran tumno", "Re del profondo. Earlann in forma di balena", T),
            new ("Aranel", "Principessa", Q),
            new ("Arani", "Re (plurale)", Q),
            new ("Araton en'Meletya", "Alfiere della forza", Q),
            new ("Argur", "Consigliere dorato. Titolo di Valinor", S),
            new ("Arianar", "Iniziato del sole. Titolo di Valinor"),
            new ("Arwe earenya", "Custode delle riserve. Titolo di Rotiniel"),
            new ("Asar annarion ar kemeno", "Festa dei doni della terra. Rito di Beltaine"),
            new ("Atan", "Umano", Q),
            new ("Atani", "Umani", Q),
            new ("Atar", "Padre. Suldanas, per estensione, in quando padre degli dei"),
            new ("Atar en'Morrigan", "Patriarca di Morrigan. Titolo di Rotiniel", Q),
            new ("Athar earenya", "Gran cerimoniere. Titolo di Rotiniel"),
            new ("Ay" , "Sì"),
            // B
            new ("Bala", "Dio", T),
            new ("Bala nenion ar i sanweo", "Dio delle acque e della meditazione. Earlann", T),
            new ("Balai", "Dei", T),
            new ("Belain", "Dei", S),
            new ("Balan", "Dio", S),
            new ("Beltaine", "“Dea della vita e delle foreste”, “regina della luce”, “la grande madre”"),
            new ("Bereth", "Regina", S),
            new ("Beriardir en’rim", "Generale dell'armata degli araldi. Titolo di Valinor"),
            new ("Berith", "Regine", S),
            // C
            new ("Cala amanirme", "Sommo sacerdote. Titolo di Rotiniel (in disuso)"),
            new ("Calaquende", "Elfo della luce. Quenya"),
            new ("Calaquendi", "Elfi della luce. Quenya"),
            new ("Calen", "Verde. Tiond"),
            new ("Caneldarion", "Comando degli elfi, imperialismo"),
            new ("Caran-carch", "Zanna-Rossa. Suldanas in forma di lupo"),
            new ("Ciria fairion", "Nave fantasma. Leggenda telera"),
            new ("Curu", "Arte arcana, conoscenza magica"),
            // D
            new ("Diolla lle", "Grazie"),
            new ("Doriath", "Terra inghirlandata dal mare. Continente elfico"),
            new ("Dul laman", "Pantera del crepuscolo. Titolo di Valinor"),
            // E
            new ("Earlann", "“Dio delle acque e della meditazione”, “signore dei mari”, “il sempre saggio”"),
            new ("Earost", "Fortezza del mare. Rotiniel", S),
            new ("Edain", "Umani", S),
            new ("Edhel", "Elfo", S),
            new ("Edhel mhithren", "Elfo grigio. Sindar", S),
            new ("Edhil", "Elfi", S),
            new ("Edhil mhithrin", "Elfi grigi. Sindar", S),
            new ("Elbereth", "Regina delle stelle. Morrigan", S),
            new ("Elda", "Elfo", Q),
            new ("Eldar", "Elfi", Q),
            new ("Eldar earen", "Elfi del mare. Teleri"),
            new ("Elen", "Stella"),
            new ("Elen síla lúmenn’ omentielvo", "Una stella brilla sull'ora del nostro incontro. Comune saluto", Q),
            new ("Elendil", "Amico delle stelle (e degli elfi)", Q),
            new ("Eleni", "Stelle"),
            new ("Elentari", "Regina delle stelle. Morrigan"),
            new ("Eruanna", "Dono di Morrigan. Magia"),
            new ("Estannen", "Chiamato (dai Valar). Recluta. Titolo di Valinor"),
            // F
            new ("Faer doron", "Spirito della quercia", S),
            new ("Faerin", "Spiriti", S),
            new ("Falma laurie", "Onda d'oro"),
            new ("Falmar laurie", "Onde d'oro. Massimo organismo del clero di Earlann"),
            new ("Fara aer", "Caccia sacra"),
            // G
            new ("Galedhel", "Elfo della luce. Quenya", S),
            new ("Galedhil", "Elfi della luce. Quenya", S),
            new ("Ghauna", "Imperfetti, reietti, elfi infelici"),
            new ("Gondolin", "Pietre cantanti. Ondolinde", S),
            new ("Gul", "Magia", S),
            new ("Gwador", " Fratello (solo tra sindar o elfi a cui si sentono particolarmente vicini)", S),
            new ("Gwathel", "Sorella (solo tra sindar o elfi a cui si sentono particolarmente vicini)", S),
            new ("Gwedeir", "Fratelli (solo tra sindar o elfi a cui si sentono particolarmente vicini)", S),
            new ("Gwethil", "Sorelle (solo tra sindar o elfi a cui si sentono particolarmente vicini)", S),
            // H
            new ("Halla roquen", "Stratega. Titolo di Rotiniel"),
            new ("Haran", "Re (singolare)", S),
            new ("Harfaron", "Cacciatore di tesori. Titolo di Rotiniel"),
            new ("Haryon hosseo", "Ammiraglio della flotta. Titolo di Rotiniel"),
            new ("Hera hosseo", "Capitano della flotta. Titolo di Rotiniel"),
            new ("Herain", "Re (plurale)", S),
            new ("Heri", "Signora", Q),
            new ("Heru", "Signore", Q),
            new ("Heru ciryan", "Quartiermastro. Titolo di Rotiniel"),
            new ("Hildoriath", "Terra degli elfi. Doriath", S),
            new ("Hirao", "Iniziato. Titolo di Rotiniel"),
            new ("Hosse", "Flotta", Q),
            // I
            new ("Ihilie", "Scudiero. Titolo di Rotinel"),
            new ("Ilkarin gobol", "Villaggio di Ilkorin"),
            new ("Illume saira", "Sempre saggio. Earlann", T),
            new ("Ingol", "Magia", Q),
            new ("Ista hosseo", "Veterano della flotta. Titolo di Rotiniel"),
            new ("Istar", "Mago, stegone"),
            new ("Istar en'alak", "Mago del vento. Titolo di Valinor"),
            new ("Istar en'mizde", "Mago della pioggia. Titolo di Valinor"),
            new ("Istar en'nar", "Mago della foglia. Titolo di Valinor"),
            new ("Istar en'ndor", "Mago della fiamma. Titolo di Valinor"),
            new ("Istari", "Maghi, stregoni"),
            new ("Istyar en'Nolwen", "Cercatore del sapere. Titolo di Rotiniel", Q),
            new ("Ithron", "Mago, stregone", S),
            new ("Ithryn", "Maghi, stregoni", S),
            // J
            // K
            new ("Karani", "Arma rossa, simbolo del generale di Valinor"),
            new ("Kelthra", "“Regina dei ragni”, “la figlia di Luugh”, “regina di veleno e malattie”"),
            new ("Khalna", "Maestro (di magia)"),
            new ("Kiirar en'aina", "Custode della fede. Titolo di Rotiniel", Q),
            new ("Kiirar en'Eruanna", "Custode del Dono. Titolo di Rotiniel", Q),
            new ("Kiirar en'losse", "Custode dei sussurri. Titolo di Rotiniel", Q),
            new ("Kiirar en'nolwen", "Custode del sapere. Titolo di Rotiniel", Q),
            new ("Kuru raen", "Sapiente della luna. Titolo di Valinor"),
            // L
            new ("Langol", "Magia proibita", Q),
            new ("Laman", "Pantera. Titolo di Valinor"),
            new ("Lantar", "Decadentisti"),
            new ("Lasse", "Novizio. Titolo di Valinor", S),
            new ("Lass galen", "Foglia verde. Regina", S),
            new ("Lasse calen", "Foglia Verde. Regina (arcaico)", S),
            new ("Leylar earenya", "Mercante errante. Titolo di Rotiniel"),
            new ("Lestanore", "Terra degli elfi. Doriath", Q),
            new ("Linde finirion", "Canto dei morti. Rituale di Beltaine"),
            new ("Linna earenya", "Incaricato di lega. Titolo di Rotiniel"),
            new ("Lle creoso", "Prego", S),
            new ("Liante", "Ragno"),
            new ("Lianter", "Ragni"),
            new ("Linda", "Cantore"),
            new ("Lindar", "Cantori. Teleri"),
            new ("Loti atalantar morricaneva", "Fiori cadenti di Morrigan. Leggenda telera"),
            new ("Luinfairi", "Spiriti azzurri. Leggenda telera"),
            new ("Luinfari", "Anime/spiriti azzurri"),
            new ("Luinquendi", "Elfi azzurri. Unendosi con i quenya diedero vita ai teleri"),
            new ("Luugh", "“Dio dell’odio e della sofferenza”, “signore del dolore”, “l’invidioso”, “il perfetto”, “l’unico”"),
            new ("Luughnasad","Grande città sotterranea dei Drow"),
            // M
            new ("Machtar yaren", "Guerrieri del sangue. Ex-gilda con sede a Nolwe"),
            new ("Mae govannen", "Ben incontrato"),
            new ("Maethorim", "Flotta", Q),
            new ("Maer calad", "Buon giorno", S),
            new ("Maer du", "Buona sera", S),
            new ("Maer fara", "Buona caccia", S),
            new ("Maer kaima", "Buon riposo", S),
            new ("Maer ré", "Buon giorno", S),
            new ("Maer tinnu", "Buona sera", S),
            new ("Mana", "Forza interiore che permette di gestire e manipolare l’energia magica"),
            new ("Manachtar", "Paladino. Titolo di Rotiniel"),
            new ("Mandear", "Guardiamarina. Titolo di Rotiniel"),
            new ("Marilla", "Perla. Rotiniel", Q),
            new ("Meina", "Accolito. Titolo di Valinor"),
            new ("Melamin", "Amore mio"),
            new ("Meldo", "Amico (degli elfi)", Q),
            new ("Meleth", "Amore", S),
            new ("Mellon", "Amico (degli elfi)", S),
            new ("Mellon en'valinor", "Amico di Valinor. Titolo di Valinor", S),
            new ("Men, piano della", "Luogo di provenienza del potere magico"),
            new ("Mique earo ar kemeno", "Bacio di mare e terra. Rito di Beltaine ed Earlann"),
            new ("Minya angwar", "Primo grifone. Titolo di Valinor"),
            new ("Minya draug", "Primo lupo. Titolo di Valinor"),
            new ("Minya elen", "Primo astro. Titolo di Rotiniel"),
            new ("Minya laman", "Prima pantera. Titolo di Valinor"),
            new ("Minya manachtar", "Primo paladino. Titolo di Rotiniel"),
            new ("Mire earenya", "Tesoriere. Titolo di Rotiniel"),
            new ("Mîthrim", "Elfi grigi. Sindar", S),
            new ("Mor'quessir", "Drow (plurale)"),
            new ("Morgul", "Magia nera", S),
            new ("Moriquendi", "Elfi oscuri. Drow"),
            new ("Moringul", "Magia nera", Q),
            new ("Morn draug", "Nero lupo. Titolo di Valinor"),
            new ("Morrigan", "“Dea della magia e della dissimulazione”, “signora degli inganni”, “regina delle stelle”"),
            // N
            new ("Naàmarie", "Saluto di congedo. Addio"),
            new ("Naerion", "Collettività"),
            new ("Nauco", "Tozzo. Nano", Q),
            new ("Naucor", "Tozzi. Nani", Q),
            new ("Naug", "Nano", S),
            new ("Naugrim", "Nani", S),
            new ("Navaer", "Saluto di congedo. Stammi bene", S),
            new ("Nay", "No"),
            new ("Nelya", "Terzo"),
            new ("Nelyar", "Terzi. Teleri"),
            new ("Neth angwar", "Giovane grifone. Titolo di Valinor"),
            new ("Neth draug", "Giovane lupo. Titolo di Valinor"),
            new ("Neth laman", "Giovane pantera. Titolo di Valinor"),
            new ("Nimphel", "Perla. Rotiniel", S),
            new ("Ninque alda", "Bianco albero. Tulip"),
            new ("Ninque sàila", "Bianco saggio. Titolo di Valinor", Q),
            new ("Noltar hosseo", "Maestro d'arme della flotta. Titolo di Rotiniel"),
            // O
            new ("Ondolindelore", "Cittadini di Ondolinde"),
            new ("Orme falmalion", "Furia delle onde. Nome del tridente di Earlann", Q),
            // P
            new ("Peredhel", "Mezzelfo", S),
            new ("Peredhil", "Mezzelfi", S),
            new ("Perelda", "Mezzelfo", Q),
            new ("Pereldar", "Mezzelfi", Q),
            new ("Phajanar en’valar", "Sacerdote. Titolo di Valinor"),
            // Q
            new ("Quel du", "Buona sera", Q),
            new ("Quel fara", "Buona caccia", Q),
            new ("Quel kaima", "Buon riposo", Q),
            new ("Quel kiruva", "Buona navigazione", Q),
            new ("Quel ré", "Buon giorno", Q),
            new ("Quendilen", "Amici degli elfi"),
            new ("Quistaher ", "Luogotenente. Titolo di Rotiniel"),
            // R
            new ("Roquen Earion", "Cavaliere dei mari. Titolo di Rotiniel"),
            new ("Rotinrim", "Cittadini di Rotiniel"),
            new ("Rotto nelyar", "Grotta dei terzi. Luogo sacro ai teleri"),
            // S
            new ("Sairo en'nolwen", "Discente del sapere. Titolo onorario di Rotiniel", Q),
            new ("Samna", "Cardine. Titolo di Rotiniel"),
            new ("Samnar", "Cardini. Titolo di Rotiniel"),
            new ("Saràt nomë", "Sigillo dell'esilio. Rituale magico"),
            new ("Sèler", "Sorella (solo tra elfi)"),
            new ("Sèlerin", "Sorelle (solo tra elfi)"),
            new ("Sercë ar sangwa", "Sangue e veleno. Motto dei Guerrieri del sangue"),
            new ("Sha’quessir", "Amico degli elfi", Q),
            new ("Silala", "Splendente. Ondolinde"),
            new ("Sìlima angwar", "Grifone d'argento. Titolo di Valinor"),
            new ("Silme", "Novizio. Titolo di Valinor", Q),
            new ("Suldanas", "“Padre degli dei”, “dio dello spirito animale, della furia della foresta e delle virtù della natura”, “dio della vendetta”, “dio cacciatore”"),
            // T
            new ("Talorn", "Radici. Leggi di Valinor"),
            new ("Tàri", "Regina", Q),
            new ("Tàri elenion", "Regina delle stelle. Morrigan", T),
            new ("Tàriel", "Terathen (singolare)"),
            new ("Tàrieli", "Terathen (plurale)"),
            new ("Tarir", "Regine", Q),
            new ("Tanwe cemendur", "Mastro agricoltore. Titolo di Rotiniel"),
            new ("Tanwe cemiar", "Mastro alchimista. Titolo di Rotiniel"),
            new ("Tanwe earenya", "Mastro artigiano. Titolo di Rotiniel"),
            new ("Tanwe laurar", "Mastro stagnino. Titolo di Rotiniel"),
            new ("Tanwe maxar", "Mastro cuoco. Titolo di Rotiniel"),
            new ("Tanwe quingar", "Mastro intagliatore. Titolo di Rotiniel"),
            new ("Tanwe samno", "Mastro carpentiere. Titolo di Rotiniel"),
            new ("Tanwe serar", "Mastro sarto. Titolo di Rotiniel"),
            new ("Tanwe sintamo", "Mastro fabbro. Titolo di Rotiniel"),
            new ("Tawar", "Elfo silvano. Sindar", S),
            new ("Tawarwaith", "Elfi silvani. Sindar", S),
            new ("Tercan en'estel", "Araldo della fede. Titolo onorario di Rotiniel", Q),
            new ("Telain", "Costruzioni sugli alberi tipiche dei sindar"),
            new ("Tereldar", "Elfi alti. Quenya", Q),
            new ("Thara", "Alto sacerdote. Titolo di Valinor"),
            new ("Tindu", "Crepuscolo stellato (arcaico)", S),
            new ("Tindunan", "Bosco antico del cigno. Villaggio sindar dentro la valle di Ondolinde"),
            new ("Tirith earenya", "Consigliere mercantile. Titolo di Rotiniel"),
            new ("Tòr", "Fratello (solo tra elfi)"),
            new ("Toronin", "Fratelli (solo tra elfi)"),
            new ("Tuima", "Gemma, germoglio. Abitante di Valinor. Titolo di Valinor"),
            new ("Tura en'Eruanna", "Maestro del Dono. Titolo di Rotiniel"),
            new ("Turco hostar", "Capo raccoglitore. Titolo di Rotiniel"),
            // U
            new ("Únótimë lar", "Innumerevoli riccheze. Tipico saluto tra mercanti", T),
            // V
            new ("Val'istar", "Grande stregone. Titolo di Valinor"),
            new ("Vàla", "Dio", Q),
            new ("Vàlar" , "Dei", Q),
            new ("Valar valuvàr", "Sia fatto il volere dei valar", Q),
            new ("Valìe", "Dea", Q),
            new ("Valìer" , "Dee", Q),
            new ("Valim", "Chiaromanto. Simbolo di Valinor, due alberi abbracciati"),
            new ("Valinrim", "Membri di Valinor"),
            new ("Valinor", "Regno imperituro. Reame/gilda di quenya e sindar con sede ad Ondolinde"),
            new ("Valinor valuvàr", "Sia fatto il volere di Valinor", Q),
            new ("Veduì", "Saluto d'arrivo formale", Q),
            // W
            // X
            // Y
            new ("Ya-Tuima", "Cittadino anziano. Titolo di Valinor"),
            new ("Yasse", "Anziano. Titolo di Valinor"),
            new ("Yatuima", "Cittadino anziano. Titolo di Valinor"),
            new ("Yelven londeo", "Recluta portuale. Titolo di Rotiniel"),
            // Z
        };
    }
}
