using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V1_BulletFireScript : MonoBehaviour {

    public float fireTime = 0.05f;
    public GameObject bullet;

	void Start ()
    {
        InvokeRepeating("Fire", fireTime, fireTime);
	}

    void Fire()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }

}
