using UnityEngine;
using UnityEngine.SceneManagement; 

public class kletka: MonoBehaviour
{
    public int x;
    public int y;
    public int kek;
    public float dist;
    public GameObject plaer;
    public GameObject pocemon;
    public GameObject pocemon2;
    public GameObject knopkaStr;


    public int i = 1;
    public int str = 1;
    public bool dom = false;
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
        if (dist < 1)
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
            if ((dist <= plaer.GetComponent<hero>().shag) & (plaer.GetComponent<hero>().st == 1))
            //if (true)
            //if (plaer.GetComponent<hero>().st == 1)
            {
                if (plaer.GetComponent<hero>().step > 0)  //Если у героя остались шаги, он ходит
                {
                    plaer.transform.position = transform.position;
                    plaer.GetComponent<hero>().x = x;
                    plaer.GetComponent<hero>().y = y;

                    plaer.GetComponent<hero>().kletka = this.name;

                    plaer.GetComponent<hero>().step--;
                }
                else                                      //Если не осталось, он идет нахуй
                {
                    plaer.GetComponent<hero>().st = 0;
                    
                }
            }
        }




    }

    void Update()

    {
        dist = Vector3.Distance(plaer.transform.position, transform.position);
     

           
           
            //knopkaStr.GetComponent<stroika2>().dom = true;
        }
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

   
    void strojka()
    {

    }
}
    

   