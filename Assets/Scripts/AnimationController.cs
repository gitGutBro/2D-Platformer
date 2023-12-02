using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationController : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
        => _animator = GetComponent<Animator>();

    private void Update()
    {
        float move = Input.GetAxis("Horizontal");
        _animator.SetFloat("Speed", Mathf.Abs(move));
    }
}