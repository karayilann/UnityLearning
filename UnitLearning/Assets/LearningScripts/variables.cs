using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour
{
    int sayi1, sayi2;                                  // Ýnt ifade tam sayý deðerlerini tutmamýza yarar.
    public int sayi3;                                  // Public ifadesini eklememiz bizim deðiþkenlerimizi oyun içinde deðiþtirmemize yarar.
    public string metin;                               // String ifadesi text yazabilmemize imkan tanýr.
    public float sayi4, sayi5;                         // Float ifadesi ondalýklý sayýlarý tanýmlamamýzý saðlar.
    

    void Start()
    {
        sayi1 = 5;
        sayi2 = 6;
        // sayi3 = 8 ; gibi bir deðer tanýmlamasý halinde bu deðer oyun içinden deðiþtirilemez.
        
        print( sayi1 + sayi2 + sayi3 );                // Parantez içindeki iþlemin sonucunu verir.
        Debug.Log(sayi1 + sayi2 + sayi3);              // Print ile ayný iþleve sahiptir.
        Debug.LogError(sayi1 + sayi2 + sayi3);         // Burada ise çýktýyý hata olarak gösterir.
        Debug.Log(metin + "  " + sayi4 * sayi5);       // Metin çýktýsý ile birlikte sayýyý yanýna yazarak çýktý alacaðýz.


    }

    
    void Update()
    {
        
    }
}
