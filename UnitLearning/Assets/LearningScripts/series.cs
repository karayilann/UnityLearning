using UnityEngine;

public class series : MonoBehaviour
{
    public string[] diziler;                           // ' [ ] ' di�er string de�i�kenlerden farkl� olmas�n� sa�lar.

    void Start()
    {
        diziler = new string[2];                       // Bu kodda ka� tane eleman ekleyece�imizi yaz�yoruz. Elemanlar� ve say�s�n� hem unity i�erisinden hemde scriptten de�i�tirebiliriz.
        diziler[0] = "Muhammet";
        diziler[1] = "Karay�lan";                      // Script i�erisinden bu �ekilde ekliyoruz. Start() methodunun �al��mas� ile inspector men�s�nde g�r�necek. 


        diziler[0] = null;                             // Bu �ekilde dizinin elemanlar�n� silebiliriz.

        Debug.Log("Ad� : " + diziler[0]);
        Debug.Log("Soyad� : " + diziler[1]);
        Debug.Log("Dizideki eleman say�s� : " + diziler.Length); // Bu kod ile dizide bulunan eleman say�s�n� yazd�rabiliriz.
        

    }

    void Update()
    {

    }
}
