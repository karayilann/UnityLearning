using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forechloops : MonoBehaviour
{
    public float[] sayilar;  
    void Start()
    {
        sayilar = new float[] {13.2f,15.8f};
        //for (int i = 0; i < sayilar.Length; i++)
        //{
        //    Debug.Log(sayilar[i]);
        //}

        foreach(float i in sayilar)                    // Foreach'i forda kulland���m�z �ekilde anlatmaya �al��t�m.
        {
            Debug.Log(i);
        }

    }

    void Update()
    {
        
    }
}
