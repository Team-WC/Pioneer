using UnityEngine;
using System.Collections;

public class PatternOfAiming : PatternSetting
{
    Vector3 target;

    public IEnumerator Start()
    {
        bullet.shotSpeed = 4f;
        bullet.aliveTime = 4f;

        shotAngle = 0f;
        interval = 1f;

        // 플레이어와의 각도
        float playerAngle;

        while (true)
        {
            target = GameObject.Find("Player").transform.position / 2;
            Vector3 relative = transform.InverseTransformPoint(target);
            playerAngle = Mathf.Atan2(relative.x, relative.z) * Mathf.Rad2Deg;

            Instantiate(bullet, transform.position, Quaternion.Euler(0, playerAngle, 0));

            yield return new WaitForSeconds(interval);
        }
    }
}
