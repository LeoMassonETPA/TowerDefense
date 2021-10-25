
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public static GameManager instance { get; private set; }


    public enum GameState
    {
        PREPARATION,
        RUNNING,
        END
    }

    public float _preparationTime = 10;
    private float preparationTime {  get { return _preparationTime; } }

    private float gameTimer { get; set; } = 0;

    private GameState gameState { get; set; } = GameState.PREPARATION;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {

    }


    private void Update()
    {
        switch (gameState)
        {
            case GameState.PREPARATION:
                gameTimer += Time.deltaTime;
                if(gameTimer >= _preparationTime)
                {
                    gameTimer = 0;
                    gameState = GameState.RUNNING;
                }
                break;
            case GameState.RUNNING:
                break;
            case GameState.END:
                break;
        }
    }
}