using System;
using System.Collections.Generic;
using System.Text;

namespace classy_electronics.Interfaces
{
    public interface IHasTurnTable
    {
         int CurrentSpeed { get; set; }

         bool IsPlaying { get; }

         void Play();
         void Stop();


    }
}
