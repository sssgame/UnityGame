using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class enemy : MonoBehaviour {

    public GameObject kletka;
    public int x = 9;
    public int y = 9;
    public int x1;
    public int y1;
    public int step = 7;
    public GameObject vrag;
    public GameObject point;
    public GameObject Array;

    
    public int framecount;

    public bool state;

    
    int ifodd;
    string imya;
    public int movecount = 1;

    void Start () {
        if (kletka == null)
        {
            kletka = GameObject.Find("Button (9 9)");
        }
        this.transform.position = kletka.transform.position;
		
	}

    // Update is called once per frame


    /* Функция движения по направлению.
     * Получает аргументом собсна направление чеез число, ибо я долбаеб
     * 0 - влево вверх
     * 1 - вправо вверх
     * 2 - просто влево
     * 3 - просто вправо
     * 4 - влево вниз
     * 5 - вправо вниз
     * 
     * 
     * */

        /*
    public void Move(int dir)
    {
        
        ifodd = y % 2;
        switch (dir)
        {
            case 0:
                if (ifodd == 1)
                {

                    if ((x >= 0) & (y + 1 >= 0) & (x <= 9) & (y + 1 <= 9))
                    {
                        imya = "Button (" + (y + 1) + " " + x + ")";
                        point = GameObject.Find(imya);
                        this.transform.position = point.transform.position;
                        y++;

                        movecount--;
                        Thread.Sleep(100);

                    }

                }
                else
                {
                    if ((x - 1 >= 0) & (y + 1 >= 0) & (x - 1 <= 9) & (y + 1 <= 9))
                    {
                        imya = "Button (" + (y + 1) + " " + (x - 1) + ")";
                        point = GameObject.Find(imya);
                        this.transform.position = point.transform.position;
                        y++;
                        x--;

                        movecount--;
                        Thread.Sleep(100);
                    }

                }
                break;
            case 1:
                if (ifodd == 1)
                {

                    if ((x + 1 >= 0) & (y + 1 >= 0) & (x + 1 <= 9) & (y + 1 <= 9))
                    {
                        imya = "Button (" + (y + 1) + " " + (x + 1) + ")";
                        point = GameObject.Find(imya);
                        this.transform.position = point.transform.position;
                        y++;
                        x++;

                        movecount--;
                        Thread.Sleep(100);
                    }

                }
                else
                {
                    if ((x >= 0) & (y + 1 >= 0) & (x <= 9) & (y + 1 <= 9))
                    {
                        imya = "Button (" + (y + 1) + " " + (x) + ")";
                        point = GameObject.Find(imya);
                        this.transform.position = point.transform.position;
                        y++;
                        movecount--;
                        Thread.Sleep(100);
                    }

                }
                break;
            case 2:



                if ((x - 1 >= 0) & (y >= 0) & (x - 1 <= 9) & (y <= 9))
                {
                    imya = "Button (" + (y) + " " + (x - 1) + ")";
                    point = GameObject.Find(imya);
                    this.transform.position = point.transform.position;
                    x--;
                    movecount--;
                    Thread.Sleep(100);
                }


                break;
            case 3:
                if ((x + 1 >= 0) & (y >= 0) & (x + 1 <= 9) & (y <= 9))
                {
                    imya = "Button (" + (y) + " " + (x + 1) + ")";
                    point = GameObject.Find(imya);
                    this.transform.position = point.transform.position;
                    x++;
                    movecount--;
                    Thread.Sleep(100);
                }

                break;
            case 4:
                if (ifodd == 1)
                {

                    if ((x >= 0) & (y - 1 >= 0) & (x <= 9) & (y - 1 <= 9))
                    {
                        imya = "Button (" + (y - 1) + " " + (x) + ")";
                        point = GameObject.Find(imya);
                        this.transform.position = point.transform.position;
                        y--;
                        movecount--;
                        Thread.Sleep(100);

                    }

                }
                else
                {
                    if ((x - 1 >= 0) & (y - 1 >= 0) & (x - 1 <= 9) & (y - 1 <= 9))
                    {
                        imya = "Button (" + (y - 1) + " " + (x - 1) + ")";
                        point = GameObject.Find(imya);
                        this.transform.position = point.transform.position;
                        y--;
                        x--;
                        movecount--;
                        Thread.Sleep(100);
                    }

                }
                break;
            case 5:
                if (ifodd == 1)
                {

                    if ((x + 1 >= 0) & (y - 1 >= 0) & (x + 1 <= 9) & (y - 1 <= 9))
                    {
                        imya = "Button (" + (y - 1) + " " + (x + 1) + ")";
                        point = GameObject.Find(imya);
                        this.transform.position = point.transform.position;
                        y--;
                        x++;
                        movecount--;
                        Thread.Sleep(100);
                    }

                }
                else
                {
                    if ((x >= 0) & (y - 1 >= 0) & (x <= 9) & (y - 1 <= 9))
                    {
                        imya = "Button (" + (y - 1) + " " + (x) + ")";
                        point = GameObject.Find(imya);
                        this.transform.position = point.transform.position;
                        y--;
                        movecount--;
                        Thread.Sleep(100);

                    }

                }
                break;


        }


    }
    */

    public void enemyhod() {
        
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

    void Update()

    {
        if (state == true)
        {
            if (framecount == 30)
            {
                this.enemyhod();
                framecount = 0;
                movecount++;
            }
            else
            {
                framecount++;
            }
        }

        if(movecount == 7)
        {
            movecount = 0;
            state = false;
        }




        
    }


}
