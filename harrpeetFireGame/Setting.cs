using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harrpeetFireGame
{
   public class Setting
    {

        //object of the class that is used to generate the  no 
        public Random rd = new Random();
        
        // method to generate the fire 
        public int fire() {
            return rd.Next(1, 6);
        }

    }
}
