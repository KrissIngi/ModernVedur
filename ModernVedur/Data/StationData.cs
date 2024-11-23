﻿// Data for the stations available from https://www.vedur.is/vedur/stodvar?t=3
// GPT was used to extract the values - to skip making a scraper I used GPT.
using ModernVedur.Models;

namespace ModernVedur.Data
{
    public class StationData
    {
        public static List<StationInfo> Stations = new List<StationInfo>
        {
            new StationInfo { Id = 1, Name = "Reykjavík" },
            new StationInfo { Id = 990, Name = "Keflavíkurflugvöllur" },
            new StationInfo { Id = 31572, Name = "Akrafjall" },
            new StationInfo { Id = 3471, Name = "Akureyri - Krossanesbraut" },
            new StationInfo { Id = 31109, Name = "Arnarnesvegur" },
            new StationInfo { Id = 3007, Name = "Austurárdalsháls" },
            new StationInfo { Id = 6420, Name = "Árnes" },
            new StationInfo { Id = 4614, Name = "Ásbyrgi" },
            new StationInfo { Id = 2175, Name = "Ásgarður" },
            new StationInfo { Id = 4380, Name = "Bakkagerði" },
            new StationInfo { Id = 6237, Name = "Básar á Goðalandi" },
            new StationInfo { Id = 34326, Name = "Biskupsháls" },
            new StationInfo { Id = 2428, Name = "Bíldudalur" },
            new StationInfo { Id = 2304, Name = "Bjargtangar" },
            new StationInfo { Id = 4472, Name = "Bjarnarey" },
            new StationInfo { Id = 3585, Name = "Björg í Kinn" },
            new StationInfo { Id = 1936, Name = "Bláfeldur" },
            new StationInfo { Id = 1487, Name = "Bláfjallaskáli" },
            new StationInfo { Id = 1486, Name = "Bláfjöll" },
            new StationInfo { Id = 31577, Name = "Blikdalsá" },
            new StationInfo { Id = 3317, Name = "Blönduós" },
            new StationInfo { Id = 33419, Name = "Blönduós Vegagerðarstöð" },
            new StationInfo { Id = 3229, Name = "Blönduvirkjun" },
            new StationInfo { Id = 2738, Name = "Bolungarvík" },
            new StationInfo { Id = 7736, Name = "Bolungarvík - Traðargil" },
            new StationInfo { Id = 35116, Name = "Borgarhöfn" },
            new StationInfo { Id = 32635, Name = "Botn í Súgandafirði" },
            new StationInfo { Id = 1689, Name = "Botnsheiði" },
            new StationInfo { Id = 31985, Name = "Brattabrekka" },
            new StationInfo { Id = 35965, Name = "Breiðdalsheiði" },
            new StationInfo { Id = 5940, Name = "Brú á Jökuldal" },
            new StationInfo { Id = 5932, Name = "Brúarjökull B10" },
            new StationInfo { Id = 5825, Name = "Brúaröræfi" },
            new StationInfo { Id = 3223, Name = "Brúsastaðir" },
            new StationInfo { Id = 36415, Name = "Bræðratunguvegur" },
            new StationInfo { Id = 31932, Name = "Búlandshöfði" },
            new StationInfo { Id = 6430, Name = "Búrfell" },
            new StationInfo { Id = 620, Name = "Dalatangi" },
            new StationInfo { Id = 34415, Name = "Dettifoss" },
            new StationInfo { Id = 7790, Name = "Dyngjujökull" },
            new StationInfo { Id = 571, Name = "Egilsstaðaflugvöllur" },
            new StationInfo { Id = 36270, Name = "Eldhraun" },
            new StationInfo { Id = 32390, Name = "Ennisháls" },
            new StationInfo { Id = 5981, Name = "Eskifjörður" },
            new StationInfo { Id = 5943, Name = "Eyjabakkar" },
            new StationInfo { Id = 1395, Name = "Eyrarbakki" },
            new StationInfo { Id = 7001, Name = "Fagradals-Hagafell" },
            new StationInfo { Id = 34073, Name = "Fagridalur" },
            new StationInfo { Id = 5309, Name = "Fagurhólsmýri" },
            new StationInfo { Id = 5982, Name = "Fáskrúðsfjörður Ljósaland" },
            new StationInfo { Id = 31365, Name = "Festarfjall" },
            new StationInfo { Id = 1868, Name = "Fíflholt á Mýrum" },
            new StationInfo { Id = 34175, Name = "Fjarðarheiði" },
            new StationInfo { Id = 32250, Name = "Flatey á Breiðafirði" },
            new StationInfo { Id = 3779, Name = "Flatey á Skjálfanda" },
            new StationInfo { Id = 2631, Name = "Flateyri" },
            new StationInfo { Id = 33487, Name = "Fljótsheiði" },
            new StationInfo { Id = 4867, Name = "Fontur" },
            new StationInfo { Id = 31931, Name = "Fróðárheiði" },
            new StationInfo { Id = 4275, Name = "Gagnheiði" },
            new StationInfo { Id = 4276, Name = "Gagnheiði II" },
            new StationInfo { Id = 31475, Name = "Garðabær - Kauptún" },
            new StationInfo { Id = 1474, Name = "Garðabær - Urriðaholt" },
            new StationInfo { Id = 1453, Name = "Garðskagaviti" },
            new StationInfo { Id = 33204, Name = "Gauksmýri" },
            new StationInfo { Id = 1480, Name = "Geldinganes" },
            new StationInfo { Id = 32533, Name = "Gemlufallsheiði" },
            new StationInfo { Id = 32372, Name = "Gillastaðamelar" },
            new StationInfo { Id = 31361, Name = "Gíghæð" },
            new StationInfo { Id = 36391, Name = "Gígjukvísl" },
            new StationInfo { Id = 31599, Name = "Gjábakki" },
            new StationInfo { Id = 2693, Name = "Gjögur" },
            new StationInfo { Id = 2692, Name = "Gjögurflugvöllur" },
            new StationInfo { Id = 1361, Name = "Grindavík" },
            new StationInfo { Id = 3976, Name = "Grímsey" },
            new StationInfo { Id = 495, Name = "Grímsstaðir" },
            new StationInfo { Id = 4323, Name = "Grímsstaðir á Fjöllum" },
            new StationInfo { Id = 1938, Name = "Grundarfjörður" },
            new StationInfo { Id = 34081, Name = "Græfur í Fagradal" },
            new StationInfo { Id = 1919, Name = "Gufuskálar" },
            new StationInfo { Id = 36519, Name = "Gullfoss" },
            new StationInfo { Id = 31674, Name = "Hafnarfjall" },
            new StationInfo { Id = 31958, Name = "Hafursfell" },
            new StationInfo { Id = 5960, Name = "Hallormsstaðaháls" },
            new StationInfo { Id = 4060, Name = "Hallormsstaður" },
            new StationInfo { Id = 5970, Name = "Hallsteinsdalsvarp" },
            new StationInfo { Id = 35769, Name = "Hamarsfjörður" },
            new StationInfo { Id = 3103, Name = "Haugur" },
            new StationInfo { Id = 34450, Name = "Hauksstaðir" },
            new StationInfo { Id = 32322, Name = "Hálfdán" },
            new StationInfo { Id = 34733, Name = "Hálsar" },
            new StationInfo { Id = 33563, Name = "Hámundarstaðaháls" },
            new StationInfo { Id = 6315, Name = "Hella" },
            new StationInfo { Id = 31392, Name = "Hellisheiði" },
            new StationInfo { Id = 1490, Name = "Hellisskarð" },
            new StationInfo { Id = 33654, Name = "Héðinsfjörður" },
            new StationInfo { Id = 32365, Name = "Hjallaháls" },
            new StationInfo { Id = 6515, Name = "Hjarðarland" },
            new StationInfo { Id = 32097, Name = "Holtavörðuheiði" },
            new StationInfo { Id = 2862, Name = "Hornbjargsviti" },
            new StationInfo { Id = 34732, Name = "Hófaskarð" },
            new StationInfo { Id = 2530, Name = "Hólar í Dýrafirði" },
            new StationInfo { Id = 33495, Name = "Hólasandur" },
            new StationInfo { Id = 2481, Name = "Hólmavík" },
            new StationInfo { Id = 1481, Name = "Hólmsheiði" },
            new StationInfo { Id = 33652, Name = "Hólshyrna" },
            new StationInfo { Id = 31840, Name = "Hraunsmúli" },
            new StationInfo { Id = 6802, Name = "Húsafell" },
            new StationInfo { Id = 3696, Name = "Húsavík" },
            new StationInfo { Id = 35666, Name = "Hvalnes" },
            new StationInfo { Id = 36127, Name = "Hvammur" },
            new StationInfo { Id = 1777, Name = "Hvanneyri búveðurstöð" },
            new StationInfo { Id = 6935, Name = "Hveravellir" },
            new StationInfo { Id = 5544, Name = "Höfn í Hornafirði" },
            new StationInfo { Id = 31399, Name = "Ingólfsfjall" },
            new StationInfo { Id = 5210, Name = "Ingólfshöfði" },
            new StationInfo { Id = 5847, Name = "Innri Sauðá" },
            new StationInfo { Id = 2642, Name = "Ísafjörður" },
            new StationInfo { Id = 2644, Name = "Ísafjörður - Tungudalur" },
            new StationInfo { Id = 34148, Name = "Jökuldalur" },
            new StationInfo { Id = 6670, Name = "Jökulheimar" },
            new StationInfo { Id = 33480, Name = "Kaldakinn" },
            new StationInfo { Id = 5885, Name = "Kambanes" },
            new StationInfo { Id = 35884, Name = "Kambaskriður" },
            new StationInfo { Id = 6310, Name = "Kálfhóll" },
            new StationInfo { Id = 5933, Name = "Kárahnjúkar" },
            new StationInfo { Id = 990, Name = "Keflavíkurflugvöllur" },
            new StationInfo { Id = 6745, Name = "Kerlingarfjöll - Ásgarðsfjall" },
            new StationInfo { Id = 6272, Name = "Kirkjubæjarklaustur - Stjórnarsandur" },
            new StationInfo { Id = 31579, Name = "Kjalarnes" },
            new StationInfo { Id = 32224, Name = "Kleifaheiði" },
            new StationInfo { Id = 32355, Name = "Klettsháls" },
            new StationInfo { Id = 31882, Name = "Kolás" },
            new StationInfo { Id = 31942, Name = "Kolgrafafjarðarbrú" },
            new StationInfo { Id = 3225, Name = "Kolka" },
            new StationInfo { Id = 5975, Name = "Kollaleira í Reyðarfirði" },
            new StationInfo { Id = 1479, Name = "Korpa" },
            new StationInfo { Id = 1472, Name = "Kópavogur - Fossvogsdalur" },
            new StationInfo { Id = 4406, Name = "Krafla" },
            new StationInfo { Id = 5316, Name = "Kvísker" },
            new StationInfo { Id = 35315, Name = "Kvísker Vegagerðarstöð" },
            new StationInfo { Id = 2315, Name = "Lambavatn" },
            new StationInfo { Id = 6472, Name = "Laufbali" },
            new StationInfo { Id = 32190, Name = "Laxárdalsheiði" },
            new StationInfo { Id = 293, Name = "Litla-Ávík" },
            new StationInfo { Id = 36386, Name = "Lómagnúpur" },
            new StationInfo { Id = 6459, Name = "Lónakvísl" },
            new StationInfo { Id = 36504, Name = "Lyngdalsheiði" },
            new StationInfo { Id = 36122, Name = "Markarfljót" },
            new StationInfo { Id = 3797, Name = "Mánárbakki" },
            new StationInfo { Id = 4652, Name = "Miðfjarðarnes" },
            new StationInfo { Id = 31122, Name = "Miklidalur" },
            new StationInfo { Id = 31591, Name = "Mosfellsheiði" },
            new StationInfo { Id = 36156, Name = "Mýrdalssandur" },
            new StationInfo { Id = 4300, Name = "Mývatn" },
            new StationInfo { Id = 33394, Name = "Mývatnsheiði" },
            new StationInfo { Id = 34413, Name = "Mývatnsöræfi" },
            new StationInfo { Id = 34238, Name = "Möðrudalsöræfi II" },
            new StationInfo { Id = 4830, Name = "Möðrudalur" },
            new StationInfo { Id = 3463, Name = "Möðruvellir" },
            new StationInfo { Id = 6424, Name = "Mörk á Landi" },
            new StationInfo { Id = 3242, Name = "Nautabú" },
            new StationInfo { Id = 5990, Name = "Neskaupstaður" },
            new StationInfo { Id = 5992, Name = "Neskaupstaður - Drangagil" },
            new StationInfo { Id = 36382, Name = "Núpahraun" },
            new StationInfo { Id = 34087, Name = "Oddsskarð" },
            new StationInfo { Id = 33661, Name = "Ólafsfjarðarvegur við Sauðanes" },
            new StationInfo { Id = 3658, Name = "Ólafsfjörður" },
            new StationInfo { Id = 7659, Name = "Ólafsfjörður - Tindaöxl" },
            new StationInfo { Id = 1924, Name = "Ólafsvík" },
            new StationInfo { Id = 5777, Name = "Papey" },
            new StationInfo { Id = 2319, Name = "Patreksfjörður" },
            new StationInfo { Id = 4912, Name = "Rauðinúpur" },
            new StationInfo { Id = 4828, Name = "Raufarhöfn" },
            new StationInfo { Id = 33420, Name = "Refasveit" },
            new StationInfo { Id = 2266, Name = "Reykhólar" },
            new StationInfo { Id = 3380, Name = "Reykir í Fnjóskadal" },
            new StationInfo { Id = 2197, Name = "Reykir í Hrútafirði" },
            new StationInfo { Id = 31363, Name = "Reykjanesbraut" },
            new StationInfo { Id = 31640, Name = "Reykjanesviti" },
            new StationInfo { Id = 1478, Name = "Reykjavík Geirsnef" },
            new StationInfo { Id = 1470, Name = "Reykjavík Háahlíð" },
            new StationInfo { Id = 1469, Name = "Reykjavík Hljómskálagarður" },
            new StationInfo { Id = 1482, Name = "Reykjavík Víðidalur" },
            new StationInfo { Id = 1477, Name = "Reykjavíkurflugvöllur" },
            new StationInfo { Id = 36049, Name = "Reynisfjall" },
            new StationInfo { Id = 4921, Name = "Rif á Melrakkasléttu" },
            new StationInfo { Id = 6975, Name = "Sandbúðir" },
            new StationInfo { Id = 31488, Name = "Sandskeið" },
            new StationInfo { Id = 34559, Name = "Sandvíkurheiði" },
            new StationInfo { Id = 400, Name = "Sauðanesviti" },
            new StationInfo { Id = 3433, Name = "Sauðárkrókur flugvöllur" },
            new StationInfo { Id = 6222, Name = "Sámsstaðir" },
            new StationInfo { Id = 3054, Name = "Sáta" },
            new StationInfo { Id = 5993, Name = "Seley" },
            new StationInfo { Id = 6300, Name = "Selfoss" },
            new StationInfo { Id = 2640, Name = "Seljalandsdalur" },
            new StationInfo { Id = 2641, Name = "Seljalandsdalur - skíðaskáli" },
            new StationInfo { Id = 1471, Name = "Seltjarnarnes - Suðurnes" },
            new StationInfo { Id = 31380, Name = "Selvogur" },
            new StationInfo { Id = 6748, Name = "Setur" },
            new StationInfo { Id = 4182, Name = "Seyðisfjörður" },
            new StationInfo { Id = 33750, Name = "Siglufjarðarvegur" },
            new StationInfo { Id = 33751, Name = "Siglufjarðarvegur Herkonugil" },
            new StationInfo { Id = 3752, Name = "Siglufjörður" },
            new StationInfo { Id = 7753, Name = "Siglufjörður - Hafnarfjall" },
            new StationInfo { Id = 6499, Name = "Skaftafell" },
            new StationInfo { Id = 3720, Name = "Skagatá" },
            new StationInfo { Id = 6176, Name = "Skarðsfjöruviti" },
            new StationInfo { Id = 1679, Name = "Skarðsheiði Miðfitjahóll" },
            new StationInfo { Id = 1496, Name = "Skarðsmýrarfjall" },
            new StationInfo { Id = 1590, Name = "Skálafell" },
            new StationInfo { Id = 36411, Name = "Skálholt" },
            new StationInfo { Id = 4455, Name = "Skjaldþingsstaðir" },
            new StationInfo { Id = 1578, Name = "Skrauthólar" },
            new StationInfo { Id = 3591, Name = "Staðarhóll" },
            new StationInfo { Id = 33643, Name = "Stafá" },
            new StationInfo { Id = 1781, Name = "Stafholtsey" },
            new StationInfo { Id = 36132, Name = "Steinar" },
            new StationInfo { Id = 32474, Name = "Steingrímsfjarðarheiði" },
            new StationInfo { Id = 31950, Name = "Stórholt" },
            new StationInfo { Id = 6017, Name = "Stórhöfði" },
            new StationInfo { Id = 2941, Name = "Straumnesviti" },
            new StationInfo { Id = 1473, Name = "Straumsvík" },
            new StationInfo { Id = 35880, Name = "Streiti" },
            new StationInfo { Id = 178, Name = "Stykkishólmur" },
            new StationInfo { Id = 2630, Name = "Suðureyri" },
            new StationInfo { Id = 6012, Name = "Surtsey" },
            new StationInfo { Id = 2646, Name = "Súðavík" },
            new StationInfo { Id = 3292, Name = "Svartárkot" },
            new StationInfo { Id = 32179, Name = "Svínadalur í Dölum" },
            new StationInfo { Id = 2323, Name = "Tálknafjörður" },
            new StationInfo { Id = 5872, Name = "Teigarhorn" },
            new StationInfo { Id = 6235, Name = "Tindfjöll" },
            new StationInfo { Id = 31578, Name = "Tíðaskarð" },
            new StationInfo { Id = 34700, Name = "Tjörnes - Gerðibrekka" },
            new StationInfo { Id = 3371, Name = "Torfur" },
            new StationInfo { Id = 4019, Name = "Upptyppingar" },
            new StationInfo { Id = 3474, Name = "Vaðlaheiði" },
            new StationInfo { Id = 7472, Name = "Vaðlaheiði II" },
            new StationInfo { Id = 31948, Name = "Vatnaleið" },
            new StationInfo { Id = 6546, Name = "Vatnsfell" },
            new StationInfo { Id = 33431, Name = "Vatnsskarð" },
            new StationInfo { Id = 34382, Name = "Vatnsskarð eystra" },
            new StationInfo { Id = 802, Name = "Vatnsskarðshólar" },

            new StationInfo { Id = 5988, Name = "Vattarnes" },
            new StationInfo { Id = 6657, Name = "Veiðivatnahraun" },
            new StationInfo { Id = 6015, Name = "Vestmannaeyjabær" },
            new StationInfo { Id = 3477, Name = "Végeirsstaðir í Fnjóskadal" },
            new StationInfo { Id = 35985, Name = "Víkurgerði" },
            new StationInfo { Id = 33576, Name = "Víkurskarð" },
            new StationInfo { Id = 34348, Name = "Vopnafjarðarheiði" },
            new StationInfo { Id = 4500, Name = "Þeistareykir" },
            new StationInfo { Id = 1596, Name = "Þingvellir" },
            new StationInfo { Id = 36308, Name = "Þjórsárbrú" },
            new StationInfo { Id = 5965, Name = "Þórudalur" },
            new StationInfo { Id = 31387, Name = "Þrengsli" },
            new StationInfo { Id = 32377, Name = "Þröskuldar" },
            new StationInfo { Id = 6760, Name = "Þúfuver" },
            new StationInfo { Id = 33424, Name = "Þverárfjall" },
            new StationInfo { Id = 2636, Name = "Þverfjall" },
            new StationInfo { Id = 7636, Name = "Þverfjall II" },
            new StationInfo { Id = 6208, Name = "Þykkvibær" },
            new StationInfo { Id = 1685, Name = "Þyrill" },
            new StationInfo { Id = 2655, Name = "Æðey" },
            new StationInfo { Id = 32654, Name = "Ögur" },
            new StationInfo { Id = 1493, Name = "Ölkelduháls" },
            new StationInfo { Id = 6134, Name = "Önundarhorn" },
            new StationInfo { Id = 35305, Name = "Öræfi" },
            new StationInfo { Id = 35963, Name = "Öxi" },
            new StationInfo { Id = 33357, Name = "Öxnadalsheiði" },


     };
    }
}