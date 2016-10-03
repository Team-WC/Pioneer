using UnityEngine;
using System.Collections;

public class PatternOfRandomCircleHell : PatternSetting
{
    public IEnumerator Start()
    {
        bullet.shotSpeed = 5f;
        bullet.aliveTime = 4f;

        shotCount = 5f;
        interval = 0.3f;

        while (true)
        {
            for (int i = 0; i < shotCount; i++)
                Instantiate(bullet, transform.position, Quaternion.Euler(0, Random.Range(0, 360), 0));

            yield return new WaitForSeconds(interval);
        }
    }
}
