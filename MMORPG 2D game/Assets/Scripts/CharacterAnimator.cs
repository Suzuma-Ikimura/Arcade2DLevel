using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{
    public bool isMoving { private get; set; }
    public bool IsFlying { private get; set; }
    public bool jumpA { private get; set; }
    public bool isDie { private get; set; }
    public bool isMoveBow { private get; set; }
    public bool isJumpBow { private get; set; }
    public bool _isFlyingBow { private get; set; }
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        _animator.SetBool("isMoving", isMoving);
        _animator.SetBool("IsFlying", IsFlying);
        _animator.SetBool("jumpA", jumpA);
        _animator.SetBool("isDie", isDie);

        _animator.SetBool("isMoveBow", isMoveBow);
        _animator.SetBool("isJumpBow", isJumpBow);
        _animator.SetBool("_isFlyingBow", _isFlyingBow);


    }

}
