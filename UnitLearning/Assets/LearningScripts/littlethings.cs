using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class littlethings : MonoBehaviour
{
    // Bir de�i�kenin de�erlerini artt�rma ve azaltma y�ntemleri
    public int a = 3;
    public int b = 0;
    public int c = 3;
    public int d = 0;

    void Start()
    {
        //a++;                                         // Bu �ekilde say�n�n de�eri 1 artar.
        //++a;                                         // Bu �ekilde de say�n�n de�eri 1 artar.
        // a += 2 ;                                    // Bu �ekilde say�ya 2 ekleriz.

        
        print(a);
        print(b);

        // Bu iki methodun fark�n� a�a��daki �rnekte g�relim. Console'den de�il inspector men�s�nden bak�n�z.
        b = a++;
        d = ++c;
        print(c);
        print(d);
                                                       // Ald���m�z ��kt� sonucunda b = 3, d = 4, oldu�unu g�rd�k.
                                                       //Bu sonucun sebebi kodda b yi a n�n ilk hali olan 3 e e�itledikten sonra a y� artt�rd�k. d de ise �nce c yi artt�rd�k ard�ndan d ye e�itledik.
    
    }

    void Update()
    {
        
    }
}
