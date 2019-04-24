using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInfantry : MonoBehaviour {

    public GameObject Ally;

	// Use this for initialization
	void Start () {
        

        for (int i = 0; i < 2; i++)
        {
            Instantiate(Ally, this.transform.position + Vector3.right * i * 10, this.transform.rotation);
        }
    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
