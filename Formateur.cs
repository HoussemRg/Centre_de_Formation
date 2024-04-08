
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Formateur : Personne {

    public Formateur(int id,string n, string p, string tel,double salaire):base(n,p,tel) {
        this.idFormateur = id;     
        this.salaire = salaire; 
    }

    public int idFormateur;
    public double salaire;

    public void ajouterFormateur(List<Formateur> formateurs) {
        formateurs.Add(this);
    }

    public void supprimerFormateur(List<Formateur> formateurs) {
        formateurs.Remove(this);
    }

    public void modifierFormateur(List<Formateur> formateurs,int id,Formateur formateur) {
        Formateur F = formateurs.Find(f => f.idFormateur == id);
        if (F != null)
        {
            F = formateur;
            
        }
        else
        {
            
        }
    }

}