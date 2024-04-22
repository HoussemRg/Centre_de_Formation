
using CentreFormation.Models;
using Formation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

public class Participant : Personne {

    public Participant() { }
    public Participant(int id, string n, string p, string tel, bool etat):base(n, p, tel)
    {
        this.idParticipant = id;
        this.etatPayment = etat;
    }
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int idParticipant {  get; set; }

    public bool etatPayment {  get; set; }

    public virtual ICollection<Participation>? Participations { get; set; }
    public virtual ICollection<Session>? sessions {  get; set; }

    
    

    

}