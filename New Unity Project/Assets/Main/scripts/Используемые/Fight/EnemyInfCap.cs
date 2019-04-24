using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInfCap : MonoBehaviour {

    public GameObject enemy;
    public GameObject player;
    float speed = 4f;
    // Use this for initialization
    void Start () {
        Instantiate(enemy, this.transform.position + Vector3.right * 3, this.transform.rotation);
        Instantiate(enemy, this.transform.position + Vector3.left * 3, this.transform.rotation);
        Instantiate(enemy, this.transform.position + Vector3.right * 3 + Vector3.down * 3, this.transform.rotation);
        Instantiate(enemy, this.transform.position + Vector3.left * 3 + Vector3.down * 3, this.transform.rotation);
        Instantiate(enemy, this.transform.position + Vector3.down * 3, this.transform.rotation);
        if (player == null)
        {
            player = GameObject.Find("hero");
        }
    }
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
        Vector3 targ = player.transform.position;
        targ.z = 0f;

        Vector3 objectPos = transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;

        float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
    }
}
