using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LIFE_POINTS_SCRIPT : MonoBehaviour {
    private Scrollbar x;
	// Use this for initialization
	void Start () {
        x = GetComponent<Scrollbar>();
	}
	
	// Update is called once per frame
	void Update () {
        x.size = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Script>().life_points;
        if (x.size ==0)
        {
            player_destruction();
        }
	}
    /*public void load_game_over_scene()
    {
        SceneManager.LoadScene("GAME_OVER_TEXT");
    }*/
    public void player_destruction()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if ( player!= null)
        {
            Destroy(player);
            SceneManager.LoadScene("GAME_OVER_TEXT");

        }
    }
}
