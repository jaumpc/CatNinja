using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {


	
    public Transform firePoint;
    public GameObject shurikenPrefab;

	

	void Update () {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
	}


    void Shoot()
    {
        Instantiate(shurikenPrefab, firePoint.position, firePoint.rotation);
    }
}
