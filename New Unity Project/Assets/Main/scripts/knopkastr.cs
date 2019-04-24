using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knopkastr : MonoBehaviour
{
    public int str100;
    public GameObject kletka2;

    private void Start()
    {
       
    }

    void OnMouseDown()
    {
        if (str100 == 0)
        {
            str100 = 1;
         
        }

    }

}

