using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stroika2 : MonoBehaviour
{
    public GameObject[] domiki;
    public GameObject plaer;
    public bool dom= false;
    public int i;

    public void Start()
    {

        if (plaer == null)
        {
            plaer = GameObject.Find("hero");
        }
    }
    // Use this for initialization
    public void OnMouseDown()
    {
        
        
        if (dom == false)

            Instantiate(domiki[i]);
            domiki[i].transform.position = plaer.transform.position;
            plaer.GetComponent<hero>().dom = true;
            
        
    }
}
	

