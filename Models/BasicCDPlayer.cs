using System;
using System.Collections.Generic;
using System.Text;
using classy_electronics.Interfaces;

namespace classy_electronics.Models
{
    class BasicCDPlayer :IHasCDPlayer
    {
        public int TotalTracks { get; set; }
        public int CurrentTrack { get; private set; }

        public void NextTrack()
        {
            if (CurrentTrack < TotalTracks) CurrentTrack++;

        }
        public void PreviousTrack()
        {
            if (CurrentTrack > 0) CurrentTrack--;
        }
    }
}
