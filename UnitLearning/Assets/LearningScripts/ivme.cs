using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ivme : MonoBehaviour
{
    public float ivmedeger;                            // �vme de�erlerini kontrol etmek i�in
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ivmex = Input.acceleration.x;
        float ivmey = Input.acceleration.y;

        gameObject.transform.Translate(ivmex*ivmedeger,ivmey*ivmedeger,0);
    }
}
