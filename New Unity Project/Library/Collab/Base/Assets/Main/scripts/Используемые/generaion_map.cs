
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class generaion_map : MonoBehaviour
{
    public int p;
    public bool z;
    public Sprite les;
    public Sprite rock;
    public Sprite les2;
    public Sprite rock2;
    public Sprite stand;
    public Sprite sles;
    public Sprite srock;
    public Sprite sles2;
    public Sprite srock2;
    public Sprite sstand;


    void Start()
    {

        p = Random.Range(5, 10);
        if (p == 5)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = les;
        }
        if (p == 6)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = les2;
        }
        if (p == 7)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = rock;
        }
        if (p == 8)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = rock2;
        }
        if (p == 9)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = stand;
        }
    }



    // лес
    //hexagonAll_sheet_87 лес 2
    //hexagonAll_sheet_65 камень
    //hexagonAll_sheet_109 мало леса
    //hexagonAll_sheet_5 стандарт
    void Update()
    {
        z=GameObject.Find("hexagonAll_sheet_104").GetComponent<derev_stroit>().n;
    }
    public void OnMouseDown()
    {
        if (p == 5 && z == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sles;
            GameObject.Find("hexagonAll_sheet_104").GetComponent<derev_stroit>().n = false;
        }
        if (p == 6 && z == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sles2;
            GameObject.Find("hexagonAll_sheet_104").GetComponent<derev_stroit>().n = false;
        }
        if (p == 7 && z == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = srock;
            GameObject.Find("hexagonAll_sheet_104").GetComponent<derev_stroit>().n = false;
        }
        if (p == 8 && z == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = srock2;
            GameObject.Find("hexagonAll_sheet_104").GetComponent<derev_stroit>().n = false;
        }
        if (p == 9 && z == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sstand;
            GameObject.Find("hexagonAll_sheet_104").GetComponent<derev_stroit>().n = false;
        }
    }
}
