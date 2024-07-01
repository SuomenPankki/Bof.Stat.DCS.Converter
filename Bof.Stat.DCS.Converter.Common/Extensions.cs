using Bof.Stat.DCS.Converter.Common.Enums;
using System.Globalization;
using System.Reflection;
using System.Xml.Serialization;

namespace Bof.Stat.DCS.Converter.Common
{
    public static class Extensions
    {
        public static string DateToPeriod(this DateTime period, string frequency)
        {
            FrequencyEnum frequencyEnum;

            if (!Enum.TryParse(frequency, out frequencyEnum)) throw new ArgumentException("Invalid frequency");

            var errorMessage = "Invalid combination of period and frequency";

            switch (frequencyEnum)
            {
                case FrequencyEnum.H:
                    if (!new List<int> { 6, 12 }.Contains(period.Month)) throw new ArgumentException(errorMessage);
                    return $"{period.Year}H0{period.Month / 6}";

                case FrequencyEnum.A:
                    if (!new List<int> { 12 }.Contains(period.Month)) throw new ArgumentException(errorMessage);
                    return $"{period.Year}A0{period.Month / 12}";

                case FrequencyEnum.Q:
                    if (!new List<int> { 3, 6, 9, 12 }.Contains(period.Month)) throw new ArgumentException(errorMessage);
                    return $"{period.Year}Q0{period.Month / 3}";

                case FrequencyEnum.M:
                    if (period.Month < 10)
                    {
                        return $"{period.Year}M0{period.Month}";
                    }
                    else
                    {
                        return $"{period.Year}M{period.Month}";
                    }

                default:
                    throw new ArgumentException("Cannot convert date to period with given arguments");
            }
        }

        public static DateTime? PeriodToDate(this string period)
        {
            int month;

            if (period.Contains("A"))
            {
                month = int.Parse(period.Substring(6, 1)) * 12;
            }
            else if (period.Contains("H"))
            {
                month = int.Parse(period.Substring(6, 1)) * 6;
            }
            else if (period.Contains("Q"))
            {
                month = int.Parse(period.Substring(6, 1)) * 3;
            }
            else if (period.Contains("M"))
            {
                int len = period.Length - 5;
                month = int.Parse(period.Substring(5, len));
            } else {
                // should we throw if period doesn't contain A, H, Q, or M ?
                return null;
            }

            int year = int.Parse(period.Substring(0, 4));

            return new DateTime(year, month, 1).AddMonths(1).AddDays(-1);
        }

        public static string GetYesNo(this bool value)
        {
            return GetYesNo((bool?)value);
        }

        public static string GetYesNo(this bool? value)
        {
            if (value.HasValue)
            {
                if (value.Value) return "Y"; else return "N";
            }
            else return String.Empty;
        }

        public static string GetTypeOfBoFIdentifier(this string value)
        {
            switch (value)
            {
                case "VAT":
                    return "A";
                case "MFI":
                    return "M";
                case "FSAFUNDID":
                    return "I";
                case "LEI":
                    return "L";
                case "TK":
                    return "T";
                case "Y":
                    return "Y";
                default:
                    return string.Empty;
            }
        }

        public static string GetTypeOfeRegIdentifier(this string value)
        {

            switch (value)
            {
                case "A":
                    return "VAT";
                case "I":
                    return "FSAFUNDID";
                case "L":
                    return "LEI";
                case "M":
                    return "MFI";
                case "T":
                    return "TK";
                case "Y":
                    return "";
                default:
                    return string.Empty;
            }
        }

        public static DateTime? ParseToNullableDate(this string value)
        {
            return !String.IsNullOrEmpty(value) ? DateTime.ParseExact(value, "yyyyMMdd", CultureInfo.InvariantCulture) : null;
        }

        public static string? ParseToNullableDateString(this DateTime? value)
        {
            return value.HasValue ? ((DateTime)value).ToString("yyyyMMdd") : null;
        }
    }
}