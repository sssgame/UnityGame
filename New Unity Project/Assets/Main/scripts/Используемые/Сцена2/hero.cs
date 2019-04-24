using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{
    public int st = 0;
    public int x = 0;
    public int y = 0;
    public int step = 7; //Кол-во шагов, оставшихся у героя
    public float shag;
    public GameObject pocemon;
    public GameObject pocemon2;
    public string kletka;


    public void Awake()
    {
        if (pocemon == null)
        {
            pocemon = GameObject.FindWithTag("pocemon");
        }
        if (pocemon2 == null)
        {
            pocemon2 = GameObject.FindWithTag("pocemon2");
        }
    }

    public void Update()
    {
        shag = Vector3.Distance(pocemon.transform.position, pocemon2.transform.position) + 1;

    }
}
