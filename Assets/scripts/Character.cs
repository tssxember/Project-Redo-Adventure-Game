using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField]
    protected float speed;
    protected Vector2 direction;

    void Start()
    {

    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Move();

    }
    protected void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        
    }

   
}
