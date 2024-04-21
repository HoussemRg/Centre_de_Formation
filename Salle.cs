
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Salle {

    public Salle(int n,string d) {
        this.numSalle = n;
        this.depatement = d;
    }

    private int numSalle;

    private string depatement;

    public int getNumSalle()
    {
        return numSalle;
    }


    public void setNumSalle(int n)
    {
        numSalle = n;
    }

    public string getDepartements()
    {
        return depatement;
    }


    public void setDepartement(string d)
    {
        depatement = d;
    }
   

}