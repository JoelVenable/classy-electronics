using System;
using System.Collections.Generic;
using System.Text;
using classy_electronics.Interfaces;


namespace classy_electronics.Models
{
    class BasicRadio : IHasRadio
    {

        public double CurrentFrequency { get; private set; }

        public List<double> FavoriteStations { get; private set; } = new List<double>();
        
        public void AddFavorite(double newFavorite)
        {
            if (!FavoriteStations.Contains(newFavorite)) {
                FavoriteStations.Add(newFavorite);
            }
        }

        public void RemoveFavorite(double favoriteToRemove)
        {
            FavoriteStations.Remove(favoriteToRemove);
        }

      


    }
}
