﻿using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] frstName,LastName;
            frstName = new string[100] {"Noah","Liam","Jacob","William","Ethan","James", "Alexander",
    "Michael",    "Benjamin",
    "Elijah",    "Daniel",
    "Aiden",    "Logan",
    "Matthew","Lucas",    "Jackson",
    "David",    "Oliver",
    "Jayden",    "Joseph",
    "Gabriel",    "Samuel",
    "Carter",    "Anthony",
    "John",    "Dylan",
    "Luke",    "Henry",
    "Andrew",    "Isaac",
    "Christopher",    "Joshua",
    "Wyatt",    "Sebastian",
    "Owen",    "Caleb",
    "Nathan",    "Ryan",
    "Jack",    "Hunter",
    "Levi",    "Christian",
    "Jaxon",    "Julian",
    "Landon",    "Grayson",
    "Jonathan",    "Isaiah",
    "Charles",    "Thomas",
    "Aaron",    "Eli",
    "Connor",    "Jeremiah",
    "Cameron",    "Josiah",
    "Adrian",    "Colton",
    "Jordan",    "Brayden",
    "Nicholas",    "Robert",
    "Angel",    "Hudson",
    "Lincoln",    "Evan",
    "Dominic",    "Austin",
    "Gavin",    "Nolan",
    "Parker",    "Adam",
    "Chase",    "Jace",
    "Ian",    "Cooper",
    "Easton",    "Kevin",
    "Jose",    "Tyler",
    "Brandon",    "Asher",
    "Jaxson",    "Mateo",
    "Jason",    "Ayden",
    "Zachary",    "Carson",
    "Xavier",    "Leo",
    "Ezra",    "Bentley",
    "Sawyer",    "Kayden",
    "Blake",    "Nathaniel",
    "Ryder",    "Theodore",
    "Elias","Tristan" };
           LastName = new string[100] {"Emma",
    "Olivia",
    "Sophia",
    "Ava",
    "Isabella",
    "Mia",
    "Emily",
    "Charlotte",
    "Harper",
    "Madison",
    "Amelia",
    "Elizabeth",
    "Sofia",
    "Evelyn",
    "Avery",
    "Chloe",
    "Ella",
    "Grace",
    "Victoria",
    "Aubrey",
    "Scarlett",
    "Zoey",
    "Addison",
    "Lily",
    "Lillian",
    "Natalie",
    "Hannah",
    "Aria",
    "Layla",
    "Brooklyn",
    "Alexa",
    "Zoe",
    "Penelope",
    "Riley",
    "Leah",
    "Audrey",
    "Savannah",
    "Allison",
    "Samantha",
    "Nora",
    "Skylar",
    "Camila",
    "Anna",
    "Paisley",
    "Ariana",
    "Ellie",
    "Aaliyah",
    "Claire",
    "Violet",
    "Stella",
    "Sadie",
    "Mila",
    "Gabriella",
    "Lucy",
    "Arianna",
    "Kennedy",
    "Sarah",
    "Madelyn",
    "Eleanor",
    "Kaylee",
    "Caroline",
    "Hazel",
    "Hailey",
    "Genesis",
    "Kylie",
    "Autumn",
    "Piper",
    "Maya",
    "Nevaeh",
    "Serenity",
    "Peyton",
    "Mackenzie",
    "Bella",
    "Eva",
    "Taylor",
    "Naomi",
    "Aubree",
    "Aurora",
    "Melanie",
    "Lydia",
    "Brianna",
    "Ruby",
    "Katherine",
    "Ashley",
    "Alexis",
    "Alice",
    "Cora",
    "Julia",
    "Madeline",
    "Faith",
    "Annabelle",
    "Alyssa",
    "Isabelle",
    "Vivian",
    "Gianna",
    "Quinn",
    "Clara",
    "Reagan",
    "Khloe",
"Alexandra", };
            String[] sex, address,city;
            sex = new string[2] { "Male", "Female" };
            address = new string[100] { "Fake","Ulouf", "Gafa", "Doiro", "Hurbub", "Vevub", "Afzod", "Vafu", "Rapvub", "Oktun", "Lajcid", "Fodpap", "Jure", "Icri", "Pellid", "Fozri", "Dawit", "Repen", "Zugwij", "Ucso", "Imezez", "Juvtov", "Puazi", "Hekka", "Ekdiw", "Ocuele", "Tadger", "Gobkum", "Wuka", "Pohzep", "Wamjo", "Fufoj", "Vidve", "Lifgun", "Zaezi", "Joiru", "Cesi", "Ifetaf", "Jokeni", "Lijga", "Reije", "Emire", "Nipmuf", "Eboha", "Fomrep", "Cabdec", "Lobuw", "Pehwu", "Itazam", "Mactug", "Nahzow", "Hufhow", "Ivni", "Gete", "Bogfa", "Muup", "Niuse", "Reval", "Armac", "Cifge", "Kuwu", "Egpun", "Wudiv", "Sigu", "Zirbim", "Sihgaf", "Linac", "Tedag", "Omebu", "Mifile", "Tahceg", "Ifupod", "Rafle", "Abbot", "Faman", "Edte", "Mene", "Vufori", "Kidve", "Andi", "Govowa", "Fiwej", "Wuuf", "Ogrop", "Neeto", "Hinodu", "Ubwuv", "Hivcu", "Imuab", "Vafda", "Goni", "Cowpil", "Zibmem", "Atasu", "Pies", "Etel", "Angi", "Efke", "Pafab", "Medgeg" };
            city = new string[100] {"Wellington","Fegweigu",
"Gecocgi",
"Ozosame",
"Miumgaj",
"Bimadoj",
"Upubohrar",
"Efaocsu",
"Nodhajo",
"Lijajul",
"Unveler",
"Catjuhike",
"Raabtiv",
"Kewbisa",
"Neanuzo",
"Sepibu",
"Mokgage",
"Zefregep",
"Fuvdiog",
"Jifobro",
"Vavfotam",
"Gozratag",
"Ezeribibo",
"Dahmiji",
"Zaftedoga",
"Vozwicu",
"Witugi",
"Fattohew",
"Jecluohu",
"Avviden",
"Hoaveme",
"Ivhape",
"Ojukucgo",
"Mipzahev",
"Mezuato",
"Kefdofaf",
"Jaemuhi",
"Mofafne",
"Rocnuri",
"Ihmegez",
"Niwrared",
"Orzevsa",
"Torilror",
"Junemug",
"Jepihna",
"Wusdadven",
"Olsewe",
"Zoredri",
"Ofjiwwu",
"Lujhiwji",
"Arosinon",
"Vugipmu",
"Soogid",
"Wazuoj",
"Opesohrow",
"Cecrelod",
"Loguwtig",
"Cahtouk",
"Adorifan",
"Desagig",
"Hebimoli",
"Tevajve",
"Talkihi",
"Celazjop",
"Ecevowha",
"Bokfuda",
"Igetikig",
"Milteho",
"Rumzapsu",
"Wolunce",
"Huzsefog",
"Suvvuhju",
"Etailosa",
"Bulhatiho",
"Jeziceubi",
"Erpigpow",
"Dipjujaw",
"Tagehke",
"Fimcuuse",
"Cevodva",
"Waojuce",
"Kozpijgih",
"Neflaeje",
"Ahhamura",
"Gotowe",
"Cetucir",
"Jawicehu",
"Fomove",
"Voifazal",
"Sonrepu",
"Gicusra",
"Pujimep",
"Ruveso",
"Vuwkatho",
"Zovceni",
"Wumfizwar",
"Cuwsusbuj",
"Bupjeku",
"Riscusota",
"Momiseho"};
            string[] country;
            country = new string[] { "Afghanistan",
        "Albania",
        "Algeria",
        "American Samoa",
        "Andorra",
        "Angola",
        "Anguilla",
        "Antarctica",
        "Antigua and Barbuda",
        "Argentina",
        "Armenia",
        "Aruba",
        "Australia",
        "Austria",
        "Azerbaijan",
        "Bahamas",
        "Bahrain",
        "Bangladesh",
        "Barbados",
        "Belarus",
        "Belgium",
        "Belize",
        "Benin",
        "Bermuda",
        "Bhutan",
        "Bolivia",
        "Bosnia and Herzegovina",
        "Botswana",
        "Bouvet Island",
        "Brazil",
        "British Indian Ocean Territory",
        "Brunei Darussalam",
        "Bulgaria",
        "Burkina Faso",
        "Burundi",
        "Cambodia",
        "Cameroon",
        "Canada",
        "Cape Verde",
        "Cayman Islands",
        "Central African Republic",
        "Chad",
        "Chile",
        "China",
        "Christmas Island",
        "Cocos (Keeling) Islands",
        "Colombia",
        "Comoros",
        "Congo",
        "Congo, the Democratic Republic of the",
        "Cook Islands",
        "Costa Rica",
        "Cote D'Ivoire",
        "Croatia",
        "Cuba",
        "Cyprus",
        "Czech Republic",
        "Denmark",
        "Djibouti",
        "Dominica",
        "Dominican Republic",
        "Ecuador",
        "Egypt",
        "El Salvador",
        "Equatorial Guinea",
        "Eritrea",
        "Estonia",
        "Ethiopia",
        "Falkland Islands (Malvinas)",
        "Faroe Islands",
        "Fiji",
        "Finland",
        "France",
        "French Guiana",
        "French Polynesia",
        "French Southern Territories",
        "Gabon",
        "Gambia",
        "Georgia",
        "Germany",
        "Ghana",
        "Gibraltar",
        "Greece",
        "Greenland",
        "Grenada",
        "Guadeloupe",
        "Guam",
        "Guatemala",
        "Guinea",
        "Guinea-Bissau",
        "Guyana",
        "Haiti",
        "Heard Island and Mcdonald Islands",
        "Holy See (Vatican City State)",
        "Honduras",
        "Hong Kong",
        "Hungary",
        "Iceland",
        "India",
        "Indonesia",
        "Iran, Islamic Republic of",
        "Iraq",
        "Ireland",
        "Israel",
        "Italy",
        "Jamaica",
        "Japan",
        "Jordan",
        "Kazakhstan",
        "Kenya",
        "Kiribati",
        "Korea, Democratic People's Republic of",
        "Korea, Republic of",
        "Kuwait",
        "Kyrgyzstan",
        "Lao People's Democratic Republic",
        "Latvia",
        "Lebanon",
        "Lesotho",
        "Liberia",
        "Libyan Arab Jamahiriya",
        "Liechtenstein",
        "Lithuania",
        "Luxembourg",
        "Macao",
        "Macedonia, the Former Yugoslav Republic of",
        "Madagascar",
        "Malawi",
        "Malaysia",
        "Maldives",
        "Mali",
        "Malta",
        "Marshall Islands",
        "Martinique",
        "Mauritania",
        "Mauritius",
        "Mayotte",
        "Mexico",
        "Micronesia, Federated States of",
        "Moldova, Republic of",
        "Monaco",
        "Mongolia",
        "Montserrat",
        "Morocco",
        "Mozambique",
        "Myanmar",
        "Namibia",
        "Nauru",
        "Nepal",
        "Netherlands",
        "Netherlands Antilles",
        "New Caledonia",
        "New Zealand",
        "Nicaragua",
        "Niger",
        "Nigeria",
        "Niue",
        "Norfolk Island",
        "Northern Mariana Islands",
        "Norway",
        "Oman",
        "Pakistan",
        "Palau",
        "Palestinian Territory, Occupied",
        "Panama",
        "Papua New Guinea",
        "Paraguay",
        "Peru",
        "Philippines",
        "Pitcairn",
        "Poland",
        "Portugal",
        "Puerto Rico",
        "Qatar",
        "Reunion",
        "Romania",
        "Russian Federation",
        "Rwanda",
        "Saint Helena",
        "Saint Kitts and Nevis",
        "Saint Lucia",
        "Saint Pierre and Miquelon",
        "Saint Vincent and the Grenadines",
        "Samoa",
        "San Marino",
        "Sao Tome and Principe",
        "Saudi Arabia",
        "Senegal",
        "Serbia and Montenegro",
        "Seychelles",
        "Sierra Leone",
        "Singapore",
        "Slovakia",
        "Slovenia",
        "Solomon Islands",
        "Somalia",
        "South Africa",
        "South Georgia and the South Sandwich Islands",
        "Spain",
        "Sri Lanka",
        "Sudan",
        "Suriname",
        "Svalbard and Jan Mayen",
        "Swaziland",
        "Sweden",
        "Switzerland",
        "Syrian Arab Republic",
        "Taiwan, Province of China",
        "Tajikistan",
        "Tanzania, United Republic of",
        "Thailand",
        "Timor-Leste",
        "Togo",
        "Tokelau",
        "Tonga",
        "Trinidad and Tobago",
        "Tunisia",
        "Turkey",
        "Turkmenistan",
        "Turks and Caicos Islands",
        "Tuvalu",
        "Uganda",
        "Ukraine",
        "United Arab Emirates",
        "United Kingdom",
        "United States",
        "United States Minor Outlying Islands",
        "Uruguay",
        "Uzbekistan",
        "Vanuatu",
        "Venezuela",
        "Viet Nam",
        "Virgin Islands, British",
        "Virgin Islands, US",
        "Wallis and Futuna",
        "Western Sahara",
        "Yemen",
        "Zambia",
        "Zimbabwe", };
            Random rnd = new Random();
            int postCode = rnd.Next(000, 9999);
            int phone = rnd.Next(04600000, 999999999);
            int AddressNum = rnd.Next(0, 500);
            int country1 = rnd.Next(country.Length);
            int city1 = rnd.Next(city.Length);
            int firstname1 = rnd.Next(frstName.Length);
            int address1 = rnd.Next(address.Length);
            
            int sex1 = rnd.Next(sex.Length);
            int lastname2 = rnd.Next(LastName.Length);
            string[] email;
           
            email = new string[4] { "yahoo", "gmail", "xtra", "hotmail" };
            int email1 = rnd.Next(email.Length);
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("("+"\""+$"{LastName[lastname2]}"+ "\""+", "+ "\"" + $"{frstName[firstname1]}" + "\""+", " + "\""+$"{sex[sex1]}"+"\"" + ", " + " " + "\""+ $"{address[address1]}"+ "\"" + ", " + "\""+ $"{city[city1]}"+ "\"" + ", "+ "\""+ $"{country[country1]}"+ "\"" + ","+ postCode + "," + "\""+$"{frstName[firstname1]}"+"."+$"{LastName[lastname2]}" +"@"+ $"{email[email1]}"+".co.nz"+ "\""+", " + phone+")" + ",");
                sex1 = rnd.Next(sex.Length);
                email1 = rnd.Next(email.Length);
                postCode = rnd.Next(000, 9999);
                phone = rnd.Next(04600000, 999999999);
                AddressNum = rnd.Next(0, 500);
                country1 = rnd.Next(country.Length);
                city1 = rnd.Next(city.Length);
                firstname1 = rnd.Next(frstName.Length);
                address1 = rnd.Next(address.Length);
                lastname2 = rnd.Next(LastName.Length);
            }
                    Console.ReadLine();

              
            }
        }
    }

