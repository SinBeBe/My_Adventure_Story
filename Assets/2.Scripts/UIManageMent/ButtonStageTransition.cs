using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// ButtonStageTransition�� StageTransitionBase�� ��ӹ޾� ��ư Ŭ�� �� ���������� ��ȯ�մϴ�.
/// </summary>
public class ButtonStageTransition : StageTransitionBase
{
    [SerializeField]
    private Button transitionButton;

    /// <summary>
    /// �ʱ�ȭ �޼���
    /// </summary>
    private void Start()
    {
        //��ư Ŭ�� �̺�Ʈ�� OnButtonClick �޼��带 ����
        if(transitionButton != null)
        {
            transitionButton.onClick.AddListener(OnButtonClick);
        }
    }

    /// <summary>
    /// ��ư Ŭ���� ȣ��Ǵ� �̺�Ʈ
    /// </summary>
    protected override void OnButtonClick()
    {
        TransitionToNextStage();
    }

    /// <summary>
    /// ���� ���������� ��ȯ�ϴ� �޼���
    /// </summary>
    public override void TransitionToNextStage()
    {
        //���� �� �ε����� ��������, ���� ������ ��ȯ
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
