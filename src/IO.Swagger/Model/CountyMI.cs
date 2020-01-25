/* 
 * AnimalRescue API
 *
 * API for OSS AnimalRescue
 *
 * OpenAPI spec version: 1.0.0-oas3
 * Contact: jlgartee@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Defines CountyMI
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum CountyMI
    {
        /// <summary>
        /// Enum Alcona for value: Alcona
        /// </summary>
        [EnumMember(Value = "Alcona")]
        Alcona = 0,
        /// <summary>
        /// Enum Alger for value: Alger
        /// </summary>
        [EnumMember(Value = "Alger")]
        Alger = 1,
        /// <summary>
        /// Enum Allegan for value: Allegan
        /// </summary>
        [EnumMember(Value = "Allegan")]
        Allegan = 2,
        /// <summary>
        /// Enum Alpena for value: Alpena
        /// </summary>
        [EnumMember(Value = "Alpena")]
        Alpena = 3,
        /// <summary>
        /// Enum Antrim for value: Antrim
        /// </summary>
        [EnumMember(Value = "Antrim")]
        Antrim = 4,
        /// <summary>
        /// Enum Arenac for value: Arenac
        /// </summary>
        [EnumMember(Value = "Arenac")]
        Arenac = 5,
        /// <summary>
        /// Enum Baraga for value: Baraga
        /// </summary>
        [EnumMember(Value = "Baraga")]
        Baraga = 6,
        /// <summary>
        /// Enum Barry for value: Barry
        /// </summary>
        [EnumMember(Value = "Barry")]
        Barry = 7,
        /// <summary>
        /// Enum Bay for value: Bay
        /// </summary>
        [EnumMember(Value = "Bay")]
        Bay = 8,
        /// <summary>
        /// Enum Benzie for value: Benzie
        /// </summary>
        [EnumMember(Value = "Benzie")]
        Benzie = 9,
        /// <summary>
        /// Enum Berrien for value: Berrien
        /// </summary>
        [EnumMember(Value = "Berrien")]
        Berrien = 10,
        /// <summary>
        /// Enum Branch for value: Branch
        /// </summary>
        [EnumMember(Value = "Branch")]
        Branch = 11,
        /// <summary>
        /// Enum Calhoun for value: Calhoun
        /// </summary>
        [EnumMember(Value = "Calhoun")]
        Calhoun = 12,
        /// <summary>
        /// Enum Cass for value: Cass
        /// </summary>
        [EnumMember(Value = "Cass")]
        Cass = 13,
        /// <summary>
        /// Enum Charlevoix for value: Charlevoix
        /// </summary>
        [EnumMember(Value = "Charlevoix")]
        Charlevoix = 14,
        /// <summary>
        /// Enum Cheboygan for value: Cheboygan
        /// </summary>
        [EnumMember(Value = "Cheboygan")]
        Cheboygan = 15,
        /// <summary>
        /// Enum Chippewa for value: Chippewa
        /// </summary>
        [EnumMember(Value = "Chippewa")]
        Chippewa = 16,
        /// <summary>
        /// Enum Clare for value: Clare
        /// </summary>
        [EnumMember(Value = "Clare")]
        Clare = 17,
        /// <summary>
        /// Enum Clinton for value: Clinton
        /// </summary>
        [EnumMember(Value = "Clinton")]
        Clinton = 18,
        /// <summary>
        /// Enum Crawford for value: Crawford
        /// </summary>
        [EnumMember(Value = "Crawford")]
        Crawford = 19,
        /// <summary>
        /// Enum Delta for value: Delta
        /// </summary>
        [EnumMember(Value = "Delta")]
        Delta = 20,
        /// <summary>
        /// Enum Dickinson for value: Dickinson
        /// </summary>
        [EnumMember(Value = "Dickinson")]
        Dickinson = 21,
        /// <summary>
        /// Enum Eaton for value: Eaton
        /// </summary>
        [EnumMember(Value = "Eaton")]
        Eaton = 22,
        /// <summary>
        /// Enum Emmet for value: Emmet
        /// </summary>
        [EnumMember(Value = "Emmet")]
        Emmet = 23,
        /// <summary>
        /// Enum Genesee for value: Genesee
        /// </summary>
        [EnumMember(Value = "Genesee")]
        Genesee = 24,
        /// <summary>
        /// Enum Gladwin for value: Gladwin
        /// </summary>
        [EnumMember(Value = "Gladwin")]
        Gladwin = 25,
        /// <summary>
        /// Enum Gogebic for value: Gogebic  
        /// </summary>
        [EnumMember(Value = "Gogebic  ")]
        Gogebic = 26,
        /// <summary>
        /// Enum GrandTraverse for value: Grand Traverse
        /// </summary>
        [EnumMember(Value = "Grand Traverse")]
        GrandTraverse = 27,
        /// <summary>
        /// Enum Gratiot for value: Gratiot
        /// </summary>
        [EnumMember(Value = "Gratiot")]
        Gratiot = 28,
        /// <summary>
        /// Enum Hillsdale for value: Hillsdale
        /// </summary>
        [EnumMember(Value = "Hillsdale")]
        Hillsdale = 29,
        /// <summary>
        /// Enum Houghton for value: Houghton
        /// </summary>
        [EnumMember(Value = "Houghton")]
        Houghton = 30,
        /// <summary>
        /// Enum Huron for value: Huron
        /// </summary>
        [EnumMember(Value = "Huron")]
        Huron = 31,
        /// <summary>
        /// Enum Ingham for value: Ingham
        /// </summary>
        [EnumMember(Value = "Ingham")]
        Ingham = 32,
        /// <summary>
        /// Enum Ionia for value: Ionia
        /// </summary>
        [EnumMember(Value = "Ionia")]
        Ionia = 33,
        /// <summary>
        /// Enum Iosco for value: Iosco
        /// </summary>
        [EnumMember(Value = "Iosco")]
        Iosco = 34,
        /// <summary>
        /// Enum Iron for value: Iron
        /// </summary>
        [EnumMember(Value = "Iron")]
        Iron = 35,
        /// <summary>
        /// Enum Isabella for value: Isabella
        /// </summary>
        [EnumMember(Value = "Isabella")]
        Isabella = 36,
        /// <summary>
        /// Enum Jackson for value: Jackson
        /// </summary>
        [EnumMember(Value = "Jackson")]
        Jackson = 37,
        /// <summary>
        /// Enum Kalamazoo for value: Kalamazoo
        /// </summary>
        [EnumMember(Value = "Kalamazoo")]
        Kalamazoo = 38,
        /// <summary>
        /// Enum Kalkaska for value: Kalkaska
        /// </summary>
        [EnumMember(Value = "Kalkaska")]
        Kalkaska = 39,
        /// <summary>
        /// Enum Kent for value: Kent
        /// </summary>
        [EnumMember(Value = "Kent")]
        Kent = 40,
        /// <summary>
        /// Enum Keweenaw for value: Keweenaw
        /// </summary>
        [EnumMember(Value = "Keweenaw")]
        Keweenaw = 41,
        /// <summary>
        /// Enum Lake for value: Lake
        /// </summary>
        [EnumMember(Value = "Lake")]
        Lake = 42,
        /// <summary>
        /// Enum Lapeer for value: Lapeer
        /// </summary>
        [EnumMember(Value = "Lapeer")]
        Lapeer = 43,
        /// <summary>
        /// Enum Leelanau for value: Leelanau
        /// </summary>
        [EnumMember(Value = "Leelanau")]
        Leelanau = 44,
        /// <summary>
        /// Enum Lenawee for value: Lenawee
        /// </summary>
        [EnumMember(Value = "Lenawee")]
        Lenawee = 45,
        /// <summary>
        /// Enum Livingston for value: Livingston
        /// </summary>
        [EnumMember(Value = "Livingston")]
        Livingston = 46,
        /// <summary>
        /// Enum Luce for value: Luce
        /// </summary>
        [EnumMember(Value = "Luce")]
        Luce = 47,
        /// <summary>
        /// Enum Mackinac for value: Mackinac
        /// </summary>
        [EnumMember(Value = "Mackinac")]
        Mackinac = 48,
        /// <summary>
        /// Enum Macomb for value: Macomb
        /// </summary>
        [EnumMember(Value = "Macomb")]
        Macomb = 49,
        /// <summary>
        /// Enum Manistee for value: Manistee
        /// </summary>
        [EnumMember(Value = "Manistee")]
        Manistee = 50,
        /// <summary>
        /// Enum Marquette for value: Marquette
        /// </summary>
        [EnumMember(Value = "Marquette")]
        Marquette = 51,
        /// <summary>
        /// Enum Mason for value: Mason
        /// </summary>
        [EnumMember(Value = "Mason")]
        Mason = 52,
        /// <summary>
        /// Enum Mecosta for value: Mecosta
        /// </summary>
        [EnumMember(Value = "Mecosta")]
        Mecosta = 53,
        /// <summary>
        /// Enum Menominee for value: Menominee
        /// </summary>
        [EnumMember(Value = "Menominee")]
        Menominee = 54,
        /// <summary>
        /// Enum Midland for value: Midland
        /// </summary>
        [EnumMember(Value = "Midland")]
        Midland = 55,
        /// <summary>
        /// Enum Missaukee for value: Missaukee
        /// </summary>
        [EnumMember(Value = "Missaukee")]
        Missaukee = 56,
        /// <summary>
        /// Enum Monroe for value: Monroe
        /// </summary>
        [EnumMember(Value = "Monroe")]
        Monroe = 57,
        /// <summary>
        /// Enum Montcalm for value: Montcalm
        /// </summary>
        [EnumMember(Value = "Montcalm")]
        Montcalm = 58,
        /// <summary>
        /// Enum Montmorency for value: Montmorency
        /// </summary>
        [EnumMember(Value = "Montmorency")]
        Montmorency = 59,
        /// <summary>
        /// Enum Muskegon for value: Muskegon
        /// </summary>
        [EnumMember(Value = "Muskegon")]
        Muskegon = 60,
        /// <summary>
        /// Enum Newaygo for value: Newaygo
        /// </summary>
        [EnumMember(Value = "Newaygo")]
        Newaygo = 61,
        /// <summary>
        /// Enum Oakland for value: Oakland
        /// </summary>
        [EnumMember(Value = "Oakland")]
        Oakland = 62,
        /// <summary>
        /// Enum Oceana for value: Oceana
        /// </summary>
        [EnumMember(Value = "Oceana")]
        Oceana = 63,
        /// <summary>
        /// Enum Ogemaw for value: Ogemaw
        /// </summary>
        [EnumMember(Value = "Ogemaw")]
        Ogemaw = 64,
        /// <summary>
        /// Enum Ontonagon for value: Ontonagon
        /// </summary>
        [EnumMember(Value = "Ontonagon")]
        Ontonagon = 65,
        /// <summary>
        /// Enum Osceola for value: Osceola
        /// </summary>
        [EnumMember(Value = "Osceola")]
        Osceola = 66,
        /// <summary>
        /// Enum Oscoda for value: Oscoda
        /// </summary>
        [EnumMember(Value = "Oscoda")]
        Oscoda = 67,
        /// <summary>
        /// Enum Otsego for value: Otsego
        /// </summary>
        [EnumMember(Value = "Otsego")]
        Otsego = 68,
        /// <summary>
        /// Enum Ottawa for value: Ottawa
        /// </summary>
        [EnumMember(Value = "Ottawa")]
        Ottawa = 69,
        /// <summary>
        /// Enum PresqueIsle for value: Presque Isle
        /// </summary>
        [EnumMember(Value = "Presque Isle")]
        PresqueIsle = 70,
        /// <summary>
        /// Enum Roscommon for value: Roscommon
        /// </summary>
        [EnumMember(Value = "Roscommon")]
        Roscommon = 71,
        /// <summary>
        /// Enum Saginaw for value: Saginaw
        /// </summary>
        [EnumMember(Value = "Saginaw")]
        Saginaw = 72,
        /// <summary>
        /// Enum StClair for value: St. Clair
        /// </summary>
        [EnumMember(Value = "St. Clair")]
        StClair = 73,
        /// <summary>
        /// Enum StJoseph for value: St. Joseph
        /// </summary>
        [EnumMember(Value = "St. Joseph")]
        StJoseph = 74,
        /// <summary>
        /// Enum Sanilac for value: Sanilac
        /// </summary>
        [EnumMember(Value = "Sanilac")]
        Sanilac = 75,
        /// <summary>
        /// Enum Schoolcraft for value: Schoolcraft
        /// </summary>
        [EnumMember(Value = "Schoolcraft")]
        Schoolcraft = 76,
        /// <summary>
        /// Enum Shiawassee for value: Shiawassee
        /// </summary>
        [EnumMember(Value = "Shiawassee")]
        Shiawassee = 77,
        /// <summary>
        /// Enum Tuscola for value: Tuscola
        /// </summary>
        [EnumMember(Value = "Tuscola")]
        Tuscola = 78,
        /// <summary>
        /// Enum VanBuren for value: Van Buren
        /// </summary>
        [EnumMember(Value = "Van Buren")]
        VanBuren = 79,
        /// <summary>
        /// Enum Washtenaw for value: Washtenaw
        /// </summary>
        [EnumMember(Value = "Washtenaw")]
        Washtenaw = 80,
        /// <summary>
        /// Enum Wayne for value: Wayne
        /// </summary>
        [EnumMember(Value = "Wayne")]
        Wayne = 81,
        /// <summary>
        /// Enum Wexford for value: Wexford
        /// </summary>
        [EnumMember(Value = "Wexford")]
        Wexford = 82    }
}
