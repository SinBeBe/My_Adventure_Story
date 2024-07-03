using UnityEngine;

public class NPCAnimation : NPCAnimationBase
{
    private Animator animator;

    [SerializeField]
    private string aniName;

    private void Awake()
    {
        animator = this.GetComponent<Animator>();
    }

    private void Start()
    {
        PlayIdleAni();
    }

    public override void PlayIdleAni()
    {
        animator.Play(aniName);
    }
}
