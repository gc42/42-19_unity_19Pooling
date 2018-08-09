using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V3_BulletDestroyScript : MonoBehaviour {

	private void OnEnable()
	{
        Invoke("Destroy", 2f); // invoke the Destroy method 2 seconds later
	}

	private void Destroy()
	{
        gameObject.SetActive(false);
	}

	private void OnDisable()
	{
        CancelInvoke(); // cleaner, to be sure not desable multitimes
	}
}
