using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turn_count : MonoBehaviour {

    public GameObject plaer;
    public GameObject turncount; 


    void Start () {
        if (plaer == null)
        {
            plaer = GameObject.Find("hero");
        }
        if (turncount == null)
        {
            turncount = GameObject.Find("Text");
        }
    }
	

	void Update () {
        turncount.GetComponent<Text>().text = "Шагов осталось:"+plaer.GetComponent<hero>().step.ToString(); //Текст обновляется при изменении оставшихся шагов
    }
}
