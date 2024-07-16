using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace memstow
{
    public class CameraMove : MonoBehaviour
    {

        //public float moveSpeed = 4f;
        public float yOffset = 6f;
        public float xOffset = 0f;
        public Transform target;
        public float moveLeftLimit = -30.0f;
        public float moveRightLimit = 30.0f;

        private Vector3 velocity = Vector3.zero;
        private float smoothTime = 0.25f;
        private Rigidbody2D rb;
        private float yOffsetShift = 0f;
        private float xOffsetShift = 0f;
        private const float yOffsetMax = 20f;
        private const float xOffsetMax = 10f;


        // Start is called before the first frame update
        void Start()
        {
            rb = target.GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            float targetPosX;

            if (rb.velocity.y != 0)
            {
                yOffsetShift = (rb.velocity.y * 0.3f) + yOffset;

            }
            else
            {
                yOffsetShift = yOffset;
            }

            if (rb.velocity.x != 0)
            {
                xOffsetShift = (rb.velocity.x * 0.5f) + xOffset;
            }
            else
            {
                xOffsetShift = xOffset;
            }

            if (xOffsetShift > xOffsetMax) xOffsetShift = xOffsetMax;
            else if (xOffsetShift < (-1.0f * xOffsetMax)) xOffsetShift = -1.0f * xOffsetMax;

            if (yOffsetShift > yOffsetMax) yOffsetShift = yOffsetMax;
            else if (yOffsetShift < (-1.0f * yOffsetMax)) yOffsetShift = -1.0f * yOffsetMax;

            targetPosX = target.position.x + xOffsetShift;
            if (targetPosX > moveRightLimit)
            {
                targetPosX = moveRightLimit;
            }
            else if (targetPosX < moveLeftLimit)
            {
                targetPosX = moveLeftLimit;
            }

            Vector3 nextPos = new Vector3(targetPosX, target.position.y + yOffsetShift, -10f);
            transform.position = Vector3.SmoothDamp(transform.position, nextPos, ref velocity, smoothTime);
        }
    }

}  // end of memstow namespace