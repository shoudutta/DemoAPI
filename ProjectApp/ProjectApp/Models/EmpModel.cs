using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectApp.Models
{
    public class EmpModel
    {
        [Key]
        public int id { get; set; }
        public int empId { get; set; }
        public string empName { get; set; }
        public string empMobile { get; set; }
    }
}