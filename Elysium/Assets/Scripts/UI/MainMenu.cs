using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayChess()
    {
        GameManager.gameMode = GameModes.CHESS;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayRandomChess()
    {
        GameManager.gameMode = GameModes.RANDOMCHESS;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayOverthrow()
    {
        GameManager.gameMode = GameModes.OVERTHROW;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayKnightsRoyalty()
    {
        GameManager.gameMode = GameModes.KNIGHTSROYALTY;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Game Exited");
        Application.Quit();
    }
}
