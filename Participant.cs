
using Formation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

public class Participant : Personne {

    public Participant(int id, string n, string p, string tel, bool etat):base(n, p, tel)
    {
        this.idParticipant = id;
        this.etatPayment = etat;
    }

    private int  idParticipant;

    private bool  etatPayment;

    public int getIdParticipant()
    {
        return idParticipant;
    }


    public void setIdParticipant(int value)
    {
        idParticipant = value;
    }


    public bool getEtatPayment()
    {
        return etatPayment;
    }


    public void setEtatPayment(bool value)
    {
        etatPayment = value;
    }

    public void ajouterParticipant(List<Participant> participants) {
        participants.Add(this);
    }

    public void supprimerParticipant(List<Participant> participants) {
        participants.Remove(this);
    }

    public void modifierParticipant(Participant p) {
        this.idParticipant = p.getIdParticipant();
        this.nom = p.GetNom();
        this.prenom = p.GetPrenom();
        this.tel = p.GetTel();
        this.etatPayment = p.getEtatPayment();
    }

    public void payerFormation() {
        setEtatPayment(true);
    }

}