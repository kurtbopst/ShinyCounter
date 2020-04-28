using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShinyCounter.Models
{
    public class Profile
    {


        public int Id { get; set; }

        //Biograhical Info
        public string username { get; set; }
        public string password { get; set; }



        public bool[] caught { get; set; }

        public int goal { get; set; }
        public int counter { get; set; }

    }
}
