using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnsProject.Models
{
    [Table("mainclasses")]
    class ClsMainClassess
    {
        [Key]
        public string cCode { get; set; }
        public string cDescription { get; set; }
    }
}
