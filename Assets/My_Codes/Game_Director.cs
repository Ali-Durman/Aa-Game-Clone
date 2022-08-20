using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Director : MonoBehaviour
{
    GameObject Donencember;
    GameObject Anacember;
    public Animator animator;
    public Text CurrentLevel;
    public Text Bir;
    public Text Iki;
    public Text Uc;
    public int kactanemermiolsun;
    bool kontrol = true;

    void Start()
    {
        Donencember = GameObject.FindGameObjectWithTag("Spinning_Circle_Tag");
        Anacember = GameObject.FindGameObjectWithTag("Main_Circle");
        CurrentLevel.text = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetInt("kayit", int.Parse(SceneManager.GetActiveScene().name));

        if (kactanemermiolsun<2)
        {
            Bir.text = kactanemermiolsun + "";
        }
        else if (kactanemermiolsun<3)
        {
            Bir.text = kactanemermiolsun + "";
            Iki.text = (kactanemermiolsun - 1) + "";
        }
        else
        {
            Bir.text = kactanemermiolsun + "";
            Iki.text = (kactanemermiolsun-1) + "";
            Uc.text = (kactanemermiolsun-2) + "";
        }
    }

    public void SmallCircleShowText()
    {
        kactanemermiolsun--;
        if (kactanemermiolsun < 2)
        {
            Bir.text = kactanemermiolsun + "";
            Iki.text = "";
            Uc.text = "";
        }
        else if (kactanemermiolsun < 3)
        {
            Bir.text = kactanemermiolsun + "";
            Iki.text = (kactanemermiolsun - 1) + "";
            Uc.text = "";
        }
        else
        {
            Bir.text = kactanemermiolsun + "";
            Iki.text = (kactanemermiolsun - 1) + "";
            Uc.text = (kactanemermiolsun - 2) + "";
        }
        if (kactanemermiolsun == 0)
        {
            StartCoroutine(YeniLevel());
        }
    }


    IEnumerator YeniLevel()
    {
        Donencember.GetComponent<Spinning>().enabled = false;
        Anacember.GetComponent<Main_Cricle>().enabled = false;
        yield return new WaitForSeconds(1);
        if (kontrol)
        {
            animator.SetTrigger("yenilevel");
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1);
        }
    }

    public void OyunBitti()
    {
        StartCoroutine(CagrilanMetot());
    }

    IEnumerator CagrilanMetot ()
    {
        Donencember.GetComponent<Spinning>().enabled = false;
        Anacember.GetComponent<Main_Cricle>().enabled = false;
        animator.SetTrigger("oyunbitti");
        kontrol = false;

        yield return new WaitForSeconds(1.5f);

        SceneManager.LoadScene("Main_Menu");
    }
}
