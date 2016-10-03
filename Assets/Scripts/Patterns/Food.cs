using UnityEngine;
using System.Collections;

public class Food : PatternSetting
{
    public IEnumerator Start()
    {
        bullet.shotSpeed = 3f;
        bullet.aliveTime = 4f;
        interval = 1f;

        while (true)
        {
            Instantiate(bullet, transform.position, Quaternion.Euler(0, Random.Range(0, 360), 0));

            yield return new WaitForSeconds(interval);
        }
    }
}
