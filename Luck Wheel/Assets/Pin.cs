using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

    Rigidbody2D rigidbody;

    [SerializeField]
    float speed;

    private bool isPinned;
	// Use this for initialization
	void Start () {

        rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if(!isPinned)
            rigidbody.MovePosition(rigidbody.position + Vector2.up * speed * Time.deltaTime);
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Rotator")
        {
            transform.SetParent(collider.transform);
            isPinned = true;
        }
        else if(collider.tag == "Pin")
        {
            FindObjectOfType<Gamemanager>().EndGame();
        }
    }
}
