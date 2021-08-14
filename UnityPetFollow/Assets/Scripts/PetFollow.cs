using UnityEngine;

public class PetFollow : MonoBehaviour
{
    [Header("速度"), Range(0, 1000)]
    public float speed = 1.5f;

    /// <summary>
    /// 要追蹤的玩家
    /// </summary>
    private Transform target;

    void Start()
    {
        target = GameObject.Find("野蠻人").transform;
    }

    void Update()
    {
        Track();
    }

    private void Track()
    {
        Vector3 posTarget = target.position;
        Vector3 posPet = transform.position;
        Vector3 targetRelativeDirection = target.position - transform.position;

        if (targetRelativeDirection.magnitude > 3)
        {
            transform.position = Vector3.Lerp(posPet, posTarget, 0.5f * Time.deltaTime * speed);
        }
    }
