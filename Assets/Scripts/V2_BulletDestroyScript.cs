using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V2_BulletDestroyScript : MonoBehaviour {

	private void OnEnable()
	{
        Invoke("Destroy", 2f); // invoke Destroy for set inactive 2 seconds later
	}

	private void Destroy()
	{
        gameObject.SetActive(false);
	}

    // S'applique lorsqu'on switch SetActive on/off sur un game object
	private void OnDisable()
	{
        CancelInvoke(); // cleaner, to be sure not desable multitimes
	}
}
