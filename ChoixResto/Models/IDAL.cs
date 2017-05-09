using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoixResto.Models
{
    public interface IDal : IDisposable
    {
        List<Resto> ObtientTousLesRestaurants();
        void CreerRestaurant(string nom, string telephone);
    }
}