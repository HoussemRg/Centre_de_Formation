
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Personne {

    public Personne() { }
    public Personne(string n, string p, string tel)
    {
        this.nom=n;
        this.prenom=p;
        this.tel=tel;
    }

     

    public string nom { get; set; }
    public string prenom { get; set; }
    public string tel { get; set; }

}