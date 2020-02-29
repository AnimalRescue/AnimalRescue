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
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class DateRange : IEquatable<DateRange>
    { 
        /// <summary>
        /// Gets or Sets StartYear
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum YearSelect
        {
            /// <summary>
            /// Enum _2000Enum for 2000
            /// </summary>
            [EnumMember(Value = "2000")]
            _2000Enum = 0,
            /// <summary>
            /// Enum _2001Enum for 2001
            /// </summary>
            [EnumMember(Value = "2001")]
            _2001Enum = 1,
            /// <summary>
            /// Enum _2002Enum for 2002
            /// </summary>
            [EnumMember(Value = "2002")]
            _2002Enum = 2,
            /// <summary>
            /// Enum _2003Enum for 2003
            /// </summary>
            [EnumMember(Value = "2003")]
            _2003Enum = 3,
            /// <summary>
            /// Enum _2004Enum for 2004
            /// </summary>
            [EnumMember(Value = "2004")]
            _2004Enum = 4,
            /// <summary>
            /// Enum _2005Enum for 2005
            /// </summary>
            [EnumMember(Value = "2005")]
            _2005Enum = 5,
            /// <summary>
            /// Enum _2006Enum for 2006
            /// </summary>
            [EnumMember(Value = "2006")]
            _2006Enum = 6,
            /// <summary>
            /// Enum _2007Enum for 2007
            /// </summary>
            [EnumMember(Value = "2007")]
            _2007Enum = 7,
            /// <summary>
            /// Enum _2008Enum for 2008
            /// </summary>
            [EnumMember(Value = "2008")]
            _2008Enum = 8,
            /// <summary>
            /// Enum _2009Enum for 2009
            /// </summary>
            [EnumMember(Value = "2009")]
            _2009Enum = 9,
            /// <summary>
            /// Enum _2010Enum for 2010
            /// </summary>
            [EnumMember(Value = "2010")]
            _2010Enum = 10,
            /// <summary>
            /// Enum _2011Enum for 2011
            /// </summary>
            [EnumMember(Value = "2011")]
            _2011Enum = 11,
            /// <summary>
            /// Enum _2012Enum for 2012
            /// </summary>
            [EnumMember(Value = "2012")]
            _2012Enum = 12,
            /// <summary>
            /// Enum _2013Enum for 2013
            /// </summary>
            [EnumMember(Value = "2013")]
            _2013Enum = 13,
            /// <summary>
            /// Enum _2014Enum for 2014
            /// </summary>
            [EnumMember(Value = "2014")]
            _2014Enum = 14,
            /// <summary>
            /// Enum _2015Enum for 2015
            /// </summary>
            [EnumMember(Value = "2015")]
            _2015Enum = 15,
            /// <summary>
            /// Enum _2016Enum for 2016
            /// </summary>
            [EnumMember(Value = "2016")]
            _2016Enum = 16,
            /// <summary>
            /// Enum _2017Enum for 2017
            /// </summary>
            [EnumMember(Value = "2017")]
            _2017Enum = 17,
            /// <summary>
            /// Enum _2018Enum for 2018
            /// </summary>
            [EnumMember(Value = "2018")]
            _2018Enum = 18,
            /// <summary>
            /// Enum _2019Enum for 2019
            /// </summary>
            [EnumMember(Value = "2019")]
            _2019Enum = 19,
            /// <summary>
            /// Enum _2020Enum for 2020
            /// </summary>
            [EnumMember(Value = "2020")]
            _2020Enum = 20,
            /// <summary>
            /// Enum _2021Enum for 2021
            /// </summary>
            [EnumMember(Value = "2021")]
            _2021Enum = 21,
            /// <summary>
            /// Enum _2022Enum for 2022
            /// </summary>
            [EnumMember(Value = "2022")]
            _2022Enum = 22,
            /// <summary>
            /// Enum _2023Enum for 2023
            /// </summary>
            [EnumMember(Value = "2023")]
            _2023Enum = 23,
            /// <summary>
            /// Enum _2024Enum for 2024
            /// </summary>
            [EnumMember(Value = "2024")]
            _2024Enum = 24,
            /// <summary>
            /// Enum _2025Enum for 2025
            /// </summary>
            [EnumMember(Value = "2025")]
            _2025Enum = 25,
            /// <summary>
            /// Enum _2026Enum for 2026
            /// </summary>
            [EnumMember(Value = "2026")]
            _2026Enum = 26,
            /// <summary>
            /// Enum _2027Enum for 2027
            /// </summary>
            [EnumMember(Value = "2027")]
            _2027Enum = 27,
            /// <summary>
            /// Enum _2028Enum for 2028
            /// </summary>
            [EnumMember(Value = "2028")]
            _2028Enum = 28,
            /// <summary>
            /// Enum _2029Enum for 2029
            /// </summary>
            [EnumMember(Value = "2029")]
            _2029Enum = 29,
            /// <summary>
            /// Enum _2030Enum for 2030
            /// </summary>
            [EnumMember(Value = "2030")]
            _2030Enum = 30,
            /// <summary>
            /// Enum _2031Enum for 2031
            /// </summary>
            [EnumMember(Value = "2031")]
            _2031Enum = 31,
            /// <summary>
            /// Enum _2032Enum for 2032
            /// </summary>
            [EnumMember(Value = "2032")]
            _2032Enum = 32,
            /// <summary>
            /// Enum _2033Enum for 2033
            /// </summary>
            [EnumMember(Value = "2033")]
            _2033Enum = 33,
            /// <summary>
            /// Enum _2034Enum for 2034
            /// </summary>
            [EnumMember(Value = "2034")]
            _2034Enum = 34,
            /// <summary>
            /// Enum _2035Enum for 2035
            /// </summary>
            [EnumMember(Value = "2035")]
            _2035Enum = 35,
            /// <summary>
            /// Enum _2036Enum for 2036
            /// </summary>
            [EnumMember(Value = "2036")]
            _2036Enum = 36,
            /// <summary>
            /// Enum _2037Enum for 2037
            /// </summary>
            [EnumMember(Value = "2037")]
            _2037Enum = 37,
            /// <summary>
            /// Enum _2038Enum for 2038
            /// </summary>
            [EnumMember(Value = "2038")]
            _2038Enum = 38,
            /// <summary>
            /// Enum _2039Enum for 2039
            /// </summary>
            [EnumMember(Value = "2039")]
            _2039Enum = 39,
            /// <summary>
            /// Enum _2040Enum for 2040
            /// </summary>
            [EnumMember(Value = "2040")]
            _2040Enum = 40,
            /// <summary>
            /// Enum _2041Enum for 2041
            /// </summary>
            [EnumMember(Value = "2041")]
            _2041Enum = 41,
            /// <summary>
            /// Enum _2042Enum for 2042
            /// </summary>
            [EnumMember(Value = "2042")]
            _2042Enum = 42,
            /// <summary>
            /// Enum _2043Enum for 2043
            /// </summary>
            [EnumMember(Value = "2043")]
            _2043Enum = 43,
            /// <summary>
            /// Enum _2044Enum for 2044
            /// </summary>
            [EnumMember(Value = "2044")]
            _2044Enum = 44,
            /// <summary>
            /// Enum _2045Enum for 2045
            /// </summary>
            [EnumMember(Value = "2045")]
            _2045Enum = 45,
            /// <summary>
            /// Enum _2046Enum for 2046
            /// </summary>
            [EnumMember(Value = "2046")]
            _2046Enum = 46,
            /// <summary>
            /// Enum _2047Enum for 2047
            /// </summary>
            [EnumMember(Value = "2047")]
            _2047Enum = 47,
            /// <summary>
            /// Enum _2048Enum for 2048
            /// </summary>
            [EnumMember(Value = "2048")]
            _2048Enum = 48,
            /// <summary>
            /// Enum _2049Enum for 2049
            /// </summary>
            [EnumMember(Value = "2049")]
            _2049Enum = 49        }

        /// <summary>
        /// Gets or Sets StartYear
        /// </summary>
        [DataMember(Name="startYear")]
        public YearSelect? StartYear { get; set; }

        /// <summary>
        /// Gets or Sets StartMonth
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum MonthSelect
        {
            /// <summary>
            /// Enum JanuaryEnum for January
            /// </summary>
            [EnumMember(Value = "January")]
            JanuaryEnum = 0,
            /// <summary>
            /// Enum FebruaryEnum for February
            /// </summary>
            [EnumMember(Value = "February")]
            FebruaryEnum = 1,
            /// <summary>
            /// Enum MarchEnum for March
            /// </summary>
            [EnumMember(Value = "March")]
            MarchEnum = 2,
            /// <summary>
            /// Enum AprilEnum for April
            /// </summary>
            [EnumMember(Value = "April")]
            AprilEnum = 3,
            /// <summary>
            /// Enum MayEnum for May
            /// </summary>
            [EnumMember(Value = "May")]
            MayEnum = 4,
            /// <summary>
            /// Enum JuneEnum for June
            /// </summary>
            [EnumMember(Value = "June")]
            JuneEnum = 5,
            /// <summary>
            /// Enum JulyEnum for July
            /// </summary>
            [EnumMember(Value = "July")]
            JulyEnum = 6,
            /// <summary>
            /// Enum AugustEnum for August
            /// </summary>
            [EnumMember(Value = "August")]
            AugustEnum = 7,
            /// <summary>
            /// Enum SeptemberEnum for September
            /// </summary>
            [EnumMember(Value = "September")]
            SeptemberEnum = 8,
            /// <summary>
            /// Enum OctoberEnum for October
            /// </summary>
            [EnumMember(Value = "October")]
            OctoberEnum = 9,
            /// <summary>
            /// Enum NovemberEnum for November
            /// </summary>
            [EnumMember(Value = "November")]
            NovemberEnum = 10,
            /// <summary>
            /// Enum DecemberEnum for December
            /// </summary>
            [EnumMember(Value = "December")]
            DecemberEnum = 11        }

        /// <summary>
        /// Gets or Sets StartMonth
        /// </summary>
        [DataMember(Name="startMonth")]
        public MonthSelect? StartMonth { get; set; }

        /// <summary>
        /// Gets or Sets StartDayOfMonth
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum DayOfMonthSelect
        {
            /// <summary>
            /// Enum _1Enum for 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1Enum = 0,
            /// <summary>
            /// Enum _2Enum for 2
            /// </summary>
            [EnumMember(Value = "2")]
            _2Enum = 1,
            /// <summary>
            /// Enum _3Enum for 3
            /// </summary>
            [EnumMember(Value = "3")]
            _3Enum = 2,
            /// <summary>
            /// Enum _4Enum for 4
            /// </summary>
            [EnumMember(Value = "4")]
            _4Enum = 3,
            /// <summary>
            /// Enum _5Enum for 5
            /// </summary>
            [EnumMember(Value = "5")]
            _5Enum = 4,
            /// <summary>
            /// Enum _6Enum for 6
            /// </summary>
            [EnumMember(Value = "6")]
            _6Enum = 5,
            /// <summary>
            /// Enum _7Enum for 7
            /// </summary>
            [EnumMember(Value = "7")]
            _7Enum = 6,
            /// <summary>
            /// Enum _8Enum for 8
            /// </summary>
            [EnumMember(Value = "8")]
            _8Enum = 7,
            /// <summary>
            /// Enum _9Enum for 9
            /// </summary>
            [EnumMember(Value = "9")]
            _9Enum = 8,
            /// <summary>
            /// Enum _10Enum for 10
            /// </summary>
            [EnumMember(Value = "10")]
            _10Enum = 9,
            /// <summary>
            /// Enum _11Enum for 11
            /// </summary>
            [EnumMember(Value = "11")]
            _11Enum = 10,
            /// <summary>
            /// Enum _12Enum for 12
            /// </summary>
            [EnumMember(Value = "12")]
            _12Enum = 11,
            /// <summary>
            /// Enum _13Enum for 13
            /// </summary>
            [EnumMember(Value = "13")]
            _13Enum = 12,
            /// <summary>
            /// Enum _14Enum for 14
            /// </summary>
            [EnumMember(Value = "14")]
            _14Enum = 13,
            /// <summary>
            /// Enum _15Enum for 15
            /// </summary>
            [EnumMember(Value = "15")]
            _15Enum = 14,
            /// <summary>
            /// Enum _16Enum for 16
            /// </summary>
            [EnumMember(Value = "16")]
            _16Enum = 15,
            /// <summary>
            /// Enum _17Enum for 17
            /// </summary>
            [EnumMember(Value = "17")]
            _17Enum = 16,
            /// <summary>
            /// Enum _18Enum for 18
            /// </summary>
            [EnumMember(Value = "18")]
            _18Enum = 17,
            /// <summary>
            /// Enum _19Enum for 19
            /// </summary>
            [EnumMember(Value = "19")]
            _19Enum = 18,
            /// <summary>
            /// Enum _20Enum for 20
            /// </summary>
            [EnumMember(Value = "20")]
            _20Enum = 19,
            /// <summary>
            /// Enum _21Enum for 21
            /// </summary>
            [EnumMember(Value = "21")]
            _21Enum = 20,
            /// <summary>
            /// Enum _22Enum for 22
            /// </summary>
            [EnumMember(Value = "22")]
            _22Enum = 21,
            /// <summary>
            /// Enum _23Enum for 23
            /// </summary>
            [EnumMember(Value = "23")]
            _23Enum = 22,
            /// <summary>
            /// Enum _24Enum for 24
            /// </summary>
            [EnumMember(Value = "24")]
            _24Enum = 23,
            /// <summary>
            /// Enum _25Enum for 25
            /// </summary>
            [EnumMember(Value = "25")]
            _25Enum = 24,
            /// <summary>
            /// Enum _26Enum for 26
            /// </summary>
            [EnumMember(Value = "26")]
            _26Enum = 25,
            /// <summary>
            /// Enum _27Enum for 27
            /// </summary>
            [EnumMember(Value = "27")]
            _27Enum = 26,
            /// <summary>
            /// Enum _28Enum for 28
            /// </summary>
            [EnumMember(Value = "28")]
            _28Enum = 27,
            /// <summary>
            /// Enum _29Enum for 29
            /// </summary>
            [EnumMember(Value = "29")]
            _29Enum = 28,
            /// <summary>
            /// Enum _30Enum for 30
            /// </summary>
            [EnumMember(Value = "30")]
            _30Enum = 29,
            /// <summary>
            /// Enum _31Enum for 31
            /// </summary>
            [EnumMember(Value = "31")]
            _31Enum = 30        }

        /// <summary>
        /// Gets or Sets StartDayOfMonth
        /// </summary>
        [DataMember(Name="startDayOfMonth")]
        public DayOfMonthSelect? StartDayOfMonth { get; set; }

        /// <summary>
        /// Gets or Sets EndYear
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum YearSelect
        {
            /// <summary>
            /// Enum _2000Enum for 2000
            /// </summary>
            [EnumMember(Value = "2000")]
            _2000Enum = 0,
            /// <summary>
            /// Enum _2001Enum for 2001
            /// </summary>
            [EnumMember(Value = "2001")]
            _2001Enum = 1,
            /// <summary>
            /// Enum _2002Enum for 2002
            /// </summary>
            [EnumMember(Value = "2002")]
            _2002Enum = 2,
            /// <summary>
            /// Enum _2003Enum for 2003
            /// </summary>
            [EnumMember(Value = "2003")]
            _2003Enum = 3,
            /// <summary>
            /// Enum _2004Enum for 2004
            /// </summary>
            [EnumMember(Value = "2004")]
            _2004Enum = 4,
            /// <summary>
            /// Enum _2005Enum for 2005
            /// </summary>
            [EnumMember(Value = "2005")]
            _2005Enum = 5,
            /// <summary>
            /// Enum _2006Enum for 2006
            /// </summary>
            [EnumMember(Value = "2006")]
            _2006Enum = 6,
            /// <summary>
            /// Enum _2007Enum for 2007
            /// </summary>
            [EnumMember(Value = "2007")]
            _2007Enum = 7,
            /// <summary>
            /// Enum _2008Enum for 2008
            /// </summary>
            [EnumMember(Value = "2008")]
            _2008Enum = 8,
            /// <summary>
            /// Enum _2009Enum for 2009
            /// </summary>
            [EnumMember(Value = "2009")]
            _2009Enum = 9,
            /// <summary>
            /// Enum _2010Enum for 2010
            /// </summary>
            [EnumMember(Value = "2010")]
            _2010Enum = 10,
            /// <summary>
            /// Enum _2011Enum for 2011
            /// </summary>
            [EnumMember(Value = "2011")]
            _2011Enum = 11,
            /// <summary>
            /// Enum _2012Enum for 2012
            /// </summary>
            [EnumMember(Value = "2012")]
            _2012Enum = 12,
            /// <summary>
            /// Enum _2013Enum for 2013
            /// </summary>
            [EnumMember(Value = "2013")]
            _2013Enum = 13,
            /// <summary>
            /// Enum _2014Enum for 2014
            /// </summary>
            [EnumMember(Value = "2014")]
            _2014Enum = 14,
            /// <summary>
            /// Enum _2015Enum for 2015
            /// </summary>
            [EnumMember(Value = "2015")]
            _2015Enum = 15,
            /// <summary>
            /// Enum _2016Enum for 2016
            /// </summary>
            [EnumMember(Value = "2016")]
            _2016Enum = 16,
            /// <summary>
            /// Enum _2017Enum for 2017
            /// </summary>
            [EnumMember(Value = "2017")]
            _2017Enum = 17,
            /// <summary>
            /// Enum _2018Enum for 2018
            /// </summary>
            [EnumMember(Value = "2018")]
            _2018Enum = 18,
            /// <summary>
            /// Enum _2019Enum for 2019
            /// </summary>
            [EnumMember(Value = "2019")]
            _2019Enum = 19,
            /// <summary>
            /// Enum _2020Enum for 2020
            /// </summary>
            [EnumMember(Value = "2020")]
            _2020Enum = 20,
            /// <summary>
            /// Enum _2021Enum for 2021
            /// </summary>
            [EnumMember(Value = "2021")]
            _2021Enum = 21,
            /// <summary>
            /// Enum _2022Enum for 2022
            /// </summary>
            [EnumMember(Value = "2022")]
            _2022Enum = 22,
            /// <summary>
            /// Enum _2023Enum for 2023
            /// </summary>
            [EnumMember(Value = "2023")]
            _2023Enum = 23,
            /// <summary>
            /// Enum _2024Enum for 2024
            /// </summary>
            [EnumMember(Value = "2024")]
            _2024Enum = 24,
            /// <summary>
            /// Enum _2025Enum for 2025
            /// </summary>
            [EnumMember(Value = "2025")]
            _2025Enum = 25,
            /// <summary>
            /// Enum _2026Enum for 2026
            /// </summary>
            [EnumMember(Value = "2026")]
            _2026Enum = 26,
            /// <summary>
            /// Enum _2027Enum for 2027
            /// </summary>
            [EnumMember(Value = "2027")]
            _2027Enum = 27,
            /// <summary>
            /// Enum _2028Enum for 2028
            /// </summary>
            [EnumMember(Value = "2028")]
            _2028Enum = 28,
            /// <summary>
            /// Enum _2029Enum for 2029
            /// </summary>
            [EnumMember(Value = "2029")]
            _2029Enum = 29,
            /// <summary>
            /// Enum _2030Enum for 2030
            /// </summary>
            [EnumMember(Value = "2030")]
            _2030Enum = 30,
            /// <summary>
            /// Enum _2031Enum for 2031
            /// </summary>
            [EnumMember(Value = "2031")]
            _2031Enum = 31,
            /// <summary>
            /// Enum _2032Enum for 2032
            /// </summary>
            [EnumMember(Value = "2032")]
            _2032Enum = 32,
            /// <summary>
            /// Enum _2033Enum for 2033
            /// </summary>
            [EnumMember(Value = "2033")]
            _2033Enum = 33,
            /// <summary>
            /// Enum _2034Enum for 2034
            /// </summary>
            [EnumMember(Value = "2034")]
            _2034Enum = 34,
            /// <summary>
            /// Enum _2035Enum for 2035
            /// </summary>
            [EnumMember(Value = "2035")]
            _2035Enum = 35,
            /// <summary>
            /// Enum _2036Enum for 2036
            /// </summary>
            [EnumMember(Value = "2036")]
            _2036Enum = 36,
            /// <summary>
            /// Enum _2037Enum for 2037
            /// </summary>
            [EnumMember(Value = "2037")]
            _2037Enum = 37,
            /// <summary>
            /// Enum _2038Enum for 2038
            /// </summary>
            [EnumMember(Value = "2038")]
            _2038Enum = 38,
            /// <summary>
            /// Enum _2039Enum for 2039
            /// </summary>
            [EnumMember(Value = "2039")]
            _2039Enum = 39,
            /// <summary>
            /// Enum _2040Enum for 2040
            /// </summary>
            [EnumMember(Value = "2040")]
            _2040Enum = 40,
            /// <summary>
            /// Enum _2041Enum for 2041
            /// </summary>
            [EnumMember(Value = "2041")]
            _2041Enum = 41,
            /// <summary>
            /// Enum _2042Enum for 2042
            /// </summary>
            [EnumMember(Value = "2042")]
            _2042Enum = 42,
            /// <summary>
            /// Enum _2043Enum for 2043
            /// </summary>
            [EnumMember(Value = "2043")]
            _2043Enum = 43,
            /// <summary>
            /// Enum _2044Enum for 2044
            /// </summary>
            [EnumMember(Value = "2044")]
            _2044Enum = 44,
            /// <summary>
            /// Enum _2045Enum for 2045
            /// </summary>
            [EnumMember(Value = "2045")]
            _2045Enum = 45,
            /// <summary>
            /// Enum _2046Enum for 2046
            /// </summary>
            [EnumMember(Value = "2046")]
            _2046Enum = 46,
            /// <summary>
            /// Enum _2047Enum for 2047
            /// </summary>
            [EnumMember(Value = "2047")]
            _2047Enum = 47,
            /// <summary>
            /// Enum _2048Enum for 2048
            /// </summary>
            [EnumMember(Value = "2048")]
            _2048Enum = 48,
            /// <summary>
            /// Enum _2049Enum for 2049
            /// </summary>
            [EnumMember(Value = "2049")]
            _2049Enum = 49        }

        /// <summary>
        /// Gets or Sets EndYear
        /// </summary>
        [DataMember(Name="endYear")]
        public YearSelect? EndYear { get; set; }

        /// <summary>
        /// Gets or Sets EndMonth
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum MonthSelect
        {
            /// <summary>
            /// Enum JanuaryEnum for January
            /// </summary>
            [EnumMember(Value = "January")]
            JanuaryEnum = 0,
            /// <summary>
            /// Enum FebruaryEnum for February
            /// </summary>
            [EnumMember(Value = "February")]
            FebruaryEnum = 1,
            /// <summary>
            /// Enum MarchEnum for March
            /// </summary>
            [EnumMember(Value = "March")]
            MarchEnum = 2,
            /// <summary>
            /// Enum AprilEnum for April
            /// </summary>
            [EnumMember(Value = "April")]
            AprilEnum = 3,
            /// <summary>
            /// Enum MayEnum for May
            /// </summary>
            [EnumMember(Value = "May")]
            MayEnum = 4,
            /// <summary>
            /// Enum JuneEnum for June
            /// </summary>
            [EnumMember(Value = "June")]
            JuneEnum = 5,
            /// <summary>
            /// Enum JulyEnum for July
            /// </summary>
            [EnumMember(Value = "July")]
            JulyEnum = 6,
            /// <summary>
            /// Enum AugustEnum for August
            /// </summary>
            [EnumMember(Value = "August")]
            AugustEnum = 7,
            /// <summary>
            /// Enum SeptemberEnum for September
            /// </summary>
            [EnumMember(Value = "September")]
            SeptemberEnum = 8,
            /// <summary>
            /// Enum OctoberEnum for October
            /// </summary>
            [EnumMember(Value = "October")]
            OctoberEnum = 9,
            /// <summary>
            /// Enum NovemberEnum for November
            /// </summary>
            [EnumMember(Value = "November")]
            NovemberEnum = 10,
            /// <summary>
            /// Enum DecemberEnum for December
            /// </summary>
            [EnumMember(Value = "December")]
            DecemberEnum = 11        }

        /// <summary>
        /// Gets or Sets EndMonth
        /// </summary>
        [DataMember(Name="endMonth")]
        public MonthSelect? EndMonth { get; set; }

        /// <summary>
        /// Gets or Sets EndDayOfMonth
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum DayOfMonthSelect
        {
            /// <summary>
            /// Enum _1Enum for 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1Enum = 0,
            /// <summary>
            /// Enum _2Enum for 2
            /// </summary>
            [EnumMember(Value = "2")]
            _2Enum = 1,
            /// <summary>
            /// Enum _3Enum for 3
            /// </summary>
            [EnumMember(Value = "3")]
            _3Enum = 2,
            /// <summary>
            /// Enum _4Enum for 4
            /// </summary>
            [EnumMember(Value = "4")]
            _4Enum = 3,
            /// <summary>
            /// Enum _5Enum for 5
            /// </summary>
            [EnumMember(Value = "5")]
            _5Enum = 4,
            /// <summary>
            /// Enum _6Enum for 6
            /// </summary>
            [EnumMember(Value = "6")]
            _6Enum = 5,
            /// <summary>
            /// Enum _7Enum for 7
            /// </summary>
            [EnumMember(Value = "7")]
            _7Enum = 6,
            /// <summary>
            /// Enum _8Enum for 8
            /// </summary>
            [EnumMember(Value = "8")]
            _8Enum = 7,
            /// <summary>
            /// Enum _9Enum for 9
            /// </summary>
            [EnumMember(Value = "9")]
            _9Enum = 8,
            /// <summary>
            /// Enum _10Enum for 10
            /// </summary>
            [EnumMember(Value = "10")]
            _10Enum = 9,
            /// <summary>
            /// Enum _11Enum for 11
            /// </summary>
            [EnumMember(Value = "11")]
            _11Enum = 10,
            /// <summary>
            /// Enum _12Enum for 12
            /// </summary>
            [EnumMember(Value = "12")]
            _12Enum = 11,
            /// <summary>
            /// Enum _13Enum for 13
            /// </summary>
            [EnumMember(Value = "13")]
            _13Enum = 12,
            /// <summary>
            /// Enum _14Enum for 14
            /// </summary>
            [EnumMember(Value = "14")]
            _14Enum = 13,
            /// <summary>
            /// Enum _15Enum for 15
            /// </summary>
            [EnumMember(Value = "15")]
            _15Enum = 14,
            /// <summary>
            /// Enum _16Enum for 16
            /// </summary>
            [EnumMember(Value = "16")]
            _16Enum = 15,
            /// <summary>
            /// Enum _17Enum for 17
            /// </summary>
            [EnumMember(Value = "17")]
            _17Enum = 16,
            /// <summary>
            /// Enum _18Enum for 18
            /// </summary>
            [EnumMember(Value = "18")]
            _18Enum = 17,
            /// <summary>
            /// Enum _19Enum for 19
            /// </summary>
            [EnumMember(Value = "19")]
            _19Enum = 18,
            /// <summary>
            /// Enum _20Enum for 20
            /// </summary>
            [EnumMember(Value = "20")]
            _20Enum = 19,
            /// <summary>
            /// Enum _21Enum for 21
            /// </summary>
            [EnumMember(Value = "21")]
            _21Enum = 20,
            /// <summary>
            /// Enum _22Enum for 22
            /// </summary>
            [EnumMember(Value = "22")]
            _22Enum = 21,
            /// <summary>
            /// Enum _23Enum for 23
            /// </summary>
            [EnumMember(Value = "23")]
            _23Enum = 22,
            /// <summary>
            /// Enum _24Enum for 24
            /// </summary>
            [EnumMember(Value = "24")]
            _24Enum = 23,
            /// <summary>
            /// Enum _25Enum for 25
            /// </summary>
            [EnumMember(Value = "25")]
            _25Enum = 24,
            /// <summary>
            /// Enum _26Enum for 26
            /// </summary>
            [EnumMember(Value = "26")]
            _26Enum = 25,
            /// <summary>
            /// Enum _27Enum for 27
            /// </summary>
            [EnumMember(Value = "27")]
            _27Enum = 26,
            /// <summary>
            /// Enum _28Enum for 28
            /// </summary>
            [EnumMember(Value = "28")]
            _28Enum = 27,
            /// <summary>
            /// Enum _29Enum for 29
            /// </summary>
            [EnumMember(Value = "29")]
            _29Enum = 28,
            /// <summary>
            /// Enum _30Enum for 30
            /// </summary>
            [EnumMember(Value = "30")]
            _30Enum = 29,
            /// <summary>
            /// Enum _31Enum for 31
            /// </summary>
            [EnumMember(Value = "31")]
            _31Enum = 30        }

        /// <summary>
        /// Gets or Sets EndDayOfMonth
        /// </summary>
        [DataMember(Name="endDayOfMonth")]
        public DayOfMonthSelect? EndDayOfMonth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DateRange {\n");
            sb.Append("  StartYear: ").Append(StartYear).Append("\n");
            sb.Append("  StartMonth: ").Append(StartMonth).Append("\n");
            sb.Append("  StartDayOfMonth: ").Append(StartDayOfMonth).Append("\n");
            sb.Append("  EndYear: ").Append(EndYear).Append("\n");
            sb.Append("  EndMonth: ").Append(EndMonth).Append("\n");
            sb.Append("  EndDayOfMonth: ").Append(EndDayOfMonth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((DateRange)obj);
        }

        /// <summary>
        /// Returns true if DateRange instances are equal
        /// </summary>
        /// <param name="other">Instance of DateRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateRange other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    StartYear == other.StartYear ||
                    StartYear != null &&
                    StartYear.Equals(other.StartYear)
                ) && 
                (
                    StartMonth == other.StartMonth ||
                    StartMonth != null &&
                    StartMonth.Equals(other.StartMonth)
                ) && 
                (
                    StartDayOfMonth == other.StartDayOfMonth ||
                    StartDayOfMonth != null &&
                    StartDayOfMonth.Equals(other.StartDayOfMonth)
                ) && 
                (
                    EndYear == other.EndYear ||
                    EndYear != null &&
                    EndYear.Equals(other.EndYear)
                ) && 
                (
                    EndMonth == other.EndMonth ||
                    EndMonth != null &&
                    EndMonth.Equals(other.EndMonth)
                ) && 
                (
                    EndDayOfMonth == other.EndDayOfMonth ||
                    EndDayOfMonth != null &&
                    EndDayOfMonth.Equals(other.EndDayOfMonth)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (StartYear != null)
                    hashCode = hashCode * 59 + StartYear.GetHashCode();
                    if (StartMonth != null)
                    hashCode = hashCode * 59 + StartMonth.GetHashCode();
                    if (StartDayOfMonth != null)
                    hashCode = hashCode * 59 + StartDayOfMonth.GetHashCode();
                    if (EndYear != null)
                    hashCode = hashCode * 59 + EndYear.GetHashCode();
                    if (EndMonth != null)
                    hashCode = hashCode * 59 + EndMonth.GetHashCode();
                    if (EndDayOfMonth != null)
                    hashCode = hashCode * 59 + EndDayOfMonth.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DateRange left, DateRange right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DateRange left, DateRange right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}