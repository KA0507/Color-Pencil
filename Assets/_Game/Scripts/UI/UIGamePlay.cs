using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGamePlay : UICanvas
{
    public Text textLevel;

    public CanvasGroup canvasGroup;
    public void OpenUIGamePlay()
    {
        canvasGroup.DOFade(1f, 0.7f).OnComplete(() =>
        {
            LevelManager.Ins.LoadLevel();
        });
        textLevel.text = Constant.LEVEL + (DataManager.Ins.dataSaved.level + 1);
    }

    public void CloseUIGamePlay(bool b = false)
    {
        canvasGroup.DOFade(0, 0.7f).OnComplete(() =>
        {
            if (b)
            {
                OpenUIGamePlay();
            }
            else
            {
                LevelManager.Ins.currentLevel.Despawn();
                UIManager.Ins.CloseUI<UIGamePlay>();
            }           
        });
    }
}
