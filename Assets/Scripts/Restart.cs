using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public string zeroLevel;
    public string firstLevel;

    // Start is called before the first frame update

    void Start()
    {

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(zeroLevel);
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(firstLevel);
    }
    
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
