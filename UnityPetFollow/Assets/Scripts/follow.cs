
using UnityEngine;

public class follow : MonoBehaviour
{
    [Header("目標")]
    public Transform target;
    [Header("追蹤速度")]
    public float speed = 1.5F;
    private void followperson()
    {
        Vector3 p1 = transform.position;
        Vector3 p2 = target.position;
        p1 = Vector3.Lerp(p1, p2, speed*Time.deltaTime);

        transform.position = p1;

    }

    public void LateUpdate()
    {
        followperson();
    }
}
