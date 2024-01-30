﻿namespace DenemeTreeView.Shared;


public class KategoriListesiBilgileri
{
    public string id { get; set; }
    public string kategoriustid { get; set; }
    public string kategoriadi { get; set; } = "";
    public bool altKategorisiVar { get; set; }
    public bool genislet { get; set; }
    public int kategorialtid { get; set; }
    public string kategorikod { get; set; } = "";
    public string NavigationUrl { get; set; }
    public int kategoristokbaglanabilir { get; set; }
    public int kategoristokvar { get; set; }
    public string kategoriNo { get; set; }
    public int kategoriaktif { get; set; }
    public bool aktif
    {
        get
        {
            if(kategoriaktif == 0)
                return false;
            else
                return true;
        }
        set
        {
            if(value)
            {
                kategoriaktif = 1;
            }
            else
            {
                kategoriaktif = 0;
            }
        }
    }
    public KategoriListesiBilgileri()
    {
        this.kategoriustid = "0";
        this.NavigationUrl = "";
        this.kategoriadi = "";
        this.altKategorisiVar = false;
        this.genislet = false;
        this.kategorialtid = 0;
        this.kategorikod = "";
        this.kategoristokbaglanabilir = 0;
        this.kategoristokvar = 0;
        this.kategoriaktif = 0;
        this.kategoriNo = "";
    }
    public KategoriListesiBilgileri Copy(KategoriListesiBilgileri klb)
    {
        this.id = klb.id;
        this.kategoriustid = klb.kategoriustid;
        this.kategoriadi = klb.kategoriadi;
        this.altKategorisiVar = klb.altKategorisiVar;
        this.genislet = klb.genislet;
        this.kategorialtid = klb.kategorialtid;
        this.kategorikod = klb.kategorikod;
        this.kategoristokbaglanabilir = klb.kategoristokbaglanabilir;
        this.kategoristokvar = klb.kategoristokvar;
        this.kategoriaktif = klb.kategoriaktif;
        this.kategoriNo = klb.kategoriNo;
        return this;
    }
}

