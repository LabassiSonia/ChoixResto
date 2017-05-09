﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoixResto.Models
{
    public class Dal :IDal
    {

        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }


        public List<Resto> ObtientTousLesRestaurants() {
            return bdd.Restos.ToList();
        }

        public void CreerRestaurant(string nom, string telephone) {
            bdd.Restos.Add(new Resto { Nom = nom, Telephone = telephone });
            bdd.SaveChanges(); //permet de persister les données dans la Base de données

        }





        public void Dispose() {
            bdd.Dispose();
        }


    }
}