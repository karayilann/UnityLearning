using UnityEngine;

public class loops : MonoBehaviour
{

    void Start()
    {
        //for (int number = 1; number <= 10; number++)    // S�ras�yla de�i�ken, �art ve art�� miktar�n� yazd�k.
        //{
        //    Debug.Log(number);                         // �art� sa�layan son de�erin ��kt�s�n� almak istedik.
        //    if (number == 8)                            // D�ng�y� 8 e gelince durdurmas�n� istedik.
        //    {
        //        break;                                 // Bu komuttan sonra blokta kalan kodlar �al��may� durdurur.
        //    }
        //}

        int a = 1;
        while (a < 30)
        {
            int kalan = a % 2;                        // Mod i�lemini kullanarak bir de�i�ken olu�turduk.
            if (kalan == 0)                          // Bu de�i�ken ile �art�m�z� sunduk.
            {
                Debug.Log(a);                          // Bu �art� sa�layan say�lar� yazd�rmas�n� istedik.
            }
        }


    }


    void Update()
    {

    }
}
