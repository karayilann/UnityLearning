using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volume : MonoBehaviour
{
    AudioSource audioSource;                           // Audio Source componentini �a��r�yoruz. Veisim veriyoruz.
    // public AudioClip m�zik;                                // m�zik ad�nda bir ses oldu�unu Unity'e s�yledik ve Inspector men�s�nden buraya atama yapmal�y�z.
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();      // audioSource'u game object olan Audio Source'a e�itliyoruz.
        Invoke("sesac", 3.0f);                          // Bu fonksiyon ile methodu istedi�imiz saniyede �a��r�r�z. Method ismi string, s�re ise float olmal�.
        Invoke("seskapa", 13.0f);                       // �ki fonksiyon aras�ndaki s�rede (10 sn.) ses oynat�lacak.
    }

    void sesac()
    {
        audioSource.Play();                            // Bu methot ile sesi oynatmaya ba�lar�z.
        // audioSource.PlayOneShot(m�zik);             // Bu fonksiyon ile bir defal�k oynat�r�z.
    }

    void seskapa()
    {
        audioSource.Stop();                            // Bu methot ile sesi durduruz.
    }



}
