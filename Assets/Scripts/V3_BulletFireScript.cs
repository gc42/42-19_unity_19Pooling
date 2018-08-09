using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Fire script for generic object pooling
/// </summary>
public class V3_BulletFireScript : MonoBehaviour {

    public float fireTime = 0.05f;
    private V3_ObjectPoolerScript PoolerScript;

	void Start ()
    {
        StartInvokeRepeating();
        PoolerScript = gameObject.GetComponent<V3_ObjectPoolerScript>();
	}
    
	public void StartInvokeRepeating()
	{
		InvokeRepeating("Fire", fireTime, fireTime);
	}
	
	public void CancelInvokeRepeating()
	{
		CancelInvoke("Fire");
	}

    void Fire()
    {
        GameObject obj = PoolerScript.GetPooledObject();

        if (obj == null) return;

        obj.transform.position = transform.position;
        obj.transform.rotation = transform.rotation;
        obj.SetActive(true);
    }
}
