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


        //There's gotta be a better way to do this!
        public bool caught1 { get; set; }
        public bool caught2 { get; set; }
        public bool caught3 { get; set; }
        public bool caught4 { get; set; }
        public bool caught5 { get; set; }
        public bool caught6 { get; set; }
        public bool caught7 { get; set; }
        public bool caught8 { get; set; }
        public bool caught9 { get; set; }
        public bool caught10 { get; set; }
        public bool caught11 { get; set; }

        public bool caught12 { get; set; }


        public int goal { get; set; }
        public int counter { get; set; }

    }
}
