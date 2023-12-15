using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{

    [SerializeField]
    private GameObject[] spellPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    protected override void Update()
    {
        getInp();

        base.Update();
    }

    
     void getInp()
    {
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction.y = 1;
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction.x = -1;
           
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction.y = -1;
            

        }
        if (Input.GetKey(KeyCode.D))
        {
            direction.x = 1;

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Attack());
        }
    }

    private IEnumerator Attack()
    {
        yield return new WaitForSeconds(1);
        CastSpell();
    }

    public void CastSpell()
    {
        Instantiate(spellPrefab[0], transform.position, Quaternion.identity);
        
    }

}
