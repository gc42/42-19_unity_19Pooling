using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V2_BulletFireScript : MonoBehaviour {

    public float fireTime = 0.05f;
    public GameObject bullet;

    public int pooledAmount = 20;
    List<GameObject> bullets;

	// Use this for initialization
	void Start ()
    {
        // creation de la liste du pool et creation des objets pour remplir le pool
        bullets = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(bullet);
            obj.SetActive(false);
            bullets.Add(obj);
        }

        InvokeRepeating("Fire", fireTime, fireTime);
	}

    void Fire()
    {
        for (int i = 0; i < bullets.Count; i++)
        {
            if (!bullets[i].activeInHierarchy) // recherche le premier bullet inactif pour le reutiliser
            {
                bullets[i].transform.position = transform.position;
                bullets[i].transform.rotation = transform.rotation;
                bullets[i].SetActive(true);
                break;
            }
        }
    }

}
