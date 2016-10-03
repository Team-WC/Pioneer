using UnityEngine;
using System.Collections;

public class TimeCount : MonoBehaviour
{
    // 제한 시간
    public float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }
}
