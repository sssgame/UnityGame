using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otradi : MonoBehaviour {

    public int mech;
    public int arrows;
    public int piks;

    void Update () {
      
        
        if (Input.GetKeyUp("f"))//Если нажата клавиша 'f' то:      
        {
             mech++;
        }
        if (Input.GetKeyUp("g"))//Если нажата клавиша 'g' то:      
        {
            arrows++;
        }
        if (Input.GetKeyUp("h"))//Если нажата клавиша 'h' то:      
        {
            piks++;
        }

    }
}
