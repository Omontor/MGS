using System;
using UnityEngine;

public enum GameState
{
    Normal,
    Investigate,
    Alert,
    Chase,
    GameOver
}
public class GameManager : MonoBehaviour
{
    //variables
    [SerializeField] private GameState gameState;
    [SerializeField] private float elapsedTime;
    [SerializeField] private float alertTimer;
    
    
    [SerializeField] private MusicManager musicManager;
    [SerializeField] private LevelManager levelManager;
    [SerializeField] private InventoryManager inventoryManager;
    
    
    private void Start()
    {
        musicManager.Init();
        musicManager.PlayMusic(levelManager.GetLevelMusic());
    }


    public GameState GetGameState()
    {
        return gameState;
    }
}
