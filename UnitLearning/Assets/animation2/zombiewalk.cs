using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiewalk : MonoBehaviour
{
    Animator walking;
    void Start()
    {
        walking = gameObject.GetComponent<Animator>();

        

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.W))                   // W tuþuna basarak yürüme animasyonunu aktif eder.
        {
            walking.SetBool("walking", true);
        }
    }

}