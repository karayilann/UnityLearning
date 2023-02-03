using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class methods : MonoBehaviour
{
    int rakam1 = 25;
    int rakam2 = 35;
    string adi = "muhammet";
    string soyadi = " karayilan ";

    void Start()
    {
        method1();
        method2(25, 35);                               // Bu þekilde doðrudan sayýlarý yazabiliriz.
        method2(rakam2, rakam1);                       // 2. yöntem olarak deðiþken adýný parametre olarak veririz.
        Debug.Log(method3());                          // Geri dönüþümlü methodlar Debug.Log içinde yazýlýr.
        Debug.Log(method4(adi, soyadi));
        Debug.Log(method4("muhammet", "karayilann"));
    }
    void Update()
    {
        
    }
    // Geri dönüþümsüz, parametresiz method
    void method1()
    {
        Debug.Log("Muhammet"); // Bu methotlarý çalýþtýrmak için çaðýrmak gerekir.
    }
    //Geri dönüþümsüz, parametreli method
    void method2(int sayi1, int sayi2) // Bu methodu çaðýrýrken parametrede belirtmeliyiz.
    {
        int toplam = sayi1 + sayi2; // Parametre fonksiyonun bizden istediði deðerlerdir. Debug.Log içine yazdýklarýmýz misali
        Debug.Log(toplam);
    }
    // Geri dönüþümlü, parametresiz method
    string method3() // Bu methodda çýktý almak için return kullanýlýr.
    {
        string metin = "method3 çalýþtý";
        return metin;
    }
    string method4(string ad, string soyad)
    {
        string isim = ad + " " + soyad ;
        return isim;
    }

    // Void dönüþümsüz bir ifadedir. Bu nedenle dönüþümlü methodlarda kullanýlmaz.
}