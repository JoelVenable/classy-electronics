using System;
using System.Collections.Generic;
using System.Text;

namespace classy_electronics.Interfaces
{
    interface IHasCDPlayer
    {
         int TotalTracks { get; set; }
         int CurrentTrack { get; }

        void NextTrack();


        void PreviousTrack();
       
    }
}
