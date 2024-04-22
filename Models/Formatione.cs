using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;


 public class Formatione
    {

    public Formatione() { } 
    public Formatione(int id, string nom, double prix, Cours c)
    {
            idFormation = id;
            nomFormation = nom;
            prixFormation = prix;
            cours = c;
    }
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int idFormation {  get; set; }

    public string nomFormation {  get; set; }

    public double prixFormation {  get; set; }



    public int coursId { get; set; }

    public virtual Cours? cours { get; set; }


    public virtual ICollection<Session>? sessions {  get; set; }

}
