using UnityEngine;
using System.Collections;

public class PatternOfMultipleSpiral : PatternSetting
{
    public IEnumerator Start()
    {
        bullet.shotSpeed = 2f;
        bullet.aliveTime = 4f;

        shotAngle = 0f;
        shotAngleRate = 7f;
        shotCount = 3f;
        interval = 0.03f;

        while (true)
        {
            for (int i = 0; i < shotCount; i++)
                Instantiate(bullet, transform.position, Quaternion.Euler(0, shotAngle - (360 / shotCount) * i, 0));

            shotAngle += shotAngleRate;

            yield return new WaitForSeconds(interval);
        }
    }
}
