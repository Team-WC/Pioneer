using UnityEngine;
using System.Collections;

public class PatternOfWaving : PatternSetting
{
    Vector3 target;

    public IEnumerator Start()
    {
        bullet.shotSpeed = 4f;
        bullet.aliveTime = 3f;

        shotAngleRate = 7f;
        shotCount = 5f;
        interval = 0.05f;
        
        shotAngleRange = 25f;

        // 진동 범위
        float wavingAngleRange = 20f;
        float cycle = 30f;
        float time = 0f;

        // 플레이어와의 각도
        float playerAngle;

        while (true)
        {
            target = GameObject.Find("Player").transform.position;
            Vector3 relative = transform.InverseTransformPoint(target);
            playerAngle = Mathf.Atan2(relative.x, relative.z) * Mathf.Rad2Deg;

            Debug.Log(playerAngle);

            for (int i = 0; i < shotCount; i++)
                Instantiate(bullet, transform.position, 
                    Quaternion.Euler(0, playerAngle + wavingAngleRange * Mathf.Sin(Mathf.PI * 2 * time/cycle) + (shotAngleRange * i), 0));

            time = (time + 1) % cycle;

            yield return new WaitForSeconds(interval);
        }
    }
}
