using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies_Spaceship_Mov : MonoBehaviour
{
    private float speed = 5f;
    // Use this for initialization
    void Start()
    {
        transform.Rotate(-90f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            if (Random.Range(1, 10) * Time.deltaTime == 5)
            {
                speed++;
            }
            Vector3 pos = transform.position;
            pos.z -= speed * Time.deltaTime;
            transform.position = pos;
            if (pos.z < -5)
            {
                Destroy(gameObject);
            }
        }
    }

}

