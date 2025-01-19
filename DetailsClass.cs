using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Models
{
    internal class Detail
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ID  { get; set; }
        public String Fname { get; set; }

        public String Lname { get; set; }

        public int Age { get; set; }

        public String Address { get; set; }

        public DateTime DOB { get; set; }

    }
}
