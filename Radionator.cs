using System;
using System.Collections.Generic;
using System.Text;

using classy_electronics.Interfaces;

namespace classy_electronics
{
    public class Radionator
    {
        public IHasTurnTable TurnTable { get; }

        public IHasSpeaker Speaker { get; }

        public IHasRadio Radio { get; }


        public Radionator(IHasTurnTable turnTable, IHasSpeaker speaker, IHasRadio radio)
        {
            TurnTable = turnTable;
            Speaker = speaker;
            Radio = radio;
        }
    }
}