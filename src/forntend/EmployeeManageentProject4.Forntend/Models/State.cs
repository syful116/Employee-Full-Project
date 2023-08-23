using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManageentProject4.Forntend.Models
{
    public class State
    {
        public int id { get; set; }


        public string stateName { get; set; } = string.Empty;

        public int countryId { get; set; }



        [ForeignKey("CountryId")]
        public Country country { get; set; }
    }
}
