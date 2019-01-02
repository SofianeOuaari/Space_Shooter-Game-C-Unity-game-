using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automatic_Shot_Spawner : MonoBehaviour {
    [SerializeField] GameObject shot;
	// Use this for initialization
	void Start () {
        StartCoroutine(Automatic_Shot());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator Automatic_Shot()
    {
        while (true)
        {
            Vector3 pos = transform.position;
            Instantiate(shot,new Vector3(pos.x,pos.y,pos.z) , Quaternion.identity);

            yield return new WaitForSeconds(2f);
        }
    }
}
