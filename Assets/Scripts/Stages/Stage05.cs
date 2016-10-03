using UnityEngine;
using System.Collections;

public class Stage05 : MonoBehaviour
{
    public float playTime = 60f;

    TimeCount timeCount;
    PatternManager patternManager;

    // 패턴 생성 삭제 단계
    bool[] phase = new bool[2];

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
            else if (phase[1] == false && timeCount.timer > 57)
            {
                patternManager.PatternDelete(0);
                phase[1] = true;
            }

            yield return new WaitForSeconds(0.2f);
        }
    }
}
