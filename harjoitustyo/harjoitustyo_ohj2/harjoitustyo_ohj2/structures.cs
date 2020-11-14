using System;
using System.Collections.Generic;
using System.Windows.Forms;
/*
 * 
 * Serializable vaadittiin structeihin, jotta BinaryFormatter toimisi 
 * 
 * */
[Serializable]
public struct Henkilo {
    public string[] etunimet;
    public string sukunimi, kutsumanimi, henkilotunnus;
    public string katuosoite, postinumero, postitoimipaikka;
    public List<Toimisuhde> toimisuhteet;
    public string Etunimet
    {
        get
        {
            string nimet = "";
            foreach (string nimi in etunimet)
            {
                nimet += nimi+" ";
            }
            return nimet;
        }
    }
    public string Kutsumanimi
    {
        get
        {
            return kutsumanimi;
        }
    }
    public string Sukunimi
    {
        get
        {
            return sukunimi;
        }
    }
    public string Henkilötunnus
    {
        get
        {
            return henkilotunnus;
        }
    }
    public string Postinumero
    {
        get
        {
            return postinumero;
        }
    }
    public string Postitoimipaikka
    {
        get
        {
            return postitoimipaikka;
        }
    }
}
[Serializable]
public struct Toimisuhde
{
    public string alkamispaiva, paattymispaiva;
    public string nimike, yksikko;
    public string Nimike
    {
        get {
            return nimike;
        }
    }
    public string Yksikko
    {
        get {
            return yksikko;
        }
    }
    public string Alkamispaiva
    {
        get
        {
            return alkamispaiva;
        }
    }
    public string Paattymispaiva
    {
        get
        {
            return paattymispaiva;
        }
    }
}

/* 
 * Loki strukti, jolla voidaan tehdä kivemmin näkösesti lokientry, ja jota voi käyttää myöhemmin jossain (?)
 */
public struct LokiRivi
{
    public string kuka, tietotyyppi, tieto;
    public DateTime milloin;
    public override string ToString()
    {
        return tietotyyppi+":"+tieto+"\t"+kuka+"\t"+milloin.ToString("dd-MM-yyyy HH:mm:ss");
    }
    public void stringToStruct(string merkkijono)
    {
        string[] lista_1 = merkkijono.Split('\t');
        string[] lista_2 = lista_1[0].Split(':');
        tietotyyppi = lista_2[0];
        tieto = lista_2[1];
        kuka = lista_1[1];
        milloin = DateTime.Parse(lista_1[2]);
    }
}