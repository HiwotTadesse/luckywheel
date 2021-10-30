using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject pin;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            SpawnPin();
        }
	}
    void SpawnPin()
    {
        Instantiate(pin, transform.position, transform.rotation);
    }
}
