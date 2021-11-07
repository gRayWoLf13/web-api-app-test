using System;

namespace web_api_app_test.Extensions
{
    public static class StringExtensions
    {
        public static string Transliterate(this string source)
        {
            if (!(source is {Length: 1}))
                throw new Exception("Invalid string");

            var result = source.ToLowerInvariant() switch
            {
                "а" => "a",
                "б" => "b",
                "в" => "v",
                "г" => "g",
                "д" => "d",
                "е" => "e",
                "ё" => "e",
                "ж" => "zh",
                "з" => "z",
                "и" => "i",
                "й" => "i",
                "к" => "k",
                "л" => "l",
                "м" => "m",
                "н" => "n",
                "о" => "o",
                "п" => "p",
                "р" => "r",
                "с" => "s",
                "т" => "t",
                "у" => "u",
                "ф" => "f",
                "х" => "кh",
                "ц" => "ts",
                "ч" => "сh",
                "ш" => "sh",
                "щ" => "shch",
                "ы" => "y",
                "ъ" => "ie",
                "э" => "e",
                "ю" => "iu",
                "я" => "ia",
                _ => "FUCKING SHIT"
            };
            result = result.ToUpperInvariant();
            return result;
        }
    }
}