using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordthis : MonoBehaviour
{
                                                       // This kelimesi kullan�m� a��s�ndan basit fakat �ok �nemli bir koddur.
    public int sayi = 5 ;
    public string isim = "Muhammet" ;
    void Start()
    {

        Degisken(13,"github name is = karayilann ");   // Buradaki methot ile yukar�da tan�mlad���m�z de�i�kenlerin de�erlerini verdi�imiz parametrelere g�re g�ncelledik.
                                                       // Ba�lang��ta sayi = 5, isim = muhammet olan de�erler oyunun ba�lay�nca kendini �stteki methoda g�re g�nceller.

    }

    // Update is called once per frame
    void Degisken(int sayi, string isim)
    {
        this.sayi = sayi;                              // This.sayi = De�i�ken methodu i�indeki sayi parametresidir. E�itli�in sa��ndaki sayi ise en ba�taki de�i�kendir.
        this.isim = isim;                              // This.isim = De�i�ken methodu i�indeki isim parametresidir. E�itli�in sa��ndaki isim ise en ba�taki de�i�kendir.
        Debug.Log(this.isim);
        Debug.Log(this.sayi);                          // Burada ��kt� al�rken this yazmam�za gerek yok asl�nda fakat bu �ekilde kullan�mda farkl�l�k olmayaca��n�da g�rd�k.
        
    }
}
