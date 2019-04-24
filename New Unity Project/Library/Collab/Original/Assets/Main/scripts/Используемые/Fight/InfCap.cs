using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfCap : MonoBehaviour {

    public GameObject enemy;

	// Use this for initialization
	void Start () {
        Instantiate(enemy, this.transform.position + Vector3.right * 5, this.transform.rotation);
        Instantiate(enemy, this.transform.position + Vector3.left * 5, this.transform.rotation);
        Instantiate(enemy, this.transform.position + Vector3.right * 5 + Vector3.down * 3, this.transform.rotation);
        Instantiate(enemy, this.transform.position + Vector3.left * 5 + Vector3.down * 3, this.transform.rotation);
        Instantiate(enemy, this.transform.position + Vector3.down * 5, this.transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
