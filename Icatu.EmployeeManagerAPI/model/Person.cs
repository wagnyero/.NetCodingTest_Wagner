using Icatu.EmployeeManagerAPI.model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Icatu.EmployeeManagerAPI.model
{
    [Table("persons")]
    public class Person : BaseEntity
    {
        [Column("name")]
        public string name { get; set; }

        [Column("email")]
        public string email { get; set; }

        [Column("department")]
        public string department { get; set; }
    }
}
