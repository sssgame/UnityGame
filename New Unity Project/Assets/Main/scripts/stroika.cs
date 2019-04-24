using UnityEngine;

public class stroika: MonoBehaviour
{
    public int i;
    public GameObject domik;
    public GameObject domik2;
    public GameObject domik3;
    public GameObject domik4;
    public GameObject domik5;
    public GameObject hero;
    //public AudioClip stuk;
    public int n = 0;

    private void Start()
    {
        if (domik == null)
        {
            domik = GameObject.Find("domik");

        }
        if (domik2 == null)
        {
            domik2 = GameObject.Find("domik2");
        }
        if (domik3 == null)
        {
            domik3 = GameObject.Find("domik3");
        }
        /*if (domik4 == null)
        {
            domik4 = GameObject.Find("domik4");
        }
        if (domik5 == null)
        {
            domik5 = GameObject.Find("domik5");
        }*/
        if (hero == null)
        {
            hero = GameObject.Find("hero");
        }
        i = 1;
    }

    public void Strjik()


    {
        if (n == 1)
        {
            if (i == 1)
            {
                domik.transform.position = hero.transform.position;

                i = i + 1;

            }
            else
            {
                if ((i == 2) && (hero.transform.position != domik.transform.position))
                {

                    domik2.transform.position = hero.transform.position;

                    i = i + 1;

                }
                else
                {
                    if ((i == 3) && (hero.transform.position != domik2.transform.position) && (hero.transform.position != domik.transform.position))
                    {

                        domik3.transform.position = hero.transform.position;

                        i = i + 1;

                    }
                    /*else
                    {
                        if ((i == 4) && (hero.transform.position != domik2.transform.position) && (hero.transform.position != domik.transform.position) && (hero.transform.position != domik3.transform.position))
                        {

                            domik4.transform.position = hero.transform.position;

                            i = i + 1;


                        }
                        else
                        {
                            if ((i == 5) && (hero.transform.position != domik2.transform.position) && (hero.transform.position != domik.transform.position) && (hero.transform.position != domik4.transform.position) && (hero.transform.position != domik3.transform.position))
                            {

                                domik5.transform.position = hero.transform.position;

                                i = i + 1;


                            }
                        }
                    }*/
                }
            }
        }
    }
}
                 
            
        


    

  
        
    
