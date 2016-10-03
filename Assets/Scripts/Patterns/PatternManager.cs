using UnityEngine;
using System.Collections;

public class PatternManager : MonoBehaviour
{
    // 패턴 prefabs
    public GameObject[] patterns = new GameObject[5];

    // 패턴 생성 배열 최대 5개 동시생성 가능
    GameObject[] pattern = new GameObject[5];

    public void PatternGenerate(int objNumber, int patternNumber)
    {
        pattern[objNumber] = Instantiate(patterns[patternNumber], transform.position, transform.rotation) as GameObject;
        pattern[objNumber].transform.parent = transform;
    }

    public void PatternDelete(int num)
    {
        Destroy(pattern[num]);
    }

    /* 패턴 테스트
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            PatternGenerate(0, 0);
        }
        if (Input.GetKeyDown("2"))
        {
            PatternDelete(0);
        }
    }
    */
}
