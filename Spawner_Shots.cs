using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Shots : MonoBehaviour {
    [SerializeField] private GameObject fire_shot;
    private int counter = 0;
	void Update () {
        if (gameObject != null)
        {
            counter++;
            if (Input.GetKeyDown(KeyCode.Space) && counter>25)
            {
                    counter = 0;
                    Vector3 pos = transform.position;
                    Instantiate(fire_shot, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity);
                
            }
        }
        
	}
}
