
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

    

}