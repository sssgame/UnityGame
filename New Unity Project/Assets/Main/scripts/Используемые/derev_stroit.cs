using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class derev_stroit : MonoBehaviour {
    public bool n;
    
	// Use this for initialization
	void Start () {
	n = false;	
	}

    // Update is called once per frame
    public void OnMouseDown()
    {
        n = !n;
    }

}

