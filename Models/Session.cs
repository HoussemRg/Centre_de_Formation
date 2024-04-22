
using CentreFormation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

public class Session {
    public Session() { }

    public Session(int id, int duree, Salle s, DateTime date, Formateur formateur, Formatione f) {
        this.idSession = id;
        this.duree = duree;
        this.dateDebut = date;
        this.formateur = formateur;
        this.formation = f;
        this.participants = new List<Participant>();
        this.salle = s;
    }
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int idSession { get; set; }

    public int salleId { get; set; }
    public int formateurId { get; set; }
    public int formationId { get; set; }

    public int duree { get; set; }
    public DateTime dateDebut { get; set; }

    public virtual Salle? salle { get; set; }
    public virtual ICollection<Participation>? Participations { get; set; }
    public virtual ICollection<Participant>? participants { get; set; }
    public virtual Formateur? formateur { get; set; }
    public virtual Formatione? formation { get; set; }
}