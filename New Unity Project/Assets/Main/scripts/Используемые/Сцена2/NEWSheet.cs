using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NEWSheet : MonoBehaviour {

    int s = 1;
    public int counterwood = 0;
    public int counterstone = 0;
    public int counterfood = 0;

    public GameObject WoodCounter;
    public GameObject StoneCounter;
    public GameObject FoodCounter;

    Text Wood;
    Text Stone;
    Text Food;

    // Use this for initialization
    void Start () {

        Wood = WoodCounter.gameObject.GetComponent<Text>();
        Stone = StoneCounter.gameObject.GetComponent<Text>();
        Food = FoodCounter.gameObject.GetComponent<Text>();




    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            WOOD();

        if (Input.GetKeyDown(KeyCode.S))
            STONE();

        if (Input.GetKeyDown(KeyCode.F))
            FOOD();

    }


    public void WOOD()
    {
        counterwood = counterwood + s * 2;
        Wood.text = counterwood.ToString();
    }

    public void STONE()
    {
        counterstone = counterstone + s;
        Stone.text = counterstone.ToString();
    }

    public void FOOD()
    {
        counterfood = counterfood + s * 3;
        Food.text = counterfood.ToString();
    }
}
