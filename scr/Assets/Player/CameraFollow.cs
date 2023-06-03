using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public Transform transget;
    void Update()
    {
        Vector3 Pos = new Vector3(transget.position.x, transget.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, Pos, FollowSpeed * Time.deltaTime);
    }
    //[SerializeField]
    //private Transform Player;
    //[SerializeField]
    //private float BoundX = 1;
    //[SerializeField]
    //private float BoundY = 2;

    //private void LateUpdate()
    //{
    //    FollowPlayer();
    //}

    //void FollowPlayer()
    //{
    //    Vector2 moveDriection = Vector2.zero;
    //    float Deltex = Player.position.x - transform.position.x;
    //    float Deltey = Player.position.y - transform.position.y;

    //    if (Deltex > BoundX || Deltex < -BoundX)
    //    {
    //        if (Player.position.x > transform.position.x)
    //        {
    //            moveDriection.x = Deltex - BoundX;
    //        }
    //        else
    //        {
    //            moveDriection.x = Deltex + BoundX;
    //        }
    //    }
    //    if (Deltey > BoundY || Deltey < -BoundY)
    //    {
    //        if (Player.position.y > transform.position.y)
    //        {
    //            moveDriection.y = Deltex - BoundY;
    //        }
    //        else
    //        {
    //            moveDriection.y = Deltex + BoundY;
    //        }
    //    }
    //    transform.position += new Vector3(moveDriection.x, moveDriection.y, 0);
    //}
}
