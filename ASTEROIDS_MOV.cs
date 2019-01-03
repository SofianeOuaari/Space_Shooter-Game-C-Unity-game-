using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASTEROIDS_MOV : MonoBehaviour
{
     private float asteroid_speed = 5f;
    //private float asteroid_speed = GameObject.FindGameObjectWithTag("asteroids").GetComponent<Asteroids_Spawner>().speed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject != null)
        {
            
            Vector3 pos = transform.position;
            pos.z -= asteroid_speed * Time.deltaTime;
            //transform.Rotate(90f * Time.deltaTime, 0 ,0);

            transform.position = pos;
            if (transform.position.z < -5)
            {
                Destroy(gameObject);
            }

}
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && other.gameObject!=null){
            GameObject.FindGameObjectWithTag("Destruction_effect").GetComponent<Destruction_Effect>().On_Destruction_Collision();
            other.gameObject.GetComponent<Player_Script>().on_destruction();
            //Destroy(other.gameObject);

            Destroy(gameObject);
        }
    }
}
        
      
        
	

