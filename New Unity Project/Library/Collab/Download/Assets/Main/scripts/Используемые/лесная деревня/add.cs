using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class add : MonoBehaviour {

    public GameObject drevo;
    public GameObject havka;
    // Use this for initialization
    public void Start () {
        if (drevo == null)
        {
            drevo = GameObject.Find("Drevo");
        }
        if (havka == null)
        {
            havka = GameObject.Find("havka");
        }
    }
    public void OnMouseDown()
    {
        drevo.GetComponent<Drevo_count>().cur_drev += drevo.GetComponent<Drevo_count>().add_drev;
        havka.GetComponent<havka_count>().cur_havka += havka.GetComponent<havka_count>().add_havka;
    }
    // Update is called once per frame

}
