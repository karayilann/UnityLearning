using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lists : MonoBehaviour
{
   public List<float>sayilar;                          // Listeleri bu �ekilde tan�mlar�z.
    void Start()
    {
       sayilar = new List<float>(){ };                 // Listenin elemanlar�n� s�sl� parantez i�erisinde de ekleyebiliriz.
        sayilar.Add(13.3f);
        sayilar.Add(12.8f);
        Debug.Log(sayilar[0]);                         // T�pk� dizilerdeki gibi burada da bu �ekilde �a��r�r�z.
        Debug.Log(sayilar.Count);                      // Listenin eleman say�s�n� bu �ekilde bulabiliriz.
        sayilar.RemoveAt(1);                           // Listenin elemanlar�n� bu y�ntemle index veya eleman� belirterek silebiliriz. Inspector men�s�nden kontrol edebilirsiniz.
        sayilar.Clear();                               // Bu y�ntem ile listenin t�m elemanlar�n� temizleriz.

    }
    void Update()
    {
        
    }
}
