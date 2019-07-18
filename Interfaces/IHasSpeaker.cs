using System;
using System.Collections.Generic;
using System.Text;

namespace classy_electronics.Interfaces
{
    public interface IHasSpeaker
    {
         int Volume { get;  }

        void VolumeUp();



         void VolumeDown();
       
    }
}
