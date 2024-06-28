using UnityEngine;

public class MainCamera : CameraBase
{
    [SerializeField]
    private Transform followPos;
    [SerializeField]
    private Transform lookPos;

    private Vector3 _cameraPos;
    private Vector3 cameraPos
    {
        get
        {
            return _cameraPos;
        }
        set
        {
            _cameraPos = value;
            transform.position = _cameraPos;
        }
    }


    private float followSpeed = 5f;

    private void Awake()
    {
        cameraPos = transform.position;
    }

    private void Update()
    {
        Follow();
        LookPlayer();
    }

    public override void Follow()
    {
        cameraPos = Vector3.Lerp(cameraPos, followPos.position, followSpeed * Time.deltaTime);
    }

    public override void LookPlayer()
    {
        // lookPos�� ���ϴ� ���� ���͸� ���
        Vector3 directionToLook = lookPos.position - transform.position;

        // ���� ���͸� ���ʹϾ� ȸ������ ��ȯ
        Quaternion targetRotation = Quaternion.LookRotation(directionToLook);

        // ī�޶��� ȸ���� Ÿ�� ȸ������ ����
        transform.rotation = targetRotation;
    }
}
