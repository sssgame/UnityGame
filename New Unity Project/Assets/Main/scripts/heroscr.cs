using UnityEngine;

public class heroscr : MonoBehaviour {

   public  int vibor;
   public  string koord;
   public AudioClip chpok;
   

    void OnMouseDown()
    {
        if (vibor == 0)
        {
            
            vibor = vibor + 1;
           
        }
        else
        {
            vibor = 0;
        }
    }
   // public void  audioo()
   // {
       // GetComponent<AudioSource>().PlayOneShot(chpok);
    }
    // void Awake()
    // {
    //  DontDestroyOnLoad(transform.gameObject);
    //  }
 

//}
