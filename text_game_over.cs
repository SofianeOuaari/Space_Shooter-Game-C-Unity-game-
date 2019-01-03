using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class text_game_over : MonoBehaviour {
    private TextMeshProUGUI text;
	// Use this for initialization
	void Start () {
        text.text = "GameOver";
	}
	
	// Update is called once per frame
	public void message_game_over() { 
        
            text.text = "GAMEOVER";
            Debug.Log(text);
        
	}
}
