using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class REPLAY_BUTTON_SCRIPT : MonoBehaviour {

	public void replay_scene()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
