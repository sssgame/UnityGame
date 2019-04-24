using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class domiki : MonoBehaviour {
    public GameObject hero;
    public GameObject stroika;
    public int nomer;

	// Use this for initialization
	void Start () {

        if (hero == null)
        {
            hero = GameObject.Find("hero");
        }
		if(stroika == null)
        {
            stroika = GameObject.Find("stroika");
        }
        this.transform.position = hero.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
