using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shot_Mov : MonoBehaviour {
    private Rigidbody rb;
    private float speed = 500f;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        rb.AddForce(-transform.forward * speed * Time.deltaTime);
        Destroy(gameObject, 5f);
	}
}
