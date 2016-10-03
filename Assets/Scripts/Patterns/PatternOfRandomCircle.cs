using UnityEngine;
using System.Collections;

public class PatternOfRandomCircle : PatternSetting
{
    public IEnumerator Start()
    {
        bullet.shotSpeed = 2f;
        bullet.aliveTime = 5f;

        shotCount = 2f;
        interval = 0.3f;

        while (true)
        {
            for (int i = 0; i < shotCount; i++)
                Instantiate(bullet, transform.position, Quaternion.Euler(0, Random.Range(0, 360), 0));

            bullet.shotSpeed += 0.01f;

            yield return new WaitForSeconds(interval);
        }
    }
}
