using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIFunction : MonoBehaviour
{
    public AudioSource click;
    private string goalSceneName;

    public void LoadScene(string name)
    {
        click.Play();
        goalSceneName = name;
        Invoke("Load", .3f);
    }

    private void Load()
    {
        SceneManager.LoadScene(goalSceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
