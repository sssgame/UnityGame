using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfCap : MonoBehaviour {

    public GameObject enemy;

	// Use this for initialization
	void Start () {
        Instantiate(enemy, this.transform.position + Vector3.right * 2, this.transform.rotation);
        Instantiate(enemy, this.transform.position + Vector3.left * 2, this.transform.rotation);
        Instantiate(enemy, this.transform.position + Vector3.right * 2 + Vector3.down * 2, this.transform.rotation);
        Instantiate(enemy, this.transform.position + Vector3.left * 2 + Vector3.down * 2, this.transform.rotation);
        Instantiate(enemy, this.transform.position + Vector3.down * 2, this.transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
