using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { GAMEPLAY, PAUSE, FINISH }

public class GameManager : Singleton<GameManager>
{

    public GameState state;

    public bool IsState(GameState state) => this.state == state;

    // Start is called before the first frame update
    void Start()
    {
        UIManager.Ins.OpenUI<UILoading>().OpenUILoading();
    }

    public void ChangeState(GameState state)
    {
        this.state = state;
    }
}
