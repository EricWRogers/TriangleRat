using UnityEngine;
using UnityEngine.SceneManagement; // Added this for testing the Pause scene.

public class PlayerPause : MonoBehaviour
{
    // Game updates 1 frame per second.
    public void Update()
    {
        // If the player presses [Esc], then the game pauses.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Logs the [Esc] key and switches pause/resume.
            Debug.Log("Pause/Resume button has been recieved");
            transform.GetChild(0).gameObject.SetActive(
                !transform.GetChild(0).gameObject.activeSelf
            );
        }
    }

    public void MainMenu()
    {
        //Should return to the main menu and log it.
        Debug.Log("The [Main Menu] button has been recieved");
        SceneManager.LoadScene("Wills_Scene");
    }
}
