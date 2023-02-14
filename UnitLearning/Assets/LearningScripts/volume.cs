using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volume : MonoBehaviour
{
    AudioSource audioSource;                           // Audio Source componentini çaðýrýyoruz. Veisim veriyoruz.
    // public AudioClip müzik;                                // müzik adýnda bir ses olduðunu Unity'e söyledik ve Inspector menüsünden buraya atama yapmalýyýz.
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();      // audioSource'u game object olan Audio Source'a eþitliyoruz.
        Invoke("sesac", 3.0f);                          // Bu fonksiyon ile methodu istediðimiz saniyede çaðýrýrýz. Method ismi string, süre ise float olmalý.
        Invoke("seskapa", 13.0f);                       // Ýki fonksiyon arasýndaki sürede (10 sn.) ses oynatýlacak.
    }

    void sesac()
    {
        audioSource.Play();                            // Bu methot ile sesi oynatmaya baþlarýz.
        // audioSource.PlayOneShot(müzik);             // Bu fonksiyon ile bir defalýk oynatýrýz.
    }

    void seskapa()
    {
        audioSource.Stop();                            // Bu methot ile sesi durduruz.
    }



}
