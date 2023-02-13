using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class littlethings : MonoBehaviour
{
    // Bir deðiþkenin deðerlerini arttýrma ve azaltma yöntemleri
    public int a = 3;
    public int b = 0;
    public int c = 3;
    public int d = 0;

    void Start()
    {
        //a++;                                         // Bu þekilde sayýnýn deðeri 1 artar.
        //++a;                                         // Bu þekilde de sayýnýn deðeri 1 artar.
        // a += 2 ;                                    // Bu þekilde sayýya 2 ekleriz.

        
        print(a);
        print(b);

        // Bu iki methodun farkýný aþaðýdaki örnekte görelim. Console'den deðil inspector menüsünden bakýnýz.
        b = a++;
        d = ++c;
        print(c);
        print(d);
                                                       // Aldýðýmýz çýktý sonucunda b = 3, d = 4, olduðunu gördük.
                                                       //Bu sonucun sebebi kodda b yi a nýn ilk hali olan 3 e eþitledikten sonra a yý arttýrdýk. d de ise önce c yi arttýrdýk ardýndan d ye eþitledik.
    
    }

    void Update()
    {
        
    }
}
