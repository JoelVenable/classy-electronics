using System;
using System.Collections.Generic;
using System.Text;
using classy_electronics.Interfaces;

namespace classy_electronics.Models
{
    class BasicSpeaker : IHasSpeaker
    {
        public int Volume { get; private set; };

        public void VolumeUp()
        {
            if (Volume < 11) Volume++;
            else Volume = 11;
        }

        public void VolumeDown()
        {
            if (Volume > 0) Volume--;
            else Volume = 0;
        }

    }
}
