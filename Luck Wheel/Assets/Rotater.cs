using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour {

    [SerializeField]
    float speed;

    Rigidbody2D rigidbody;
	// Use this for initialization
	void Start () {

        rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(0f, 0f, speed * Time.deltaTime);
	}
}
