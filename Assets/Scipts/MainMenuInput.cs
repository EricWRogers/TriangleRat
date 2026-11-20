using UnityEngine;
using UnityEngine.SceneManagement; // Added for operations of Main Menu Scene.

public class MainMenu : MonoBehaviour
{
    public void PlayGame() // When a certain action implements "PlayGame()"...
    {
        // ...it Loads the player scene and logs the change.
        Debug.Log("Requesting to start game has been received!");
        SceneManager.LoadScene("PlayerSceneTest");
    }

    public void QuitGame() // When a certain action implements "QuitGame()"...
    {
        // ... it exits the whole game and logs the change.
        Debug.Log("Requesting to quit game has been received!");
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
