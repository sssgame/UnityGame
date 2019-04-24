using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class text : MonoBehaviour
{
    public int s = 1;
    public int counterwood = 0;
    public int counterstone = 0;
    public int counterfood = 0;
    public GameObject WoodCounter;
    public GameObject StoneCounter;
    public GameObject FoodCounter;
    public Text Buratino;
    public Text Tiny;
    public Text FreshMeat;
    Text wood;
    Text stone;
    Text food;
    void Start()
    {
        wood = WoodCounter.gameObject.GetComponent<Text>();
        stone = StoneCounter.gameObject.GetComponent<Text>();
        food = FoodCounter.gameObject.GetComponent<Text>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) WOOD();
        if (Input.GetKeyDown(KeyCode.S)) STONE();
        if (Input.GetKeyDown(KeyCode.F)) FOOD();
    }
    public void WOOD()
    {
        counterwood = counterwood + s * 2;
        wood.text = counterwood.ToString();
    }
    public void STONE()
    {
        counterstone = counterstone + s;

        stone.text = counterstone.ToString();
    }
    public void FOOD()
    {
        counterfood = counterfood + s * 3;
        food.text = counterfood.ToString();
    }
}