using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float Speed;
    private float _horizontal;
    private float _vertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        int LM = 1 << 8;
        LM = ~ LM;

        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

        transform.position = new Vector2(transform.position.x + _horizontal * Speed,transform.position.y + _vertical * Speed);

        Vector2 direction = new Vector2(_horizontal * 50, _vertical * 50);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, 1000f, 1);

        if (hit.collider != null)
        {
            Debug.DrawRay(transform.position, direction, Color.red);
            Debug.Log(hit.collider.name);
        }
        else
        {
            Debug.DrawRay(transform.position, direction, Color.white);
            Debug.Log("Not detected hit");
        }
    }
}
