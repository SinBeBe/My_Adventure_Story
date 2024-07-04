using UnityEditor.Animations;
using UnityEngine;

public class NPCAnimation : NPCAnimationBase
{
    [SerializeField]
    private AnimationClip clip;

    private Animator animator;

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
        animator.Play(clip.name);
    }
}
