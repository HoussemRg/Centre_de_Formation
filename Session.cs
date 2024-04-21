
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Session {

    public Session(int id,int duree,Salle s,DateTime date,Formateur formateur,Formatione f) {
        this.idSession=id;
        this.duree=duree;
        this.dateDebut = date;
        this.formateur = formateur;
        this.formation = f;
        this.participants = new List<Participant>();
        this.salle = s;
    }

    private int idSession;

    private int duree;
    private Salle salle;
    private DateTime dateDebut;
    private List<Participant> participants;
    private Formateur formateur;
    private Formatione formation;

    public int getIdSession()
    {
        return idSession;
    }
    public void setIdSession(int idSession)
    {
        this.idSession = idSession;
    }

    public int getDuree()
    {
        return duree;
    }

    public void setDuree(int duree)
    {
        this.duree = duree;
    }
    public Salle getSalle()
    {
        return salle;
    }

    public void setSalle(Salle s) 
    {
        this.salle = s;
    }

    public DateTime getDateDebut()
    {
        return dateDebut;
    }

    public void setDateDebut(DateTime dateDebut)
    {
        this.dateDebut = dateDebut;
    }

    public List<Participant> getParticipants()
    {
        return participants;
    }
    public void setParticipants(List<Participant> participants)
    {
        this.participants = participants;
    }

    public Formateur getFormateur()
    {
        return formateur;
    }

    public void setFormateur(Formateur formateur)
    {
        this.formateur = formateur;
    }

    public Formatione getFormation()
    {
        return formation;
    }

    public void setFormation(Formatione formation)
    {
        this.formation = formation;
    }
    

}