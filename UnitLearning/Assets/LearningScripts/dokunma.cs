using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dokunma : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)                           
        {
            Touch dokun = Input.GetTouch(0);
            if(dokun.phase == TouchPhase.Began)        // Bu kod sayesinde kullanýcý telefonda ekrana dokunduðunda consolda yazdýrýlýr.
            {
                Debug.Log("Kullanýcý dokundu!");
                Debug.Log("Kullanýcýnýn dokunduðu nokta : " + dokun.position);    // Bu kod ile kullanýcýnýn dokunduðu noktanýn koordinatlarýný yazdýrabiliriz.

            }


            //if (dokun.phase == TouchPhase.Stationary)   // Bu kod sayesinde kullanýcý telefonda ekrana parmaðýný basýlý tuttuðu sürece consolda yazdýrýlýr.
            //{
            //    Debug.Log("Kullanýcý basýlý tutuyor!");
            //}

            //if (dokun.phase == TouchPhase.Moved)
            //{
            //    Debug.Log("Kullanýcý parmaðýný sürüklüyor!");    // Bu kod sayesinde kullanýcý telefonda parmaðýný sürüklediðinde consolda yazdýrýlýr.
            //}

            //if (dokun.phase == TouchPhase.Ended)
            //{
            //    Debug.Log("Kullanýcý dokunmayý býraktý");        // Bu kod sayesinde kullanýcý telefondan parmaðýný çektiðinde consolda yazdýrýlýr.
            //}
        }        
    }
}
