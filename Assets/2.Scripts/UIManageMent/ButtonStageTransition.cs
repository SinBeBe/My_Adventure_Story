using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonStageTransition : StageTransitionBase
{
    [SerializeField]
    private Button transitionButton;


    private void Start()
    {
        if(transitionButton != null)
        {
            transitionButton.onClick.AddListener(OnButtonClick);
        }
    }

    protected override void OnButtonClick()
    {
        TransitionToNextStage();
    }

    public override void TransitionToNextStage()
    {
        //���� �� �ε����� ��������, ���� ������ ��ȯ
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
