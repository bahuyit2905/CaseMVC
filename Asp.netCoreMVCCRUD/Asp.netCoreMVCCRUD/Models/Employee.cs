using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVCCRUD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage ="Nhập thông tin bắt buộc")]
        [DisplayName("Full name")]
        public string Fullname { get; set; }
        [Column(TypeName = "varchar(150)")]
        [DisplayName("Emp.Code")]
        public string EmpCode { get; set; }
        [Column(TypeName = "varchar(150)")]
        
        public string Position { get; set; }
        [Column(TypeName = "varchar(150)")]
        [DisplayName("Office Location")]

        public string OfficeLocation { get; set; }
    }
}
