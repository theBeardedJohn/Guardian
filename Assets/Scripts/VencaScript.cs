using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VencaScript : MonoBehaviour
{

    [SerializeField] float defaultScoreSize;
    [SerializeField] float maxScoreSize;
    [SerializeField] float scoreSizeSpeed;
    private float scoreSize;
    private bool scoreSizeBool;

    void ScoreSizeUp() 
    {
        scoreSize += scoreSize * scoreSizeSpeed;
    
    }

    void ScoreSizeDown()
    {
        scoreSize -= scoreSize * scoreSizeSpeed;

    }


    void ScoreSizeBoolSwitcher()
    {
        scoreSizeBool = true;
        Invoke("ScoreSizeBoolReset", 1);

    }

    void ScoreSizeBoolReset()
    {
        scoreSizeBool = false;


    }


    void Update()
    {
        
        scoreSize = Mathf.Clamp(scoreSize, defaultScoreSize, maxScoreSize);

        if (scoreSizeBool = true && scoreSize != maxScoreSize) 
        {
            ScoreSizeUp();
        
        }

        else if (scoreSizeBool = false && scoreSize != defaultScoreSize)
        {
            ScoreSizeDown();

        }


    }
}
