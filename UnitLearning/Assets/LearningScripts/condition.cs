using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condition : MonoBehaviour
{
    public bool muhammet;
    public bool karayilann;

    void Start()
    {
        if (muhammet)  // Doðru ise koþulu yapar.
        {
            Debug.Log("Koþul doðru durum gerçekleþti.");
        }
        
        else if (karayilann) // If koþulu saðlanamazsa elseden önce else if bloðu kontrol edilir.
        {
            Debug.Log("2.Koþul gerçekleþti.");
        }
       
        else
        {
            Debug.Log("2 farklý koþulda saðlanamadý."); // if, else if gerçekleþmezse else bloðu çalýþtýrýlýr.
        }
        
        if (!muhammet)
        {
            Debug.Log(" 2. if bloðu çalýþtý."); // Baþýna ünlem konulan ifade belirttiði durumun aksini ifade eder.
        }
    
        // Yukarýda yazdýðýmýz kodda tüm koþullar saðlanamazsa iki çýktý alýrýz. Bunlar else ve 2.if bloklarý olur.

    }

    
    void Update()
    {
        
    }
}
