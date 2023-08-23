using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManageentProject4.Forntend.Models
{
    public class Employee
    {
        public int id { get; set; }

        public string name { get; set; } = string.Empty;


        public string address { get; set; } = string.Empty;


        public string gender { get; set; } = string.Empty;



        public int departmentId { get; set; }

        public DateTime joiningDate { get; set; }

        public Boolean ssc { get; set; }

        public Boolean hsc { get; set; }

        public Boolean bsc { get; set; }

        public Boolean msc { get; set; }


        public string picture { get; set; } = string.Empty;

        public int countryId { get; set; }


        public int stateId { get; set; }


        public int cityId { get; set; }


        [ForeignKey("CountryId")]
        public Country country { get; set; }

        [ForeignKey("StateId")]
        public State state { get; set; }

        [ForeignKey("CityId")]
        public City city { get; set; }

        [ForeignKey("DepartmentId")]
        public Department department { get; set; }
    }
}
