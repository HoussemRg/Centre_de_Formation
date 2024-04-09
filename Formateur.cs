
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

    private int idFormateur { get; set; }
    private double salaire { get; set; }

   
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

    public void ajouterFormateur(List<Formateur> formateurs)
    {
        formateurs.Add(this);
    }

    public void supprimerFormateur(List<Formateur> formateurs)
    {
        formateurs.Remove(this);
    }

    public void modifierFormateur(Formateur formateur)
    {
        this.idFormateur = formateur.GetIdFormateur();
        this.nom = formateur.GetNom();
        this.prenom=formateur.GetPrenom();
        this.tel = formateur.GetTel();
        this.salaire = formateur.GetSalaire();
    }

}