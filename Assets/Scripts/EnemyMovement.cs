using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 1f;
    Rigidbody2D myRigidBody;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        myRigidBody.velocity = new Vector2(MoveSpeed , 0f);
    }

    void OnTriggerExit2D(Collider2D other) {
        MoveSpeed = -MoveSpeed;
        FlipEnemyFacing();
    }

    void FlipEnemyFacing(){
        transform.localScale = new Vector2 (-(Mathf.Sign(myRigidBody.velocity.x)), 1f);
    }
}
