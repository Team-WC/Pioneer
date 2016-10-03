using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    // Player Speed
    public float speed = 5f;

    TimeCount timeCount;

    void Awake()
    {
        timeCount = this.gameObject.GetComponent<TimeCount>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 direction1 = new Vector3(transform.right.x * x, transform.right.y * x, transform.right.z * x).normalized;
        Vector3 direction2 = new Vector3(transform.forward.x * z, transform.forward.y * z, transform.forward.z * z).normalized;

        GetComponent<Rigidbody>().velocity = (direction1 + direction2) * speed;

        // y축을 고정하기 위한 코드
        Vector3 fixY = transform.position;
        transform.position = new Vector3(fixY.x, 0, fixY.z);
    }

    void OnTriggerEnter(Collider c)
    {
        // 총알 맞았을때
        if (c.tag == "Bullet")
        {
            Debug.Log("대미지 구현 필요");
            Destroy(c.gameObject);            
        }

        // food 먹었을때
        if (c.tag == "Food")
        {
            timeCount.timer += 10;
            Destroy(c.gameObject);
        }
    }

    private void CheckIfGameOver()
    {
        // GameManager.instance.GameOver();
    }
}
