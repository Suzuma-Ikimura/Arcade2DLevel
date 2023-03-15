using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    public bool isMove { private get; set; }

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        _animator.SetBool("isMove", isMove);
    }
}
