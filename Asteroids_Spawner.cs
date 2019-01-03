using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids_Spawner : MonoBehaviour {
    [SerializeField] private GameObject[] asteroids;
    private float i = 5f;
    public float speed = 5f;
    GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(Asteroid_Spawner());
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Random.Range(1, 25)*Time.deltaTime == 1)
        {
            speed++;
        }
       
		
	}
    IEnumerator Asteroid_Spawner()
    {
        
            while (true)
            {
            if (player != null)
            {
                Instantiate(asteroids[Random.Range(0, asteroids.Length)], new Vector3(Random.Range(-7f, 7f), Random.Range(player.GetComponent<Player_Script>().min_Y_boundary, player.GetComponent<Player_Script>().max_Y_boundary), 50), Quaternion.identity);
                if (Random.Range(0, 15) == 10 && i > 2)
                {
                    i--;
                }
            }
                yield return new WaitForSeconds(Random.Range(2, i));

            }
        }
    }

