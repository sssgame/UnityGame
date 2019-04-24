using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour {

    public GameObject[,] field = new GameObject[10,10];

    public string imya;
	
	void Start () {
		for ( int y = 0; y<10; y++ )
        {
            for ( int x = 0; x<10; x++ )
            {
                imya = "Button (" + y.ToString() + " " + x.ToString() + ")";
                field[x,y] = GameObject.Find(imya);
                field[x, y].GetComponent<kletka>().x = x;
                field[x, y].GetComponent<kletka>().y = y;
            }
        }
	}
	
	

}
