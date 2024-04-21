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

    private int idFormation;

    private string nomFormation;

    private double prixFormation;

    private Cours cours;

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
    

    }
