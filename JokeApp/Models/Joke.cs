using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokeApp.Models
{
    public class Joke
    {
        //Create properties 
        //Short cut is prop + tab + tab
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        //Create constructor
        public Joke()
        {

        }


    }
}
