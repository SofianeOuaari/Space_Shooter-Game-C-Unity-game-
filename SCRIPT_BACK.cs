using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCRIPT_BACK : MonoBehaviour {
  public void scene_back()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
