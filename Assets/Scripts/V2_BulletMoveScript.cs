﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V2_BulletMoveScript : MonoBehaviour {

    public float speed = 5f;

	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
	}
}
