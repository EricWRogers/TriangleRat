using UnityEngine;
using UnityEngine.SceneManagement; // Added this fro testing the Pause scene.

public class PlayerPause : MonoBehaviour
{
    public void Update() //Game updates 1 frame per second.
    {
        // If the player presses escape, then the gaem switches scene the PauseTestScene.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            transform.GetChild(0).gameObject.SetActive(
                !transform.GetChild(0).gameObject.activeSelf
            );
            //Tranforms its first child from false to true and true to false
        }
    }

    public void MainMenu()
    {
        //Should return to the main menu.
        Debug.Log("The [Main Menu] button has been recieved");
        SceneManager.LoadScene("Wills_Scene");
    }
}
