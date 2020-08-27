﻿using System.Collections.Generic;

namespace WelpNathan.Welp3166
{
    public class Country
    {
        /// <summary>
        /// Reference's ISO-3166's numeric identification.
        /// </summary>
        /// <remarks>Not an int due to numerics like 004</remarks>
        public string Id { get; private set; }
        
        /// <summary>
        /// Reference's a two-letter code that represents a country name,
        /// recommended as the general purpose code.
        /// </summary>
        public string Alpha2 { get; private set; }

        /// <summary>
        /// Reference's a three-letter code that represents a country name,
        /// which is usually more closely related to the country name
        /// </summary>
        public string Alpha3 { get; private set; }
        
        /// <summary>
        /// Reference's an English short name.
        /// </summary>
        public string EnShort { get; private set; }

        /// <summary>
        /// Creates a new object of country.
        /// </summary>
        /// <param name="id"><see cref="Id"/></param>
        /// <param name="alpha2"><see cref="Alpha2"/></param>
        /// <param name="alpha3"><see cref="Alpha3"/></param>
        /// <param name="enShort"><see cref="EnShort"/></param>
        private Country(string id, string alpha2, string alpha3, string enShort)
        {
            Id = id;
            Alpha2 = alpha2;
            Alpha3 = alpha3;
            EnShort = enShort;
        }

        /// <summary>
        /// Reference's a list of all countries officially
        /// recognised by the ISO-3166 standard.
        /// </summary>
        public static List<Country> Countries { get; set; } = new List<Country>
        {
            new Country("004", "AF", "AFG", "Afghanistan"),
            new Country("008", "AL", "ALB", "Albania"),
            new Country("012", "DZ", "DZA", "Algeria"),
            new Country("016", "AS", "ASM", "American Samoa"),
            new Country("020", "AD", "AND", "Andorra"),
            new Country("024", "AO", "AGO", "Angola"),
            new Country("660", "AI", "AIA", "Anguilla"),
            new Country("010", "AQ", "ATA", "Antarctica"),
            new Country("028", "AG", "ATG", "Antigua and Barbuda"),
            new Country("032", "AR", "ARG", "Argentina"),
            new Country("051", "AM", "ARM", "Armenia"),
            new Country("533", "AW", "ABW", "Aruba"),
            new Country("036", "AU", "AUS", "Australia"),
            new Country("040", "AT", "AUT", "Austria"),
            new Country("031", "AZ", "AZE", "Azerbaijan"),
            new Country("044", "BS", "BHS", "Bahamas (the)"),
            new Country("048", "BH", "BHR", "Bahrain"),
            new Country("050", "BD", "BGD", "Bangladesh"),
            new Country("052", "BB", "BRB", "Barbados"),
            new Country("112", "BY", "BLR", "Belarus"),
            new Country("056", "BE", "BEL", "Belgium"),
            new Country("084", "BZ", "BLZ", "Belize"),
            new Country("204", "BJ", "BEN", "Benin"),
            new Country("060", "BM", "BMU", "Bermuda"),
            new Country("064", "BT", "BTN", "Bhutan"),
            new Country("068", "BO", "BOL", "Bolivia (Plurinational State of)"),
            new Country("535", "BQ", "BES", "Bonaire, Sint Eustatius and Saba"),
            new Country("070", "BA", "BIH", "Bosnia and Herzegovina"),
            new Country("072", "BW", "BWA", "Botswana"),
            new Country("074", "BV", "BVT", "Bouvet Island"),
            new Country("076", "BR", "BRA", "Brazil"),
            new Country("086", "IO", "IOT", "British Indian Ocean Territory (the)"),
            new Country("096", "BN", "BRN", "Brunei Darussalam"),
            new Country("100", "BG", "BGR", "Bulgaria"),
            new Country("854", "BF", "BFA", "Burkina Faso"),
            new Country("108", "BI", "BDI", "Burundi"),
            new Country("132", "CV", "CPV", "Cabo Verde"),
            new Country("116", "KH", "KHM", "Cambodia"),
            new Country("120", "CM", "CMR", "Cameroon"),
            new Country("124", "CA", "CAN", "Canada"),
            new Country("136", "KY", "CYM", "Cayman Islands (the)"),
            new Country("140", "CF", "CAF", "Central African Republic (the)"),
            new Country("148", "TD", "TCD", "Chad"),
            new Country("152", "CL", "CHL", "Chile"),
            new Country("156", "CN", "CHN", "China"),
            new Country("162", "CX", "CXR", "Christmas Island"),
            new Country("166", "CC", "CCK", "Cocos (Keeling) Islands (the)"),
            new Country("170", "CO", "COL", "Colombia"),
            new Country("174", "KM", "COM", "Comoros (the)"),
            new Country("180", "CD", "COD", "Congo (the Democratic Republic of the)"),
            new Country("178", "CG", "COG", "Congo (the)"),
            new Country("184", "CK", "COK", "Cook Islands (the)"),
            new Country("188", "CR", "CRI", "Costa Rica"),
            new Country("191", "HR", "HRV", "Croatia"),
            new Country("192", "CU", "CUB", "Cuba"),
            new Country("531", "CW", "CUW", "Curaçao"),
            new Country("196", "CY", "CYP", "Cyprus"),
            new Country("203", "CZ", "CZE", "Czechia"),
            new Country("384", "CI", "CIV", "Côte d'Ivoire"),
            new Country("208", "DK", "DNK", "Denmark"),
            new Country("262", "DJ", "DJI", "Djibouti"),
            new Country("212", "DM", "DMA", "Dominica"),
            new Country("214", "DO", "DOM", "Dominican Republic (the)"),
            new Country("218", "EC", "ECU", "Ecuador"),
            new Country("818", "EG", "EGY", "Egypt"),
            new Country("222", "SV", "SLV", "El Salvador"),
            new Country("226", "GQ", "GNQ", "Equatorial Guinea"),
            new Country("232", "ER", "ERI", "Eritrea"),
            new Country("233", "EE", "EST", "Estonia"),
            new Country("748", "SZ", "SWZ", "Eswatini"),
            new Country("231", "ET", "ETH", "Ethiopia"),
            new Country("238", "FK", "FLK", "Falkland Islands (the) [Malvinas]"),
            new Country("234", "FO", "FRO", "Faroe Islands (the)"),
            new Country("242", "FJ", "FJI", "Fiji"),
            new Country("246", "FI", "FIN", "Finland"),
            new Country("250", "FR", "FRA", "France"),
            new Country("254", "GF", "GUF", "French Guiana"),
            new Country("258", "PF", "PYF", "French Polynesia"),
            new Country("260", "TF", "ATF", "French Southern Territories (the)"),
            new Country("266", "GA", "GAB", "Gabon"),
            new Country("270", "GM", "GMB", "Gambia (the)"),
            new Country("268", "GE", "GEO", "Georgia"),
            new Country("276", "DE", "DEU", "Germany"),
            new Country("288", "GH", "GHA", "Ghana"),
            new Country("292", "GI", "GIB", "Gibraltar"),
            new Country("300", "GR", "GRC", "Greece"),
            new Country("304", "GL", "GRL", "Greenland"),
            new Country("308", "GD", "GRD", "Grenada"),
            new Country("312", "GP", "GLP", "Guadeloupe"),
            new Country("316", "GU", "GUM", "Guam"),
            new Country("320", "GT", "GTM", "Guatemala"),
            new Country("831", "GG", "GGY", "Guernsey"),
            new Country("324", "GN", "GIN", "Guinea"),
            new Country("624", "GW", "GNB", "Guinea-Bissau"),
            new Country("328", "GY", "GUY", "Guyana"),
            new Country("332", "HT", "HTI", "Haiti"),
            new Country("334", "HM", "HMD", "Heard Island and McDonald Islands"),
            new Country("336", "VA", "VAT", "Holy See (the)"),
            new Country("340", "HN", "HND", "Honduras"),
            new Country("344", "HK", "HKG", "Hong Kong"),
            new Country("348", "HU", "HUN", "Hungary"),
            new Country("352", "IS", "ISL", "Iceland"),
            new Country("356", "IN", "IND", "India"),
            new Country("360", "ID", "IDN", "Indonesia"),
            new Country("364", "IR", "IRN", "Iran (Islamic Republic of)"),
            new Country("368", "IQ", "IRQ", "Iraq"),
            new Country("372", "IE", "IRL", "Ireland"),
            new Country("833", "IM", "IMN", "Isle of Man"),
            new Country("376", "IL", "ISR", "Israel"),
            new Country("380", "IT", "ITA", "Italy"),
            new Country("388", "JM", "JAM", "Jamaica"),
            new Country("392", "JP", "JPN", "Japan"),
            new Country("832", "JE", "JEY", "Jersey"),
            new Country("400", "JO", "JOR", "Jordan"),
            new Country("398", "KZ", "KAZ", "Kazakhstan"),
            new Country("404", "KE", "KEN", "Kenya"),
            new Country("296", "KI", "KIR", "Kiribati"),
            new Country("408", "KP", "PRK", "Korea (the Democratic People's Republic of)"),
            new Country("410", "KR", "KOR", "Korea (the Republic of)"),
            new Country("414", "KW", "KWT", "Kuwait"),
            new Country("417", "KG", "KGZ", "Kyrgyzstan"),
            new Country("418", "LA", "LAO", "Lao People's Democratic Republic (the)"),
            new Country("428", "LV", "LVA", "Latvia"),
            new Country("422", "LB", "LBN", "Lebanon"),
            new Country("426", "LS", "LSO", "Lesotho"),
            new Country("430", "LR", "LBR", "Liberia"),
            new Country("434", "LY", "LBY", "Libya"),
            new Country("438", "LI", "LIE", "Liechtenstein"),
            new Country("440", "LT", "LTU", "Lithuania"),
            new Country("442", "LU", "LUX", "Luxembourg"),
            new Country("446", "MO", "MAC", "Macao"),
            new Country("450", "MG", "MDG", "Madagascar"),
            new Country("454", "MW", "MWI", "Malawi"),
            new Country("458", "MY", "MYS", "Malaysia"),
            new Country("462", "MV", "MDV", "Maldives"),
            new Country("466", "ML", "MLI", "Mali"),
            new Country("470", "MT", "MLT", "Malta"),
            new Country("584", "MH", "MHL", "Marshall Islands (the)"),
            new Country("474", "MQ", "MTQ", "Martinique"),
            new Country("478", "MR", "MRT", "Mauritania"),
            new Country("480", "MU", "MUS", "Mauritius"),
            new Country("175", "YT", "MYT", "Mayotte"),
            new Country("484", "MX", "MEX", "Mexico"),
            new Country("583", "FM", "FSM", "Micronesia (Federated States of)"),
            new Country("498", "MD", "MDA", "Moldova (the Republic of)"),
            new Country("492", "MC", "MCO", "Monaco"),
            new Country("496", "MN", "MNG", "Mongolia"),
            new Country("499", "ME", "MNE", "Montenegro"),
            new Country("500", "MS", "MSR", "Montserrat"),
            new Country("504", "MA", "MAR", "Morocco"),
            new Country("508", "MZ", "MOZ", "Mozambique"),
            new Country("104", "MM", "MMR", "Myanmar"),
            new Country("516", "NA", "NAM", "Namibia"),
            new Country("520", "NR", "NRU", "Nauru"),
            new Country("524", "NP", "NPL", "Nepal"),
            new Country("528", "NL", "NLD", "Netherlands (the)"),
            new Country("540", "NC", "NCL", "New Caledonia"),
            new Country("554", "NZ", "NZL", "New Zealand"),
            new Country("558", "NI", "NIC", "Nicaragua"),
            new Country("562", "NE", "NER", "Niger (the)"),
            new Country("566", "NG", "NGA", "Nigeria"),
            new Country("570", "NU", "NIU", "Niue"),
            new Country("574", "NF", "NFK", "Norfolk Island"),
            new Country("807", "MK", "MKD", "North Macedonia"),
            new Country("580", "MP", "MNP", "Northern Mariana Islands (the)"),
            new Country("578", "NO", "NOR", "Norway"),
            new Country("512", "OM", "OMN", "Oman"),
            new Country("586", "PK", "PAK", "Pakistan"),
            new Country("585", "PW", "PLW", "Palau"),
            new Country("275", "PS", "PSE", "Palestine, State of"),
            new Country("591", "PA", "PAN", "Panama"),
            new Country("598", "PG", "PNG", "Papua New Guinea"),
            new Country("600", "PY", "PRY", "Paraguay"),
            new Country("604", "PE", "PER", "Peru"),
            new Country("608", "PH", "PHL", "Philippines (the)"),
            new Country("612", "PN", "PCN", "Pitcairn"),
            new Country("616", "PL", "POL", "Poland"),
            new Country("620", "PT", "PRT", "Portugal"),
            new Country("630", "PR", "PRI", "Puerto Rico"),
            new Country("634", "QA", "QAT", "Qatar"),
            new Country("642", "RO", "ROU", "Romania"),
            new Country("643", "RU", "RUS", "Russian Federation (the)"),
            new Country("646", "RW", "RWA", "Rwanda"),
            new Country("638", "RE", "REU", "Réunion"),
            new Country("652", "BL", "BLM", "Saint Barthélemy"),
            new Country("654", "SH", "SHN", "Saint Helena, Ascension and Tristan da Cunha"),
            new Country("659", "KN", "KNA", "Saint Kitts and Nevis"),
            new Country("662", "LC", "LCA", "Saint Lucia"),
            new Country("663", "MF", "MAF", "Saint Martin (French part)"),
            new Country("666", "PM", "SPM", "Saint Pierre and Miquelon"),
            new Country("670", "VC", "VCT", "Saint Vincent and the Grenadines"),
            new Country("882", "WS", "WSM", "Samoa"),
            new Country("674", "SM", "SMR", "San Marino"),
            new Country("678", "ST", "STP", "Sao Tome and Principe"),
            new Country("682", "SA", "SAU", "Saudi Arabia"),
            new Country("686", "SN", "SEN", "Senegal"),
            new Country("688", "RS", "SRB", "Serbia"),
            new Country("690", "SC", "SYC", "Seychelles"),
            new Country("694", "SL", "SLE", "Sierra Leone"),
            new Country("702", "SG", "SGP", "Singapore"),
            new Country("534", "SX", "SXM", "Sint Maarten (Dutch part)"),
            new Country("703", "SK", "SVK", "Slovakia"),
            new Country("705", "SI", "SVN", "Slovenia"),
            new Country("090", "SB", "SLB", "Solomon Islands"),
            new Country("706", "SO", "SOM", "Somalia"),
            new Country("710", "ZA", "ZAF", "South Africa"),
            new Country("239", "GS", "SGS", "South Georgia and the South Sandwich Islands"),
            new Country("728", "SS", "SSD", "South Sudan"),
            new Country("724", "ES", "ESP", "Spain"),
            new Country("144", "LK", "LKA", "Sri Lanka"),
            new Country("729", "SD", "SDN", "Sudan (the)"),
            new Country("740", "SR", "SUR", "Suriname"),
            new Country("744", "SJ", "SJM", "Svalbard and Jan Mayen"),
            new Country("752", "SE", "SWE", "Sweden"),
            new Country("756", "CH", "CHE", "Switzerland"),
            new Country("760", "SY", "SYR", "Syrian Arab Republic (the)"),
            new Country("158", "TW", "TWN", "Taiwan (Province of China)"),
            new Country("762", "TJ", "TJK", "Tajikistan"),
            new Country("834", "TZ", "TZA", "Tanzania, the United Republic of"),
            new Country("764", "TH", "THA", "Thailand"),
            new Country("626", "TL", "TLS", "Timor-Leste"),
            new Country("768", "TG", "TGO", "Togo"),
            new Country("772", "TK", "TKL", "Tokelau"),
            new Country("776", "TO", "TON", "Tonga"),
            new Country("780", "TT", "TTO", "Trinidad and Tobago"),
            new Country("788", "TN", "TUN", "Tunisia"),
            new Country("792", "TR", "TUR", "Turkey"),
            new Country("795", "TM", "TKM", "Turkmenistan"),
            new Country("796", "TC", "TCA", "Turks and Caicos Islands (the)"),
            new Country("798", "TV", "TUV", "Tuvalu"),
            new Country("800", "UG", "UGA", "Uganda"),
            new Country("804", "UA", "UKR", "Ukraine"),
            new Country("784", "AE", "ARE", "United Arab Emirates (the)"),
            new Country("826", "GB", "GBR", "United Kingdom of Great Britain and Northern Ireland (the)"),
            new Country("581", "UM", "UMI", "United States Minor Outlying Islands (the)"),
            new Country("840", "US", "USA", "United States of America (the)"),
            new Country("858", "UY", "URY", "Uruguay"),
            new Country("860", "UZ", "UZB", "Uzbekistan"),
            new Country("548", "VU", "VUT", "Vanuatu"),
            new Country("862", "VE", "VEN", "Venezuela (Bolivarian Republic of)"),
            new Country("704", "VN", "VNM", "Viet Nam"),
            new Country("092", "VG", "VGB", "Virgin Islands (British)"),
            new Country("850", "VI", "VIR", "Virgin Islands (U.S.)"),
            new Country("876", "WF", "WLF", "Wallis and Futuna"),
            new Country("732", "EH", "ESH", "Western Sahara*"),
            new Country("887", "YE", "YEM", "Yemen"),
            new Country("894", "ZM", "ZMB", "Zambia"),
            new Country("716", "ZW", "ZWE", "Zimbabwe"),
            new Country("248", "AX", "ALA", "Åland Islands")
        };
    }
}