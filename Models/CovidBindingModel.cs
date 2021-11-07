using System;

namespace web_api_app_test.Models
{
    public class CovidBindingModel
    {
        public string Language { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long PassportNumber { get; set; }
        public long CertNumber { get; set; }
        public long VaccineNumber { get; set; }
        public string DefaultVaccineNumber { get; set; }
    }
}