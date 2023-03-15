using UnityEngine;

public class EnemyController : MonoBehaviour
{
    protected Vector3 dir;
    private SpriteRenderer sprite;
    protected SpriteRenderer flip;
    protected bool _isMove;

    protected void Move()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position + transform.up * 0.1f + transform.right * dir.x * 0.7f, 0.1f);

        if (colliders.Length > 0) dir *= -1f;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, Time.deltaTime);

        if (dir.x != 0)
        {
            flip.flipX = dir.x > 0 ? false : true;
        }

    }


}
