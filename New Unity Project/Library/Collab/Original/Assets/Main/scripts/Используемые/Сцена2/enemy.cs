using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour {

    public GameObject kletka;
    public int x = 9;
    public int y = 9;
    public int x1;
    public int y1;
    public int step = 7;

    void Start () {
        if (kletka == null)
        {
            kletka = GameObject.Find("Button (9 9)");
        }
        this.transform.position = kletka.transform.position;
		
	}
	
	// Update is called once per frame
	public void enemyhod() {
        for (int  i =7; i > 0; i--)
        {

            x1 = Random.Range(x - 1, x + 2);
            y1 = Random.Range(y-1, y+2);
            if ((x1>9) | (x1<0))
            {
                x1 = x;
            }
            if ((y1 > 9) | (y1 < 0))
            {
                y1 = y;
            }
        
            kletka = GameObject.Find("Button ("+ x1.ToString()+ " "+ y1.ToString()+ ")");
            this.transform.position = kletka.transform.position;
            x = x1;
            y = y1;

        }
	}
}
