using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public Camera cam;
    public Vector3 posLevel = new Vector3(-0.5f, 3, -10);
    public Vector3 posLevelHard = new Vector3(-0.5f, 5, -10);

    public void SetSizeCamera()
    {
        if (LevelManager.Ins.isNextLevel)
        {
            cam.orthographicSize = Mathf.Clamp(4.25f / Screen.width * Screen.height, 7, 30);
            cam.transform.position = posLevelHard;
        }
        else
        {
            cam.orthographicSize = Mathf.Clamp(5.625f / Screen.width * Screen.height, 7, 30);
            cam.transform.position = posLevel;
        }        
    }
}
