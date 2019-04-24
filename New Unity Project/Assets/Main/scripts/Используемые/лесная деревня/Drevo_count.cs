using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drevo_count : MonoBehaviour {

    public int cur_drev;
    public int add_drev;

    // Use this for initialization
    void Start () {
        cur_drev = 10000;

    }
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Text>().text = cur_drev.ToString() + " + " + add_drev.ToString();
    }
}
