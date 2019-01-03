using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Nave_Spawner : MonoBehaviour {
    [SerializeField] private GameObject enemy_nave;
    private float spawner_time = 10f;
    GameObject player;
    // Use this for initialization
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(Enemy_Spawner());
        
    }

    // Update is called once per frame
    void Update() {

    }
    IEnumerator Enemy_Spawner()
    {
        while (true) {
            if (player != null) {
                if ((Random.Range(1, 30) * Time.deltaTime == 15) && spawner_time > 2)

                {
                    spawner_time--;
                }
                Instantiate(enemy_nave, new Vector3(Random.Range(-5f, 5f), Random.Range(player.GetComponent<Player_Script>().min_Y_boundary, player.GetComponent<Player_Script>().max_Y_boundary), 25), Quaternion.identity);
            }
            yield return new WaitForSeconds(Random.Range(spawner_time, spawner_time + 5));
        }
    }
    

    }

