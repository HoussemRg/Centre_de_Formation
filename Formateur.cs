
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Formateur : Personne {

    public Formateur(int id, string n, string p, string tel, double salaire) : base(n, p, tel)
    {
        this.idFormateur = id;
        this.salaire = salaire;
    }

    private int idFormateur;
    private double salaire;

   
    public int GetIdFormateur()
    {
        return idFormateur;
    }

    
    public void SetIdFormateur(int value)
    {
        idFormateur = value;
    }

    
    public double GetSalaire()
    {
        return salaire;
    }

  
    public void SetSalaire(double value)
    {
        salaire = value;
    }

    

}