using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction_Effect : MonoBehaviour {
    private ParticleSystem fire_destruction;
	// Use this for initialization
	void Start () {
        fire_destruction = gameObject.GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            Vector3 pos_current = GameObject.FindGameObjectWithTag("Player").transform.position;
            gameObject.transform.position = pos_current;
        }
	}
    public void On_Destruction_Collision()
    {
        fire_destruction.Play();
    }
}
