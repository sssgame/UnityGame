using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stroika2 : MonoBehaviour
{
    public GameObject[] domiki;
    public GameObject hero;
    public int dom = 1;
    public int i;

    public void Start()
    {

        if (hero == null)
        {
            hero = GameObject.Find("hero");
        }
    }
    // Use this for initialization
    public void OnMouseDown()
    {
        Instantiate(domiki[i]);
        domiki[i].transform.position = hero.transform.position;
        i++;
    }
}
	

