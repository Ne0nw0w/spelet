using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrthoScript : MonoBehaviour
{
    //public SpriteRenderer board;
    // Start is called before the first frame update
    void Update()
    {
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float targetRatio = 10 / 10;

        if (screenRatio >= targetRatio)
        {
            Camera.main.orthographicSize = 10 / 2;
        }
        else
        {
            float differenceInSize = targetRatio / screenRatio;
            Camera.main.orthographicSize = 10 / 2 * differenceInSize;
        }

        
    }

}
