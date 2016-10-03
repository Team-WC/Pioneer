using UnityEngine;
using System.Collections;

public class PatternOfBidirectionalSpiral : PatternSetting
{
    public IEnumerator Start()
    {
        bullet.shotSpeed = 2f;
        bullet.aliveTime = 4f;

        shotAngle = 0f;
        float shotAngle2 = 180f;
        shotAngleRate = 6f;
        float shotAngleRate2 = -4;
        shotCount = 3f;
        interval = 0.03f;

        while (true)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < shotCount; i++)
                {
                    Instantiate(bullet, transform.position, Quaternion.Euler(0, shotAngle - (360 / shotCount) * i, 0));
                    Instantiate(bullet, transform.position, Quaternion.Euler(0, shotAngle2 - (360 / shotCount) * i, 0));
                }
            }
            shotAngle += shotAngleRate;
            shotAngle2 += shotAngleRate2;


            yield return new WaitForSeconds(interval);
        }
    }
}