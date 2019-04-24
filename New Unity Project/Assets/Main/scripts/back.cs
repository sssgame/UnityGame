using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour {
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    public Camera camera4;
    public Camera camera5;
    public Camera camera6;
    public AudioClip knopka;
    public GameObject canvas;
    public GameObject canvasstr;

    void Awake()
    {
        camera1.enabled = true;//Включен (по стандарту).  
        camera3.enabled = false;
        camera4.enabled = false;
        camera5.enabled = false;
        camera6.enabled = false;//Отключен  
    }
    void OnMouseDown()
    {
        if (camera2.enabled == true)
        {
            camera2.enabled = !camera2.enabled;
            camera1.enabled = !camera1.enabled;
            GetComponent<AudioSource>().PlayOneShot(knopka);
            canvas.SetActive(true);
            canvasstr.SetActive(false);
        }
        else
        {
            if (camera3.enabled == true)
            {
                camera3.enabled = !camera3.enabled;
                camera1.enabled = !camera1.enabled;
                GetComponent<AudioSource>().PlayOneShot(knopka);
                canvas.SetActive(true);
                canvasstr.SetActive(false);
            }
            else
            {
                if (camera4.enabled == true)
                {
                    camera4.enabled = !camera4.enabled;
                    camera1.enabled = !camera1.enabled;
                    GetComponent<AudioSource>().PlayOneShot(knopka);
                    canvas.SetActive(true);
                    canvasstr.SetActive(false);
                }
                else
                {
                    if (camera5.enabled == true)
                    {
                        camera5.enabled = !camera5.enabled;
                        camera1.enabled = !camera1.enabled;
                        GetComponent<AudioSource>().PlayOneShot(knopka);
                        canvas.SetActive(true);
                        canvasstr.SetActive(false);
                    }
                    else
                    {
                        if (camera6.enabled == true)
                        {
                            camera6.enabled = !camera6.enabled;
                            camera1.enabled = !camera1.enabled;
                            GetComponent<AudioSource>().PlayOneShot(knopka);
                            canvas.SetActive(true);
                            canvasstr.SetActive(false);
                        }
                    }
                }
            }
        }
    }
}
