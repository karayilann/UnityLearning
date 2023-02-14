using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationcodes : MonoBehaviour
{
    Animator animasyon;
    void Start()
    {

        animasyon = gameObject.GetComponent<Animator>();          // Bu kod ile oyundaki Animator componentine ula��yoruz.
        Invoke("donmeGecis", 5.0f);                    //5. saniyeden itibaren oyunda aktiflik parametresini true olacak �ekilde ayarlad�k.

    }
    
    void donmeGecis()
    {
        animasyon.SetBool("aktiflik", true);           // Bu komut ile verilen bool t�r�ndeki parametrenin de�erini ayarlayabiliriz.
    }
}
