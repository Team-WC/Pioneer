using UnityEngine;
using System.Collections;

public class PlanetColor : MonoBehaviour
{
    TimeCount timeCount;

    // Stage Time
    public float playTime = 60f;

    // 행성 RGB
    Color baseColor;
    float baseR = 0f, baseG = 0f, baseB = 0f;
    float r, g, b;

    // 자식 Material을 받아오기 위한 변수
    Renderer[] rend;
    
    void Awake()
    {
        timeCount = GameObject.Find("Player").GetComponent<TimeCount>();

        rend = GetComponentsInChildren<Renderer>();
        baseColor = rend[0].material.color;
        r = baseColor.r / playTime;
        g = baseColor.g / playTime;
        b = baseColor.b / playTime;

        for(int i = 0; i < rend.Length; i++)
        {
            rend[i].material.color = new Color(baseR, baseG, baseB);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timeCount.timer <= playTime)
        {
            for (int i = 0; i < rend.Length; i++)
            {
                rend[i].material.color = new Color(r * timeCount.timer, g * timeCount.timer, b * timeCount.timer);
            }
        }
    }
}
