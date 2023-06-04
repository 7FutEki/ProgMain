using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class DataAdressBook
    {
        [Key]
        public string Name2 { get; set; }
        public string SecondName { get; set; }
        public string Adress { get; set; }
        public string WorkPhone { get; set; }
        public string HomePhone { get; set; }
        public string PostInd { get; set; }
    }
}
