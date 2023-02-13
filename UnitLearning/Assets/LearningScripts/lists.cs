using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lists : MonoBehaviour
{
   public List<float>sayilar;                          // Listeleri bu þekilde tanýmlarýz.
    void Start()
    {
       sayilar = new List<float>(){ };                 // Listenin elemanlarýný süslü parantez içerisinde de ekleyebiliriz.
        sayilar.Add(13.3f);
        sayilar.Add(12.8f);
        Debug.Log(sayilar[0]);                         // Týpký dizilerdeki gibi burada da bu þekilde çaðýrýrýz.
        Debug.Log(sayilar.Count);                      // Listenin eleman sayýsýný bu þekilde bulabiliriz.
        sayilar.RemoveAt(1);                           // Listenin elemanlarýný bu yöntemle index veya elemaný belirterek silebiliriz. Inspector menüsünden kontrol edebilirsiniz.
        sayilar.Clear();                               // Bu yöntem ile listenin tüm elemanlarýný temizleriz.

    }
    void Update()
    {
        
    }
}
