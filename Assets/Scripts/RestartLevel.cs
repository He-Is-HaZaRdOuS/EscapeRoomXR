using UnityEngine;
using UnityEngine.SceneManagement; // Required to manage scenes

public class RestartLevel : MonoBehaviour
{
    // This method restarts the current scene
    public void RestartCurrentLevel()
    {
        // Get the current active scene
        Scene currentScene = SceneManager.GetActiveScene();

        // Reload the current scene
        SceneManager.LoadScene(currentScene.name);
    }
}
