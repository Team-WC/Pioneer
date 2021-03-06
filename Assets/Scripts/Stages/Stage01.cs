﻿using UnityEngine;
using System.Collections;

public class Stage01 : MonoBehaviour
{
    public float playTime = 30f;

    TimeCount timeCount;
    PatternManager patternManager;

    // 패턴 생성 삭제 단계
    bool[] phase = new bool[4];

    void Awake()
    {
        timeCount = GameObject.Find("Player").GetComponent<TimeCount>();
        patternManager = this.gameObject.GetComponent<PatternManager>();

        for (int i = 0; i < phase.Length; i++)
            phase[i] = false;

        StartCoroutine(UpdateByUsingCoroutine());
    }

    IEnumerator UpdateByUsingCoroutine()
    {
        while (true)
        {
            if (phase[0] == false && timeCount.timer > 3)
            {
                patternManager.PatternGenerate(0, 0);
                phase[0] = true;
            }
            else if (phase[1] == false && timeCount.timer > 13)
            {
                patternManager.PatternDelete(0);
                phase[1] = true;
            }
            else if (phase[2] == false && timeCount.timer > 15)
            {
                patternManager.PatternGenerate(0, 1);
                phase[2] = true;
            }
            else if (phase[3] == false && timeCount.timer > 28)
            {
                patternManager.PatternDelete(0);
                phase[3] = true;
            }

            yield return new WaitForSeconds(0.2f);
        }
    }
}
