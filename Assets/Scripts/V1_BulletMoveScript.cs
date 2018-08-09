using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V1_BulletMoveScript : MonoBehaviour {

    public float speed = 5f;

	void Update ()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
	}
}
