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
            if(dokun.phase == TouchPhase.Began)        // Bu kod sayesinde kullan�c� telefonda ekrana dokundu�unda consolda yazd�r�l�r.
            {
                Debug.Log("Kullan�c� dokundu!");
                Debug.Log("Kullan�c�n�n dokundu�u nokta : " + dokun.position);    // Bu kod ile kullan�c�n�n dokundu�u noktan�n koordinatlar�n� yazd�rabiliriz.

            }


            //if (dokun.phase == TouchPhase.Stationary)   // Bu kod sayesinde kullan�c� telefonda ekrana parma��n� bas�l� tuttu�u s�rece consolda yazd�r�l�r.
            //{
            //    Debug.Log("Kullan�c� bas�l� tutuyor!");
            //}

            //if (dokun.phase == TouchPhase.Moved)
            //{
            //    Debug.Log("Kullan�c� parma��n� s�r�kl�yor!");    // Bu kod sayesinde kullan�c� telefonda parma��n� s�r�kledi�inde consolda yazd�r�l�r.
            //}

            //if (dokun.phase == TouchPhase.Ended)
            //{
            //    Debug.Log("Kullan�c� dokunmay� b�rakt�");        // Bu kod sayesinde kullan�c� telefondan parma��n� �ekti�inde consolda yazd�r�l�r.
            //}
        }        
    }
}
