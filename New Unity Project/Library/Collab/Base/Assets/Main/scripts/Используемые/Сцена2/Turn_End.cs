using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_End : MonoBehaviour {

    public GameObject plaer;
    public GameObject end;
    public GameObject drevo;
    public GameObject havka;
    public GameObject enemy;

    void Start () {
        if (end == null)
        {
            end = GameObject.Find("Turn end");
        }
        if (plaer == null)
        {
            plaer = GameObject.Find("hero");
        }
        if (drevo == null)
        {
            drevo = GameObject.Find("Drevo");
        }
        if (havka == null)
        {
            havka = GameObject.Find("havka");
        }
        if(enemy == null)
        {
            enemy = GameObject.Find("enemy");
        }

    }


    public void OnMouseDown()
    {
        plaer.GetComponent<hero>().step = 7;  //При нажатии герой получает свои 7 ходов 
        drevo.GetComponent<Drevo_count>().cur_drev = drevo.GetComponent<Drevo_count>().cur_drev + drevo.GetComponent<Drevo_count>().add_drev ;
        havka.GetComponent<havka_count>().cur_havka = havka.GetComponent<havka_count>().cur_havka + havka.GetComponent<havka_count>().add_havka;

        enemy.GetComponent<enemy>().state = true;

    }
     

}
