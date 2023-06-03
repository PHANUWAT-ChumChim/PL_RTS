using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float Speed = 1;
    private new BoxCollider2D collider2D;
    private void Start()
    {
        collider2D = GetComponent<BoxCollider2D>();
    }
    private void FixedUpdate()
    {
        Movement();
    }
    private void Movement()
    {
        float movex = Input.GetAxisRaw("Horizontal");
        float movey = Input.GetAxisRaw("Vertical");
        Vector2 MoveDelta = new Vector2(movex, movey);
        if (MoveDelta.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (MoveDelta.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        RaycastHit2D hit2D;
        hit2D = Physics2D.BoxCast(transform.position, collider2D.size, 0, new Vector2(movex, 0), Mathf.Abs(movex * Time.fixedDeltaTime), LayerMask.GetMask("Enemy", "Block"));
        if (hit2D.collider)
        {
            MoveDelta.x = 0;
        }
        hit2D = Physics2D.BoxCast(transform.position, collider2D.size, 0, new Vector2(0, movey), Mathf.Abs(movey * Time.fixedDeltaTime), LayerMask.GetMask("Enemy", "Block"));
        if (hit2D.collider)
        {
            MoveDelta.y = 0;
        }

        transform.Translate(MoveDelta * Time.deltaTime * Speed);
    }
}
