using System;
public struct Poissaolo
{
    public string syy;
    public DateTime alkaa, paattyy;
    public string Alkaa
    {
        get
        {
            return alkaa.ToString("dd.MM.yyyy");
        }
    }
    public string Päättyy
    {
        get
        {
            return paattyy.ToString("dd.MM/yyyy");
        }
    }
    public string Syy
    {
        get
        {
            return syy;
        }
    }
    public int Vuorokausia
    {
        get
        {
            return (int)paattyy.Subtract(alkaa).TotalDays;
        }
    }
}