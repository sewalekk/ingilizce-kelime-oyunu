using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ilk : MonoBehaviour
{
    public GameObject soru1, yanlis, soru2, soru3, soru4, soru5, soru6, soru7, soru8, soru9, soru10, soru11,soru12;

    public void yanlisCevap1()
    {
        soru1.SetActive(false);
        yanlis.SetActive(true);

    }
    public void yenidenDene1()
    {
        soru1.SetActive(true);
        yanlis.SetActive(false);
 }
    public void soru1dogru()
    {
        soru1.SetActive(false);
        soru2.SetActive(true);
    }

    public void soru2dogru()
    {
        soru2.SetActive(false);
        soru3.SetActive(true);
    }

    public void yanlisCevap2()
    {
        soru2.SetActive(false);
        yanlis.SetActive(true);

    }

    public void yenidenDene2()
    {
        soru2.SetActive(true);
        yanlis.SetActive(false);
    }

    public void soru3dogru()
    {
        soru3.SetActive(false);
        soru4.SetActive(true);
    }

    public void yanlisCevap3()
    {
        soru3.SetActive(false);
        yanlis.SetActive(true);

    }

    public void yenidenDene3()
    {
        soru3.SetActive(true);
        yanlis.SetActive(false);
    }




    public void soru4dogru()
    {
        soru4.SetActive(false);
        soru5.SetActive(true);
    }

    public void yanlisCevap4()
    {
        soru4.SetActive(false);
        yanlis.SetActive(true);

    }

    public void yenidenDene4()
    {
        soru4.SetActive(true);
        yanlis.SetActive(false);
    }


    public void soru5dogru()
    {
        soru5.SetActive(false);
        soru6.SetActive(true);
    }

    public void yanlisCevap5()
    {
        soru5.SetActive(false);
        yanlis.SetActive(true);

    }

    public void yenidenDene5()
    {
        soru5.SetActive(true);
        yanlis.SetActive(false);
    }



    public void soru6dogru()
    {
        soru6.SetActive(false);
        soru7.SetActive(true);
    }

    public void yanlisCevap6()
    {
        soru6.SetActive(false);
        yanlis.SetActive(true);

    }

    public void yenidenDene6()
    {
        soru6.SetActive(true);
        yanlis.SetActive(false);
    }

    public void soru7dogru()
    {
        soru7.SetActive(false);
        soru8.SetActive(true);
    }

    public void yanlisCevap7()
    {
        soru7.SetActive(false);
        yanlis.SetActive(true);

    }

    public void yenidenDene7()
    {
        soru7.SetActive(true);
        yanlis.SetActive(false);
    }

    public void soru8dogru()
    {
        soru8.SetActive(false);
        soru9.SetActive(true);
    }

    public void yanlisCevap8()
    {
        soru8.SetActive(false);
        yanlis.SetActive(true);

    }

    public void yenidenDene8()
    {
        soru8.SetActive(true);
        yanlis.SetActive(false);
    }

    public void soru9dogru()
    {
        soru9.SetActive(false);
        soru10.SetActive(true);
    }

    public void yanlisCevap9()
    {
        soru9.SetActive(false);
        yanlis.SetActive(true);

    }

    public void yenidenDene9()
    {
        soru9.SetActive(true);
        yanlis.SetActive(false);
    }


    public void soru10dogru()
    {
        soru10.SetActive(false);
        soru11.SetActive(true);
    }

    public void yanlisCevap10()
    {
        soru10.SetActive(false);
        yanlis.SetActive(true);

    }

    public void yenidenDene10()
    {
        soru10.SetActive(true);
        yanlis.SetActive(false);
    }

    public void soru11dogru()
    {
        soru11.SetActive(false);
        soru12.SetActive(true);
    }

    public void yanlisCevap11()
    {
        soru11.SetActive(false);
        yanlis.SetActive(true);

    }

    public void yenidenDene11()
    {
        soru11.SetActive(true);
        yanlis.SetActive(false);
    }
}
