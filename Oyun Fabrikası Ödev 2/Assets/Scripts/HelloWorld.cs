using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class HelloWorld : MonoBehaviour
{
    int ilkSayi = 20;
    int ikinciSayi = 70;

    void Start()
    {
        // Tüm sayýlarý yazdýr
        string tumSayilar = "Tüm Sayýlar:";
        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            tumSayilar += " " + i;
        }
        Debug.Log(tumSayilar);

        // 2'ye tam bölünebilenler
        string ikiyeBolunenler = "2'ye Tam Bölünebilen Sayýlar:";
        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            if (i % 2 == 0)
                ikiyeBolunenler += " " + i;
        }
        Debug.Log(ikiyeBolunenler);

        // 3 bölünebilenler
        string uceBolunenler = "3'e Tam Bölünebilen Sayýlar:";
        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            if (i % 3 == 0)
                uceBolunenler += " " + i;
        }
        Debug.Log(uceBolunenler);

        // 4 bölünebilenler
        string dordeBolunenler = "4'e Tam Bölünebilen Sayýlar:";
        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            if (i % 4 == 0)
                dordeBolunenler += " " + i;
        }
        Debug.Log(dordeBolunenler);

        // 5 bölünebilinenler
        string beseBolunenler = "5'e Tam Bölünebilen Sayýlar:";
        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            if (i % 5 == 0)
                beseBolunenler += " " + i;
        }
        Debug.Log(beseBolunenler);
    }
}