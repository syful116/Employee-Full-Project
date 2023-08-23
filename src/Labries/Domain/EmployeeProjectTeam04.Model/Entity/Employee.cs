using EmployeeProjectTeam04.Shared.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeProjectTeam04.Model.Entity;

public class Employee : BaseAuditableEntity, IEntity
{

   
    

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;


        public string Address { get; set; } = string.Empty;


        public string Gender { get; set; } = string.Empty;



        public int DepartmentId { get; set; }

        public DateTime JoiningDate { get; set; }

        public Boolean Ssc { get; set; }

        public Boolean Hsc { get; set; }

        public Boolean Bsc { get; set; }

        public Boolean Msc { get; set; }


        public string Picture { get; set; } = string.Empty;

        public int CountryId { get; set; }


        public int StateId { get; set; }


        public int CityId { get; set; }


        [ForeignKey("CountryId")]
        public Country ?Country { get; set; }

        [ForeignKey("StateId")]
        public State? State { get; set; }

        [ForeignKey("CityId")]
        public City? City { get; set; }

        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }



}
