using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoixResto.Models
{

    public interface IDal_seo : IDisposable
    {
        void CreerRestaurant(string nom, string telephone);
        void ModifierRestaurant(int id, string nom, string telephone);
        List<Resto> ObtientTousLesRestaurants();
        bool RestaurantExiste(string v);
        Utilisateur ObtenirUtilisateur(int v);
        Utilisateur ObtenirUtilisateur(string v);
        int  AjouterUtilisateur(string v1, string v2);
        Utilisateur Authentifier(string v1, string v2);
        bool ADejaVote(int v1, string v2);
        int CreerUnSondage();
        void AjouterVote(int idSondage, int v, int idUtilisateur);
        List<Resultats> ObtenirLesResultats(int idSondage);
    }


    public class DalSEO : IDal_seo
    {
        private BddContext bdd;

        public DalSEO()
        {
            bdd = new BddContext();
        }

        public List<Resto> ObtientTousLesRestaurants()
        {
            return bdd.Restos.ToList();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public void CreerRestaurant(string nom, string telephone)
        {
            bdd.Restos.Add(new Resto { Nom = nom, Telephone = telephone });
            bdd.SaveChanges();
        }

        public void ModifierRestaurant(int id, string nom, string telephone)
        {
            Resto restoTrouve = bdd.Restos.FirstOrDefault(resto => resto.Id == id);
            if (restoTrouve != null)
            {
                restoTrouve.Nom = nom;
                restoTrouve.Telephone = telephone;
                bdd.SaveChanges();
            }
        }

        public bool RestaurantExiste(string v)
        {
            throw new NotImplementedException();
        }

        public Utilisateur ObtenirUtilisateur(int v)
        {
            throw new NotImplementedException();
        }

        public Utilisateur ObtenirUtilisateur(string v)
        {
            throw new NotImplementedException();
        }

        public int AjouterUtilisateur(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public Utilisateur Authentifier(string nom, string motDePasse)
        {
            throw new NotImplementedException();
        }

        public bool ADejaVote(int v1, string v2)
        {
            throw new NotImplementedException();
        }

        public int CreerUnSondage()
        {
            throw new NotImplementedException();
        }

        public void AjouterVote(int idSondage, int v, int idUtilisateur)
        {
            throw new NotImplementedException();
        }

        public List<Resultats> ObtenirLesResultats(int idSondage)
        {
            throw new NotImplementedException();
        }
    }
}