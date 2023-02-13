using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordthis : MonoBehaviour
{
                                                       // This kelimesi kullanýmý açýsýndan basit fakat çok önemli bir koddur.
    public int sayi = 5 ;
    public string isim = "Muhammet" ;
    void Start()
    {

        Degisken(13,"github name is = karayilann ");   // Buradaki methot ile yukarýda tanýmladýðýmýz deðiþkenlerin deðerlerini verdiðimiz parametrelere göre güncelledik.
                                                       // Baþlangýçta sayi = 5, isim = muhammet olan deðerler oyunun baþlayýnca kendini üstteki methoda göre günceller.

    }

    // Update is called once per frame
    void Degisken(int sayi, string isim)
    {
        this.sayi = sayi;                              // This.sayi = Deðiþken methodu içindeki sayi parametresidir. Eþitliðin saðýndaki sayi ise en baþtaki deðiþkendir.
        this.isim = isim;                              // This.isim = Deðiþken methodu içindeki isim parametresidir. Eþitliðin saðýndaki isim ise en baþtaki deðiþkendir.
        Debug.Log(this.isim);
        Debug.Log(this.sayi);                          // Burada çýktý alýrken this yazmamýza gerek yok aslýnda fakat bu þekilde kullanýmda farklýlýk olmayacaðýnýda gördük.
        
    }
}
