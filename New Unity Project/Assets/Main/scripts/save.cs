using UnityEngine;

public class save : MonoBehaviour
{
    public Camera Camera1;
    public Camera Camera2;


    void Update()
    {
        if (Input.GetKeyUp("c"))//Если нажата клавиша 'c' то:      
        {
            Camera2.enabled = !Camera2.enabled;
            Camera1.enabled = !Camera1.enabled;
        }
    }
}