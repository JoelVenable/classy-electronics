using System;
using System.Collections.Generic;
using System.Text;

namespace classy_electronics.Interfaces
{
    public interface IHasRadio
    {
         double CurrentFrequency { get;  }

         List<double> FavoriteStations { get; } 

         void AddFavorite(double newFavorite);



         void RemoveFavorite(double favoriteToRemove);
      
    }
}
