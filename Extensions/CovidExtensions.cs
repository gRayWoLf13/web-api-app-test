using System;
using web_api_app_test.Models;

namespace web_api_app_test.Extensions
{
    public static class CovidExtensions
    {
        private static Random _rand = new Random();

        public static CovidBindingModel Model1 => new CovidBindingModel
        {
            Language = "ru",
            FirstName = "М*********",
            SecondName = "С*****",
            ThirdName = "С********",
            DateOfBirth = new DateTime(1996, 1, 13),
            PassportNumber = 4000000961,
            CertNumber = 94700000,
            VaccineNumber = _rand.Next(100000000),
            DefaultVaccineNumber = "9470000029546681"
        };
        public static CovidBindingModel Model2 => new CovidBindingModel
        {
            Language = "ru",
            FirstName = "М*********",
            SecondName = "С*****",
            ThirdName = "С********",
            DateOfBirth = new DateTime(1996, 1, 13),
            PassportNumber = 4000000961,
            CertNumber = 94700000,
            VaccineNumber = _rand.Next(100000000),
            DefaultVaccineNumber = "9470000084852668"
        };
        public static CovidBindingModel Model3 => new CovidBindingModel
        {
            Language = "ru",
            FirstName = "М*********",
            SecondName = "С*****",
            ThirdName = "С********",
            DateOfBirth = new DateTime(1996, 1, 13),
            PassportNumber = 4000000961,
            CertNumber = 94700000,
            VaccineNumber = _rand.Next(100000000),
            DefaultVaccineNumber = "9470000029028667"
        };
        public static CovidBindingModel Model4 => new CovidBindingModel
        {
            Language = "ru",
            FirstName = "М*********",
            SecondName = "С*****",
            ThirdName = "С********",
            DateOfBirth = new DateTime(1996, 1, 13),
            PassportNumber = 4000000961,
            CertNumber = 94700000,
            VaccineNumber = _rand.Next(100000000),
            DefaultVaccineNumber = "9470000001635055"
        };
        public static CovidBindingModel Model5 => new CovidBindingModel
        {
            Language = "ru",
            FirstName = "Л******",
            SecondName = "В********",
            ThirdName = "Ю******",
            DateOfBirth = new DateTime(1996, 9, 10),
            PassportNumber = 4100000774,
            CertNumber = 94700000,
            VaccineNumber = _rand.Next(100000000),
            DefaultVaccineNumber = "9470000085444579"
        };
    }
}