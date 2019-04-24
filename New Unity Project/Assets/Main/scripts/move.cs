using UnityEngine;

public class move : MonoBehaviour

{

    public GameObject plaer;

   
    private void Start()
    {
        if (plaer == null)
        {
            plaer = GameObject.Find("Hero");
        }
    }

    void OnMouseDown()

    {
       
            plaer.transform.position = transform.position;
     }
    }


