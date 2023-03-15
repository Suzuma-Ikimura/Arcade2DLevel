using UnityEngine;

public class EnemySkeletWarrior : EnemyController
{

    private EnemyAnimator anim;

    private void Start()
    {
        dir = transform.right;
        flip = GetComponentInChildren<SpriteRenderer>();
        anim = GetComponentInChildren<EnemyAnimator>();
    }

    private void Update()
    {
        Move();
        AnimationW();
    }
    private void AnimationW()
    {
        if(dir.x > 0f)
            _isMove= true;
        else if (dir.x < 0f)
            _isMove = true;
        else
            _isMove= false;
        anim.isMove = _isMove;
    }
}
