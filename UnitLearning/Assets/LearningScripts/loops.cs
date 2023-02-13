using UnityEngine;

public class loops : MonoBehaviour
{

    void Start()
    {
        //for (int number = 1; number <= 10; number++)    // Sýrasýyla deðiþken, þart ve artýþ miktarýný yazdýk.
        //{
        //    Debug.Log(number);                         // Þartý saðlayan son deðerin çýktýsýný almak istedik.
        //    if (number == 8)                            // Döngüyü 8 e gelince durdurmasýný istedik.
        //    {
        //        break;                                 // Bu komuttan sonra blokta kalan kodlar çalýþmayý durdurur.
        //    }
        //}

        int a = 1;
        while (a < 30)
        {
            int kalan = a % 2;                        // Mod iþlemini kullanarak bir deðiþken oluþturduk.
            if (kalan == 0)                          // Bu deðiþken ile þartýmýzý sunduk.
            {
                Debug.Log(a);                          // Bu þartý saðlayan sayýlarý yazdýrmasýný istedik.
            }
        }


    }


    void Update()
    {

    }
}
