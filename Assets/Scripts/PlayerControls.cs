using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour
{
    //TODO: comment variables

    /// <summary>
    /// Public variables with preset default values that can be modified through the Unity engine. 
    /// </summary>
    #region Public Variables With Default Values

    public float walkSpeed = 1.5f;
    public float runSpeed = 2.0f;
    public float fallSpeed = 2.0f;
    public float walkJump = 6.2f;
    public float runJump = 9.0f;
    public float crouchJump = 10.0f;
    public float gravity = 20.0f;
    public float startPosition = 0.0f;
    public int moveDirection = 1;
    

    #endregion

    #region Public Variables That Must be Initialized in Editor

    public Transform particleJump;
    public AudioClip soundJump;
    public AudioClip soundCrouchJump;

    #endregion

    #region Private Variables

    private float soundRate = 0.0f;
    private float soundDelay = 0.0f;
    private Vector3 velocity = Vector3.zero;
    private bool jumpEnable = false;
    private bool crouchJumpEnable = false;
    private bool runJumpEnable = false;
    private float afterHitForceDown = 1.0f;

    #endregion


    // Update is called once per frame
	void Update () 
    {
	    
	}


}
