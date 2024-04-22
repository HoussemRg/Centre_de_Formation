
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

public class Formateur : Personne {

    public Formateur() { }  
    public Formateur(int id, string n, string p, string tel, double salaire) : base(n, p, tel)
    {
        this.idFormateur = id;
        this.salaire = salaire;
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int idFormateur {  get; set; }
    public double salaire {  get; set; }
    
    public virtual ICollection<Session> sessions {  get; set; }

}