using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class str1 : MonoBehaviour
{
    public GameObject str10;
    public GameObject str20;
    public GameObject str30;
    public GameObject les;
    public GameObject meln;
    public GameObject kamen;
    public AudioClip stuk;
    int i;
    int i1;
    private void Start()
    {
        if (str10 == null)
        {
            str10 = GameObject.Find("mill_brick");
        }
        if (les == null)
        {
            les = GameObject.Find("les");
        }
        if (meln == null)
        {
            meln = GameObject.Find("meln");
        }
        if (kamen == null)
        {
            kamen = GameObject.Find("kamen");
        }
        if (str20 == null)
        {
            str20 = GameObject.Find("mine");
        }
        if (str30 == null)
        {
            str30 = GameObject.Find("windmill_complete");


        }
        i = 0;
    }
    void OnMouseDown()
    {
        if ((str20.GetComponent<strS>().str100 == 2) && i == 0)
        {
            Instantiate(kamen);
            kamen.transform.position = this.transform.position;
            str20.GetComponent<strS>().str100 = i1;
            str20.GetComponent<strS>().str100 = 0;
            GetComponent<AudioSource>().PlayOneShot(stuk);

            i++;

        }
        else
        {
            if ((str10.GetComponent<strD>().str100 == 1) && i == 0)
            {
                Instantiate(les);
                les.transform.position = this.transform.position;
                str10.GetComponent<strD>().str100 = 0;
                GetComponent<AudioSource>().PlayOneShot(stuk);
                i++;

            }
            else
            {
                if ((str30.GetComponent<strM>().str1001 == 3) && i == 0)
                {
                    Instantiate(meln);
                    meln.transform.position = this.transform.position;
                    str30.GetComponent<strM>().str1001 = 0;
                    GetComponent<AudioSource>().PlayOneShot(stuk);
                    i++;

                }
                else
                {

                }
            }
        }
    }
}

