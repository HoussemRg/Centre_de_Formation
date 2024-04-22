using Formation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

public class Cours {

    public Cours()
    {
        // Constructeur sans paramètres
    }
    public Cours(int id,string nom) {
        this.nomCours = nom;
        this.idCours = id;
    }

    public string nomCours {  get; set; }



    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int idCours { get; set; }
    public virtual ICollection<Formatione>? formations { get; set; }

   

    
    

}