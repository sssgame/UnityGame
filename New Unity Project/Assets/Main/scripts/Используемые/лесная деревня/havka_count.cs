using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class havka_count : MonoBehaviour {

    public int cur_havka;
    public int add_havka;
    // Use this for initialization
    void Start () {
        cur_havka = 10000;

    }
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Text>().text = cur_havka.ToString() + " + " + add_havka.ToString();
    }
}
