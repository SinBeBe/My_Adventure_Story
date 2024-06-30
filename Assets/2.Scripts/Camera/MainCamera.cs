using UnityEngine;

public class MainCamera : CameraBase
{
    [SerializeField]
    private Transform objectTofollow;
    [SerializeField]
    private Transform realCamera;
    [SerializeField]
    private Vector3 dirNormalized;
    [SerializeField]
    private Vector3 finalDir;

    private float followSpeed = 10f;
    private float sensitivity = 100f;
    private float clampAngle = 70f;
    private float smoothness = 10f;
    private float minDistance;
    private float maxDistance;
    private float finalDistance;

    private float rotX;
    private float rotY;

    private void Start()
    {
        rotX = transform.localRotation.eulerAngles.x;
        rotY = transform.localRotation.eulerAngles.y;

        dirNormalized = realCamera.localPosition.normalized;
        finalDistance = realCamera.localPosition.magnitude;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        LookPlayer();
    }

    private void LateUpdate()
    {
        CameraMove();
    }

    public override void CameraMove()
    {
        transform.position = Vector3.MoveTowards(transform.position, objectTofollow.position, followSpeed * Time.deltaTime);
        finalDir = transform.TransformPoint(dirNormalized * maxDistance);

        RaycastHit hit;
        if(Physics.Linecast(transform.position, finalDir, out hit))
        {
            finalDistance = Mathf.Clamp(hit.distance, minDistance, maxDistance);
        }
        else
        {
            finalDistance = maxDistance;
        }
        realCamera.localPosition = Vector3.Lerp(realCamera.localPosition, dirNormalized * finalDistance, Time.deltaTime * smoothness);
    }

    public override void LookPlayer()
    {
        rotX += -(Input.GetAxis("Mouse Y")) * sensitivity * Time.deltaTime;
        rotY += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

        rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);
        Quaternion rot = Quaternion.Euler(rotX, rotY, 0);
        transform.rotation = rot;
    }
}
