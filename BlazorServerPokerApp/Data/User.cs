using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerPokerApp.Data
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string eMail{ get; set; }
        public string Pwd { get; set; }
    }
}
