using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour
{
    int sayi1, sayi2;                                  // �nt ifade tam say� de�erlerini tutmam�za yarar.
    public int sayi3;                                  // Public ifadesini eklememiz bizim de�i�kenlerimizi oyun i�inde de�i�tirmemize yarar.
    public string metin;                               // String ifadesi text yazabilmemize imkan tan�r.
    public float sayi4, sayi5;                         // Float ifadesi ondal�kl� say�lar� tan�mlamam�z� sa�lar.
    

    void Start()
    {
        sayi1 = 5;
        sayi2 = 6;
        // sayi3 = 8 ; gibi bir de�er tan�mlamas� halinde bu de�er oyun i�inden de�i�tirilemez.
        
        print( sayi1 + sayi2 + sayi3 );                // Parantez i�indeki i�lemin sonucunu verir.
        Debug.Log(sayi1 + sayi2 + sayi3);              // Print ile ayn� i�leve sahiptir.
        Debug.LogError(sayi1 + sayi2 + sayi3);         // Burada ise ��kt�y� hata olarak g�sterir.
        Debug.Log(metin + "  " + sayi4 * sayi5);       // Metin ��kt�s� ile birlikte say�y� yan�na yazarak ��kt� alaca��z.


    }

    
    void Update()
    {
        
    }
}
