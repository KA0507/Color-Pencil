using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class LevelManager : Singleton<LevelManager>
{
    public List<Level> levels;
    public List<Level> levelHards;
    public ColorDatas colorDatas;

    internal Level currentLevel;
    private int indexLevel;

    public bool isNextLevel;
    private void Start()
    {
        
    }

    // Tải level
    public void LoadLevel()
    {
        if (currentLevel != null)
        {
            currentLevel.Despawn();
            Destroy(currentLevel.gameObject);
        }

        if (isNextLevel)
        {
            currentLevel = Instantiate(levelHards[DataManager.Ins.dataSaved.indexLevel]);
            currentLevel.OnInit();
        }
        else
        {
            currentLevel = Instantiate(levels[DataManager.Ins.dataSaved.indexLevel]);
            currentLevel.OnInit();
        }       
        GamePlay.Ins.canPlay = true;
    }

    

    private void Update()
    {
        
    }

    public void Victory()
    {
        DataManager.Ins.dataSaved.indexLevel = ++DataManager.Ins.dataSaved.level % levels.Count;

        DOVirtual.DelayedCall(1f, () =>
        {
            UIManager.Ins.OpenUI<UIWin>().OpenUIWin();
        });
    }

    public void Defeat()
    {
        
    }

}
