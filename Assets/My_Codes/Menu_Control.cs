using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Control : MonoBehaviour
{

    void Start()
    {
        // PlayerPrefs.DeleteAll(); bu kayýt silmeyi bir kere çalýþtýrýp kayýtlarýmýýzn hepsini sildirip sonra yorum satýrý yapmalýyýz
        // oyunu kontrol amaçlý yazdýk asla build ederken yorum satýrý yapmadan build etmeyin
    }

    public void OyunaBasla()
    {
        int kayitlilevel = PlayerPrefs.GetInt("kayit");

        if (kayitlilevel == 0)
        {
            SceneManager.LoadScene(kayitlilevel+1);
        }
        else
        {
            SceneManager.LoadScene(kayitlilevel);
        }
    }

    public void OyundanCik()
    {
        Application.Quit();
    }
}
