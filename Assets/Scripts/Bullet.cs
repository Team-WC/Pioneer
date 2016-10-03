using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    // Bullet Speed
    public float shotSpeed;
    public float aliveTime;

    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * shotSpeed;
        
        // 총알 생존 시간
        Destroy(gameObject, aliveTime);
    }
}
