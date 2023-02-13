using UnityEngine;

public class series : MonoBehaviour
{
    public string[] diziler;                           // ' [ ] ' diðer string deðiþkenlerden farklý olmasýný saðlar.

    void Start()
    {
        diziler = new string[2];                       // Bu kodda kaç tane eleman ekleyeceðimizi yazýyoruz. Elemanlarý ve sayýsýný hem unity içerisinden hemde scriptten deðiþtirebiliriz.
        diziler[0] = "Muhammet";
        diziler[1] = "Karayýlan";                      // Script içerisinden bu þekilde ekliyoruz. Start() methodunun çalýþmasý ile inspector menüsünde görünecek. 


        diziler[0] = null;                             // Bu þekilde dizinin elemanlarýný silebiliriz.

        Debug.Log("Adý : " + diziler[0]);
        Debug.Log("Soyadý : " + diziler[1]);
        Debug.Log("Dizideki eleman sayýsý : " + diziler.Length); // Bu kod ile dizide bulunan eleman sayýsýný yazdýrabiliriz.
        

    }

    void Update()
    {

    }
}
