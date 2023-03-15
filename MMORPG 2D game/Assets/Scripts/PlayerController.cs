using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpF = 500f;

    private bool _isMove;
    private bool _jumpA;
    private bool _isFlying;
    private CharacterAnimator anim;
    private SpriteRenderer flip;
    private Rigidbody2D rb;
    private bool _isGround;

    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        flip= GetComponentInChildren<SpriteRenderer>();
        anim= GetComponentInChildren<CharacterAnimator>();
    }

    void FixedUpdate()
    {
        Move();
        Jump();
        Fall();
        //Fight();
    }

/*    private void Fight()
    {
        if (Input.GetMouseButton(0)) { 
            anim.isFight= true;              
        }
        else
            anim.isFight= false;
    }*/

    private void Move()
    {
        float moveH = Input.GetAxisRaw("Horizontal");
        Vector2 movement = new Vector2(moveH, 0.0f);
        _isMove = movement.x != 0 ? true : false;

        transform.Translate(movement * speed * Time.fixedDeltaTime);

        if(movement.x != 0) {
            flip.flipX = movement.x > 0 ? false : true; }

        anim.isMoving = _isMove;
        anim.isMoveBow = _isMove;
    }

    private void Jump()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            if (_isGround)
            {
                _jumpA = Input.GetAxis("Jump") != 0 ? true : false;
                rb.AddForce(Vector3.up * jumpF);
            }
            else
            {
                _jumpA = false;
            }
            anim.jumpA = _jumpA;
            anim.isJumpBow = _jumpA;
        }
    }

    private void Fall()
    {
        if (!_isGround)
        {
            _isFlying = true;
        }
        else
        {
            _isFlying= false;
        }
        anim.IsFlying = _isFlying;
        anim._isFlyingBow = _isFlying;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        IsGroundUpdate(collision, true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        IsGroundUpdate(collision, false);
    }
    
    private void IsGroundUpdate(Collision2D collision, bool value)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGround = value;
        }
    }

}
