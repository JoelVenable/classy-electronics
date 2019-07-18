using System;
using System.Collections.Generic;
using System.Text;

using classy_electronics.Interfaces;

namespace classy_electronics
{
    public class Speakanator
    {
        public IHasTurnTable TurnTable { get; }

        public IHasSpeaker Speaker { get; }



        public Speakanator(IHasTurnTable turnTable, IHasSpeaker speaker)
        {
            TurnTable = turnTable;
            Speaker = speaker;
        }
    }
}
