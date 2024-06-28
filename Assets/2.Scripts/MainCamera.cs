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
        // lookPos를 향하는 방향 벡터를 계산
        Vector3 directionToLook = lookPos.position - transform.position;

        // 방향 벡터를 쿼터니언 회전으로 변환
        Quaternion targetRotation = Quaternion.LookRotation(directionToLook);

        // 카메라의 회전을 타겟 회전으로 설정
        transform.rotation = targetRotation;
    }
}
