using System;
using System.Collections.Generic;
using System.Text;
using classy_electronics.Interfaces;

namespace classy_electronics.Models
{
    class BasicTurnTable : IHasTurnTable
    {

        public int CurrentSpeed { get; set; }

        public bool IsPlaying { get; private set; }

        public void Play() { IsPlaying = true; }
        public void Stop() { IsPlaying = false; }


    }
}
