using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Big_Map_DeGeneration : MonoBehaviour {

    public int p;
    public Sprite lit_forest;
    public Sprite forest;
    public Sprite big_forest;

    void Start()
    {
        /*if (lit_forest == null)
        {
            lit_forest = GameObject.Find("grass_10");
        }
        if (forest == null)
        {
            forest = GameObject.Find("grass_11");
        }
        if (big_forest == null)
        {
            big_forest = GameObject.Find("grass_13");
        }*/

        p = Random.Range(1, 5);

       if (p == 1)
        {
            gameObject.GetComponent<Image>().sprite = lit_forest;
        }
        if (p == 2)
        {
            gameObject.GetComponent<Image>().sprite = forest;
        }
        if (p == 3)
        {
            gameObject.GetComponent<Image>().sprite = big_forest;
        }

    }


}
