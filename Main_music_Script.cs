using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_music_Script : MonoBehaviour {
    [SerializeField] private AudioSource m;
	// Use this for initialization
	void Start () {
        m = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        m.Play();
	}
}
