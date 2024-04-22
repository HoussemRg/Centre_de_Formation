
using CentreFormation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

public class Salle {

    public Salle() { }
    public Salle(int num,string d) {
        
        this.numSalle = num;
        this.depatement = d;
    }


    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int numSalle {  get; set; }


    public virtual ICollection<Session>? sessions {  get; set; }
    public string depatement {  get; set; }

    
    




}