using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public enum GameState {  GameOver, GameStart, GameIdle};
    public static GameState CurrentState = GameState.GameIdle;
    
    
    public static int Score = 0;
    

    void Start()
    {
        
        Score = 0;
        Time.timeScale = 0;
        CurrentState = GameState.GameIdle;
        
    }
    
    void Update()
    {
        if(CurrentState == GameState.GameIdle && Input.GetKeyDown(KeyCode.Return))
        {            
            CurrentState = GameState.GameStart;
            Time.timeScale = 1;
            HUD.HUDManager.DismissMessage();
        }

        else if(CurrentState == GameState.GameOver && Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(0);
        }
    }
    public void retry()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
