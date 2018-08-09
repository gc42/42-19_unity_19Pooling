using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V1_BulletDestroyScript : MonoBehaviour {

	void Start ()
    {
        Destroy(gameObject, 2f); //Destruction systematique au bout de 2 secondes
	}
}
