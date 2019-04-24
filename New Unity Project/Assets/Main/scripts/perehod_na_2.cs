using UnityEngine;
using UnityEngine.SceneManagement;

public class perehod_na_2 : MonoBehaviour
{
    public GameObject hero;
    public AudioClip knopka;
    //public Transform
    void Start()
   {


        if (hero == null)
        {
            hero = GameObject.Find("Hero");
      }
   }

void OnMouseDown()
    {

        SceneManager.LoadScene("2");
        GetComponent<AudioSource>().PlayOneShot(knopka);
    }
        // Destroy(plaer);
    
   
}
