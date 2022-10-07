using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;
    int WalkingBackwardHash;
    int RightStrafeWalkingHash;
    int LeftStrafeWalkingHash;
    int RunningBackwardHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        WalkingBackwardHash = Animator.StringToHash("WalkingBackward");
        RightStrafeWalkingHash = Animator.StringToHash("RightStrafeWalking");
        LeftStrafeWalkingHash = Animator.StringToHash("LeftStrafeWalking");
        RunningBackwardHash = Animator.StringToHash("RunningBackward");
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isRunning = animator.GetBool(isRunningHash);
        bool WalckingBackward= animator.GetBool(WalkingBackwardHash);
        bool RightStrafeWalking = animator.GetBool(RightStrafeWalkingHash);
        bool LeftStrafeWalking = animator.GetBool(LeftStrafeWalkingHash);
        bool RunningBackward = animator.GetBool(RunningBackwardHash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");
        bool backwardPressed = Input.GetKey("s");
        bool rightPressed = Input.GetKey("d");
        bool leftPressed = Input.GetKey("a");

        if (!isWalking && forwardPressed)
        {
            animator.SetBool(isWalkingHash, true);
        }

        if (isWalking && !forwardPressed)
        {
            animator.SetBool(isWalkingHash, false);
        }

        if (!isRunning && (forwardPressed && runPressed))
        {
            animator.SetBool(isRunningHash, true);
        }
        if (isRunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool(isRunningHash, false);
        }

        if(!WalckingBackward && backwardPressed)
        {
            animator.SetBool(WalkingBackwardHash, true);
        }

        if (WalckingBackward && !backwardPressed)
        {
            animator.SetBool(WalkingBackwardHash, false);
        }

        if(!RightStrafeWalking && rightPressed)
        {
            animator.SetBool(RightStrafeWalkingHash, true);
        }

        if (RightStrafeWalking && !rightPressed)
        {
            animator.SetBool(RightStrafeWalkingHash, false);
        }

        if (!LeftStrafeWalking && leftPressed)
        {
            animator.SetBool(LeftStrafeWalkingHash, true);
        }

        if (LeftStrafeWalking && !leftPressed)
        {
            animator.SetBool(LeftStrafeWalkingHash, false);
        }

        if (!RunningBackward && (backwardPressed && runPressed))
        {
            animator.SetBool(RunningBackwardHash, true);
        }
        if (RunningBackward && (!backwardPressed || !runPressed))
        {
            animator.SetBool(RunningBackwardHash, false);
        }
    }
}
