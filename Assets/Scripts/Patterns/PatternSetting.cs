using UnityEngine;
using System.Collections;

public class PatternSetting : MonoBehaviour
{
    public Bullet bullet;
    
    // 발사 각도
    protected float shotAngle;
    // 발사 각속도
    protected float shotAngleRate;
    // 발사 수
    protected float shotCount;
    // 발사 딜레이
    protected float interval;

    // 탄 각속도
    protected float bulletAngleRate;
    // 탄 가속도
    protected float bulletSpeedRate;

    // 발사 각도 범위
    protected float shotAngleRange;
}
