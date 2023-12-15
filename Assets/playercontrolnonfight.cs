using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrolnonfight : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float speed = .5f;
    Vector2 move;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        

    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");

      
    }

    void FixedUpdate()
    {

        rb2d.MovePosition(rb2d.position + move * speed * Time.fixedDeltaTime);

    }

    private IEnumerator Attack()
    {

        yield return new WaitForSeconds(3);

    }
}
