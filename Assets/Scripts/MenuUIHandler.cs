using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
Class that handles the Title Screen UI.
*/
public class MenuUIHandler : MonoBehaviour
{

    /*
    When called transitions to the MainScene Scene to start the game.
    */
    public void StartGame()
    {
        SceneManager.LoadScene(1); // Load the "main" scene
    }
}
