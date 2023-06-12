using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : CompentBehaviour
{
    public static GameOverManager Instance { get; private set; }
    [SerializeField] private GameObject mask;
    protected override void Awake()
    {
        base.Awake();
        Instance = this;
    }
    public void GameOver()
    {
        Time.timeScale = 0;
        mask.SetActive(true);
    }    
    public void GameReplay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }    
}
