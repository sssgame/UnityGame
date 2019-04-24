using UnityEngine;
using UnityEngine.SceneManagement; 

public class kletka: MonoBehaviour
{

    public int kek;
    public float dist;
    public GameObject plaer;
    public GameObject knopkaStr;


    public int i = 1;
    public int str = 1;
   
    private void Start()
    {
        if (plaer == null)
        {
            plaer = GameObject.Find("hero");
        }
        if (knopkaStr == null)
        {
            knopkaStr = GameObject.Find("stroika");
        }



        // sprite = GetComponent<SpriteRenderer>().sprite;
    }

    void OnMouseDown()
    {
        if (dist < 24)
        {
            if (plaer.GetComponent<hero>().st == 0)
            {
                plaer.GetComponent<hero>().st = 1;
            }
            else
            {
                plaer.GetComponent<hero>().st = 0;
            }

        }
        else
        {
            if (dist >24 & dist < 1600 & plaer.GetComponent<hero>().st == 1)
            {
                plaer.transform.position = transform.position;
                plaer.GetComponent<hero>().st = 0;
            }
        }




    }

    void Update()

    {
        dist = Vector3.Distance(plaer.transform.position, transform.position);
        //if (dist < 24)
        //{
           // knopkaStr.GetComponent<stroika>().n = str;
        //}
        // kek = plaer.GetComponent<heroscr>().vibor;

        // if (kek > 0)
        //  {

        // if (sprite == ground)
        //{
        //if (dist < 10000)
        // {

        // plaer.GetComponent<heroscr>().audioo();

        //plaer.transform.position = transform.position;
        //plaer.GetComponent<heroscr>().vibor = 0;
        // plaer.GetComponent<heroscr>().koord = gameObject.name;
        // }
        // }
        // }

    }
    void strojka()
    {

    }
}
    

   