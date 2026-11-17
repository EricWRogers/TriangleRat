using UnityEngine;
using UnityEngine.SceneManagement; // Added for operations of Main Menu Scene.

public class MainMenu : MonoBehaviour
{
    public void PlayGame() // When a certain action implements "PlayGame()"...
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        /* Scene Management loads scene of current active scene, by using the build index number 
        plus 1 from build settings; This would mean its loading the next scene after the first one.
        */
    }

    public void QuitGame() // When a certain action implements "QuitGame()"...
    {
        // Logs a message to the Unity Console to show it has been received.
        Debug.Log("Requesting to quit game has been received!");

        Application.Quit(); // Quits the players application of runtime inside the game.
        UnityEditor.EditorApplication.isPlaying = false;
        //Unity Editor goes to aplliations of Play Mode and turns it false to stop playing.
    }
}
