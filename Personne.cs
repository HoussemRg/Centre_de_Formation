
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Personne {

    public Personne(string n, string p, string tel)
    {
        this.nom=n;
        this.prenom=p;
        this.tel=tel;
    }

    public string GetNom()
    {
        return nom;
    }

    public void SetNom(string value)
    {
        nom = value;
    }

    public string GetPrenom()
    {
        return prenom;
    }

    public void SetPrenom(string value)
    {
        prenom = value;
    }

    public string GetTel()
    {
        return tel;
    }

    public void SetTel(string value)
    {
        tel = value;
    }

    protected string nom;
    protected string prenom;
    protected string tel;

}