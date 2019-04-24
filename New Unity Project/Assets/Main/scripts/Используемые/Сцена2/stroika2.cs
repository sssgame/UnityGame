using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stroika2 : MonoBehaviour
{
    public GameObject[] image;
    public GameObject plaer;
    public GameObject vdom;
    public Sprite sprite ;
    public string kletka;
    public int i;
    public int x;
    public int y;
    bool[,] tabl = new bool[10, 10];


    public void Start()
    {

        if (plaer == null)
        {
            plaer = GameObject.Find("hero");
        }
        for (x = 0; x < 10; x++)
        {
            for (y = 0; y < 0; y++)
            {
                tabl[x, y] = false;
            }
        }
    }
    // Use this for initialization
    public void OnMouseDown()
    {
        x = plaer.GetComponent<hero>().x;
        y = plaer.GetComponent<hero>().y;
        if (tabl[x, y] == false)
        {
            tabl[x, y] = true;
            kletka = plaer.GetComponent<hero>().kletka;
            vdom = GameObject.Find(kletka);
            vdom.GetComponent<Image>().sprite = sprite;
            // Instantiate(image[i]);
           // image[i].transform.position = plaer.transform.position;
            ;
        }
    }
}
	

