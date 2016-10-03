using UnityEngine;
using System.Collections;

public class Stage04 : MonoBehaviour
{
    public float playTime = 60f;

    TimeCount timeCount;
    PatternManager patternManager;

    // 패턴 생성 삭제 단계
    bool[] phase = new bool[10];

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
            if (phase[0] == false && timeCount.timer > 2)
            {
                patternManager.PatternGenerate(0, 0);
                patternManager.PatternGenerate(1, 1);
                phase[0] = true;
            }
            else if (phase[1] == false && timeCount.timer > 10)
            {
                patternManager.PatternDelete(0);
                patternManager.PatternDelete(1);
                phase[1] = true;
            }
            else if (phase[2] == false && timeCount.timer > 12)
            {
                patternManager.PatternGenerate(0, 2);
                phase[2] = true;
            }
            else if (phase[3] == false && timeCount.timer > 20)
            {
                patternManager.PatternDelete(0);
                phase[3] = true;
            }
            else if (phase[4] == false && timeCount.timer > 22)
            {
                patternManager.PatternGenerate(0, 0);
                patternManager.PatternGenerate(1, 0);
                patternManager.PatternGenerate(2, 0);
                phase[4] = true;
            }
            else if (phase[5] == false && timeCount.timer > 33)
            {
                patternManager.PatternDelete(0);
                patternManager.PatternDelete(1);
                patternManager.PatternDelete(2);
                phase[5] = true;
            }
            else if (phase[6] == false && timeCount.timer > 35)
            {
                patternManager.PatternGenerate(0, 2);
                patternManager.PatternGenerate(1, 3);
                phase[6] = true;
            }
            else if (phase[7] == false && timeCount.timer > 47)
            {
                patternManager.PatternDelete(0);
                patternManager.PatternDelete(1);
                phase[7] = true;
            }
            else if (phase[8] == false && timeCount.timer > 49)
            {
                patternManager.PatternGenerate(0, 4);
                phase[8] = true;
            }
            else if (phase[9] == false && timeCount.timer > 60)
            {
                patternManager.PatternDelete(0);
                phase[9] = true;
            }

            yield return new WaitForSeconds(0.2f);
        }
    }
}
