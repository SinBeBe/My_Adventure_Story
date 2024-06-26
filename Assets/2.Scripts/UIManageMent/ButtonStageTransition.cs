using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// ButtonStageTransition은 StageTransitionBase를 상속받아 버튼 클릭 시 스테이지를 전환합니다.
/// </summary>
public class ButtonStageTransition : StageTransitionBase
{
    [SerializeField]
    private Button transitionButton;

    /// <summary>
    /// 초기화 메서드
    /// </summary>
    private void Start()
    {
        //버튼 클릭 이벤트에 OnButtonClick 메서드를 연결
        if(transitionButton != null)
        {
            transitionButton.onClick.AddListener(OnButtonClick);
        }
    }

    /// <summary>
    /// 버튼 클릭시 호출되는 이벤트
    /// </summary>
    protected override void OnButtonClick()
    {
        TransitionToNextStage();
    }

    /// <summary>
    /// 다음 스테이지로 전환하는 메서드
    /// </summary>
    public override void TransitionToNextStage()
    {
        //현재 씬 인덱스를 가져오고, 다음 씬으로 전환
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
