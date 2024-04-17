using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


 public class Formatione
    {

        public Formatione(int id, string nom, double prix, Cours c)
        {
            idFormation = id;
            nomFormation = nom;
            prixFormation = prix;
            cours = c;
        }

        private int idFormation { get; set; }

        private string nomFormation { get; set; }

        private double prixFormation { get; set; }

        private Cours cours { get; set; }

        public int getIdFormation()
        {
            return idFormation;
        }


        public void setIdFormation(int value)
        {
            idFormation = value;
        }

        public string getNomFormation()
        {
            return nomFormation;
        }


        public void setnomFormation(string value)
        {
            nomFormation = value;
        }

        public double getPrixFormation()
        {
            return prixFormation;
        }



        public void setPrixFormation(double value)
        {
            prixFormation = value;
        }

        public Cours getCours()
        {
            return cours;
        }



        public void setCours(Cours value)
        {
            cours = value;
        }
    public void ajouterFormation(List<Formatione> formations)
        {
            formations.Add(this);
        }

        public void supprimerFormation(List<Formatione> formations)
        {
            formations.Remove(this);
        }

        public void modifierFormation(Formatione f)
        {
            idFormation= f.getIdFormation();
            nomFormation= f.getNomFormation();
            prixFormation= f.getPrixFormation();
            cours = f.getCours();
        }

    }
