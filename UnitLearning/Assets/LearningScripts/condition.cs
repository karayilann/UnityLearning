using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condition : MonoBehaviour
{
    public bool muhammet;
    public bool karayilann;

    void Start()
    {
        if (muhammet)  // Do�ru ise ko�ulu yapar.
        {
            Debug.Log("Ko�ul do�ru durum ger�ekle�ti.");
        }
        
        else if (karayilann) // If ko�ulu sa�lanamazsa elseden �nce else if blo�u kontrol edilir.
        {
            Debug.Log("2.Ko�ul ger�ekle�ti.");
        }
       
        else
        {
            Debug.Log("2 farkl� ko�ulda sa�lanamad�."); // if, else if ger�ekle�mezse else blo�u �al��t�r�l�r.
        }
        
        if (!muhammet)
        {
            Debug.Log(" 2. if blo�u �al��t�."); // Ba��na �nlem konulan ifade belirtti�i durumun aksini ifade eder.
        }
    
        // Yukar�da yazd���m�z kodda t�m ko�ullar sa�lanamazsa iki ��kt� al�r�z. Bunlar else ve 2.if bloklar� olur.

    }

    
    void Update()
    {
        
    }
}
