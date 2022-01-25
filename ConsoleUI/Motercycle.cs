using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motercycle : Vehicle
    {
        public Motercycle()
        {
                
        
        }

        public override void DriveAbstract()
        {
            throw new NotImplementedException();
        }
       
        public bool HasSideCart { get; set; } = true;
    }
}
