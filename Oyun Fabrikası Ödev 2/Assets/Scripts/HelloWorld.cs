using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class HelloWorld : MonoBehaviour
{
    int ilkSayi = 20;
    int ikinciSayi = 70;

    void Start()
    {
        // T�m say�lar� yazd�r
        string tumSayilar = "T�m Say�lar:";
        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            tumSayilar += " " + i;
        }
        Debug.Log(tumSayilar);

        // 2'ye tam b�l�nebilenler
        string ikiyeBolunenler = "2'ye Tam B�l�nebilen Say�lar:";
        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            if (i % 2 == 0)
                ikiyeBolunenler += " " + i;
        }
        Debug.Log(ikiyeBolunenler);

        // 3 b�l�nebilenler
        string uceBolunenler = "3'e Tam B�l�nebilen Say�lar:";
        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            if (i % 3 == 0)
                uceBolunenler += " " + i;
        }
        Debug.Log(uceBolunenler);

        // 4 b�l�nebilenler
        string dordeBolunenler = "4'e Tam B�l�nebilen Say�lar:";
        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            if (i % 4 == 0)
                dordeBolunenler += " " + i;
        }
        Debug.Log(dordeBolunenler);

        // 5 b�l�nebilinenler
        string beseBolunenler = "5'e Tam B�l�nebilen Say�lar:";
        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            if (i % 5 == 0)
                beseBolunenler += " " + i;
        }
        Debug.Log(beseBolunenler);
    }
}