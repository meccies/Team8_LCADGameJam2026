using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderManager : MonoBehaviour
{
    // Add this script to Canvas gameobject, then click and drag Canvas gameobject into the OnClick() selector'

    public void LoadTitleScreen()
    {
        SceneManager.LoadScene("Title Screen");
        Debug.Log("Loading title screen");
    }

    public void LoadMainLevel()
    {
        SceneManager.LoadScene("Main Level");
        Debug.Log("Loading main level");
    }

    public void MyQuit()
    {
        Application.Quit();
        Debug.Log("Game quitting");
    }
}
