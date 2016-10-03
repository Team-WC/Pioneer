using UnityEngine;
using System.Collections;

public class PatternOfOvertaking : PatternSetting
{
    public IEnumerator Start()
    {
        bullet.shotSpeed = 2.3f;
        bullet.aliveTime = 4.5f;

        shotAngle = 0f;
        shotAngleRate = 20f;
        shotCount = 6f;
        interval = 0.07f;

        float groupAngle = 1.5f;
        float groupCount = 10f;
        float groupInterval = 0.06f;

        while (true)
        {
            for (int j = 0; j < groupCount; j++)
            {
                for (int i = 0; i < shotCount; i++)
                {
                    Instantiate(bullet, transform.position, Quaternion.Euler(0, shotAngle + groupAngle * j, 0));
                    bullet.shotSpeed += 0.03f;
                    shotAngle += 60f;
                }
                yield return new WaitForSeconds(groupInterval);
            }

            shotAngle += shotAngleRate;
            bullet.shotSpeed = 2f;

            yield return new WaitForSeconds(interval);
        }
    }
}
