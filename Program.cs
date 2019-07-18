using System;


using classy_electronics.Models;


namespace classy_electronics
{
    class Program
    {
        static void Main(string[] args)
        {
            Speakanator mySpeakanator = new Speakanator(
                new BasicTurnTable(),
                new BasicSpeaker()
                );

            Radionator myRadionator = new Radionator(
    new BasicTurnTable(),
    new BasicSpeaker(),
    new BasicRadio()
    ) ;
        }
    }
}
