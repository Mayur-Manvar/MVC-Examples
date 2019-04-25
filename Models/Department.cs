using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }
}