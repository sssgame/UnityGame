using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INF_AI : MonoBehaviour {

    float speed = 4f;
    public GameObject player;
    // Use this for initialization
    void Start () {
        if (player == null)
        {
            player = GameObject.Find("hero");
        }
    }
	
	// Update is called once per frame
	void Update () {
        //Vector3 targetDir = player.transform.position - transform.position;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
        // transform.rotation = Quaternion.LookRotation(targetDir);

        Vector3 targ = player.transform.position;
        targ.z = 0f;

        Vector3 objectPos = transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;

        float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle-90));
    }
}
