using UnityEngine;
using System.Collections;

public class PatternOfPlaced : PatternSetting
{
    public BulletPlaced bulletPlaced;

    public IEnumerator Start()
    {
        bulletPlaced.shotSpeed = 1f;
        bulletPlaced.shotSpeed2 = 15f;
        bulletPlaced.aliveTime = 6f;

        shotCount = 30;
        shotAngle = 0f;
        interval = 2.5f;
        
        float groupInterval = 0.05f;

        while (true)
        {
            for (int i = 0; i < shotCount; i++)
            {
                Instantiate(bulletPlaced, transform.position, Quaternion.Euler(0, shotAngle + i * 360 / shotCount, 0));

                yield return new WaitForSeconds(groupInterval);
            }

            yield return new WaitForSeconds(interval);
        }
    }   
}
