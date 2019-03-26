using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace C1MvcDemo.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [DisplayName("Họ tên")]
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string FullName { get; set; }
        [DisplayName("Mã nhân viên")]
        [Column(TypeName = "varchar(50)")]
        public string EmpCode { get; set; }
        [DisplayName("Vị trí")]
        [Column(TypeName = "varchar(250)")]
        public string Position { get; set; }
        [DisplayName("Nơi làm việc")]
        [Column(TypeName = "varchar(250)")]
        public string OfficeLocation { get; set; }
    }
}
