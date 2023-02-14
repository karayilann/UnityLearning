using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationcodes : MonoBehaviour
{
    Animator animasyon;
    void Start()
    {

        animasyon = gameObject.GetComponent<Animator>();          // Bu kod ile oyundaki Animator componentine ulaþýyoruz.
        Invoke("donmeGecis", 5.0f);                    //5. saniyeden itibaren oyunda aktiflik parametresini true olacak þekilde ayarladýk.

    }
    
    void donmeGecis()
    {
        animasyon.SetBool("aktiflik", true);           // Bu komut ile verilen bool türündeki parametrenin deðerini ayarlayabiliriz.
    }
}
