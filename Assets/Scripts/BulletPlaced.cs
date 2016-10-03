using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class BulletPlaced : MonoBehaviour
{
    // Bullet Speed
    public float shotSpeed;
    public float shotSpeed2;
    public float aliveTime;
    
    float timer = 0f;

    Vector3 target;
    // 플레이어와의 각도
    float playerAngle;

    bool flag1;
    bool flag2;

    void Start()
    {
        flag1 = false;
        flag2 = false;

        GetComponent<Rigidbody>().velocity = transform.forward * shotSpeed;

        // 총알 생존 시간
        Destroy(gameObject, aliveTime);
    }

    void Update()
    {
        timer += Time.deltaTime;
        
        if(flag1 == false && timer > 1.5)
        {
            shotSpeed = 0;
            GetComponent<Rigidbody>().velocity = transform.forward * shotSpeed;

            flag1 = true;
        }
        if(flag2 == false && timer > 2.5)
        {
            target = GameObject.Find("Player").transform.position;
            Vector3 relative = transform.InverseTransformPoint(target);
            playerAngle = Mathf.Atan2(relative.x, relative.z) * Mathf.Rad2Deg;

            transform.Rotate(new Vector3(0, transform.rotation.y + playerAngle, 0));

            GetComponent<Rigidbody>().velocity = transform.forward * shotSpeed2;

            flag2 = true;
        }
    }
}
