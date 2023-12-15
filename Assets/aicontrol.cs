using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aicontrol : MonoBehaviour
{

    private Transform target;
    private float speed = .5f;
    private float range = 1f;
    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<Player>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) <= range)
        {
            FollowPlayer();
        }
    }

    void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }
}
