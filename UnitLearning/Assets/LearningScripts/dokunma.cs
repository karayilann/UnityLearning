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
            if(dokun.phase == TouchPhase.Began)        // Bu kod sayesinde kullanıcı telefonda ekrana dokunduğunda consolda yazdırılır.
            {
                Debug.Log("Kullanıcı dokundu!");
                Debug.Log("Kullanıcının dokunduğu nokta : " + dokun.position);    // Bu kod ile kullanıcının dokunduğu noktanın koordinatlarını yazdırabiliriz.

            }


            //if (dokun.phase == TouchPhase.Stationary)   // Bu kod sayesinde kullanıcı telefonda ekrana parmağını basılı tuttuğu sürece consolda yazdırılır.
            //{
            //    Debug.Log("Kullanıcı basılı tutuyor!");
            //}

            //if (dokun.phase == TouchPhase.Moved)
            //{
            //    Debug.Log("Kullanıcı parmağını sürüklüyor!");    // Bu kod sayesinde kullanıcı telefonda parmağını sürüklediğinde consolda yazdırılır.
            //}

            //if (dokun.phase == TouchPhase.Ended)
            //{
            //    Debug.Log("Kullanıcı dokunmayı bıraktı");        // Bu kod sayesinde kullanıcı telefondan parmağını çektiğinde consolda yazdırılır.
            //}
        }        
    }
}
