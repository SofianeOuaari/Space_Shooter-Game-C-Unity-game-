using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        AudioSource main_music = GetComponent<AudioSource>();
        Slider s = GameObject.Find("Slider").GetComponent<Slider>();
        main_music.volume = s.value;
	}
}
