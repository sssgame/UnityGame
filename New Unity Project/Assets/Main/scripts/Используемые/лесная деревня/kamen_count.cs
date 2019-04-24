using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kamen_count : MonoBehaviour
{

    public int cur_kamen;
    public int add_kamen;

    // Use this for initialization
    void Start()
    {
        cur_kamen = 10000;

    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Text>().text = cur_kamen.ToString() + " + " + add_kamen.ToString();
    }
}
