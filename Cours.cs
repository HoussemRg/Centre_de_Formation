using Formation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Cours {

    public Cours(int id,string nom) {
        this.nomCours = nom;
        this.idCours = id;
    }

    private string nomCours;

    private int idCours;

    public string getNomCours()
    {
        return nomCours;
    }


    public void setNomCour(string c)
    {
        nomCours = c;
    }

    public int getIdCours()
    {
        return idCours;
    }


    public void setIdCours(int id)
    {
        idCours = id;
    }

    

}