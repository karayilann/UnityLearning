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
        method2(25, 35);                               // Bu �ekilde do�rudan say�lar� yazabiliriz.
        method2(rakam2, rakam1);                       // 2. y�ntem olarak de�i�ken ad�n� parametre olarak veririz.
        Debug.Log(method3());                          // Geri d�n���ml� methodlar Debug.Log i�inde yaz�l�r.
        Debug.Log(method4(adi, soyadi));
        Debug.Log(method4("muhammet", "karayilann"));
    }
    void Update()
    {
        
    }
    // Geri d�n���ms�z, parametresiz method
    void method1()
    {
        Debug.Log("Muhammet"); // Bu methotlar� �al��t�rmak i�in �a��rmak gerekir.
    }
    //Geri d�n���ms�z, parametreli method
    void method2(int sayi1, int sayi2) // Bu methodu �a��r�rken parametrede belirtmeliyiz.
    {
        int toplam = sayi1 + sayi2; // Parametre fonksiyonun bizden istedi�i de�erlerdir. Debug.Log i�ine yazd�klar�m�z misali
        Debug.Log(toplam);
    }
    // Geri d�n���ml�, parametresiz method
    string method3() // Bu methodda ��kt� almak i�in return kullan�l�r.
    {
        string metin = "method3 �al��t�";
        return metin;
    }
    string method4(string ad, string soyad)
    {
        string isim = ad + " " + soyad ;
        return isim;
    }

    // Void d�n���ms�z bir ifadedir. Bu nedenle d�n���ml� methodlarda kullan�lmaz.
}