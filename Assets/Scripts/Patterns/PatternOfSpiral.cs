using UnityEngine;
using System.Collections;

public class PatternOfSpiral : PatternSetting
{
    public IEnumerator Start()
    {
        bullet.shotSpeed = 2f;
        bullet.aliveTime = 4f;

        shotAngle = -180;
        shotAngleRate = 7f;
        interval = 0.01f;

        while (true)
        {
            Instantiate(bullet, transform.position, Quaternion.Euler(0, shotAngle, 0));

            shotAngle += shotAngleRate;

            yield return new WaitForSeconds(interval);
        }
    }
}
