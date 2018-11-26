using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAnimation : MonoBehaviour {

    public float speed;
    private Vector3 target = new Vector3 (0, 1.2f, 0);
    
	void Update () {

        transform.position = Vector3.MoveTowards(transform.position,target, Time.deltaTime * speed);
        if (transform.position == target && target.y != 0.7f)
            target.y = 0.7f;
        else if (transform.position == target && target.y == 0.7f)
            target.y = 1.2f;

    }
}
