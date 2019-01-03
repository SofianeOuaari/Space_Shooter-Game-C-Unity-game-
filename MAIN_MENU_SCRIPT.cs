using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MAIN_MENU_SCRIPT : MonoBehaviour
{
    //private GameObject loading_bar = GameObject.FindGameObjectWithTag("Loading_Bar");
    //private Slider slider = GameObject.FindWithTag("Loading_Bar").GetComponent<Slider>();
    public void Play()
    {
        SceneManager.LoadScene("SPACE_SHOOTER");
    }
    /*IEnumerator loadasync()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        GameObject.FindWithTag("Loading_Bar").SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            //Debug.Log(operation.progress);
            slider.value = progress;
            yield return null;
        }
    }*/
    public void Quit()
    {
        Application.Quit();
    }
    public void instructions()
    {
        SceneManager.LoadScene("INSTRUCTIONS");
    }
}
