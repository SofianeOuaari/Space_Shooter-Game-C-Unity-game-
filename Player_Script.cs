using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player_Script : MonoBehaviour
{
    public float life_points = 1f;
    /*private float speed = 10f;
    private GameObject player = GameObject.FindGameObjectWithTag("Player");*/
    private float speed = 45f;
    public float max_X_boundary = 5f;
    public float min_X_boundary = -5f;
    public float max_Y_boundary = 4f;
    public float min_Y_boundary = 0f;
    


    //private ParticleSystem fire_destruction;
    // Use this for initialization
    void Start()
    {
        
        
        //GameObject player = GameObject.FindGameObjectWithTag("Player");

        //fire_destruction = gameObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            pos.x = pos.x - speed * Time.deltaTime;

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            pos.x = pos.x + speed * Time.deltaTime;

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            pos.y += speed * Time.deltaTime;

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (pos.x > max_X_boundary)
        {
            pos.x = max_X_boundary;
        }
        else if (pos.x < min_X_boundary)
        {
            pos.x = min_X_boundary;
        }
        else if (pos.y > max_Y_boundary)
        {
            pos.y = max_Y_boundary;
        }
        else if (pos.y < min_Y_boundary)
        {
            pos.y = min_Y_boundary;
        }


        transform.position = pos;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
        }
        
    }
    public void shoot()
    {
        
    }
    /*public void Load_Game_Over_Scene()
    {
        SceneManager.LoadScene("GAME_OVER_TEXT");
        
    }*/
    
    public void on_destruction()
    {
        //fire_destruction.Play();
        GameObject.FindWithTag("Destruction_Sound").GetComponent<AudioSource>().Play();
        
            life_points -= 0.2f;
      

    }
  
   
}
