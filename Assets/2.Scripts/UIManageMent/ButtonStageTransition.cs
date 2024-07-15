using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonStageTransition : StageTransitionBase
{
    [SerializeField]
    private GameObject helpUI;

    [SerializeField]
    private Button transitionButton;

    private int count = 0;

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
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }

    public void OnClickButton()
    {
        count++;
        if(count < 2)
        {
            OnOff(helpUI, true);
        }
        else
        {
            OnOff(helpUI, false);
            count = 0;
        }
    }

    public override void OnOff(GameObject gameObject, bool value)
    {
        gameObject.SetActive(value);
    }
}
