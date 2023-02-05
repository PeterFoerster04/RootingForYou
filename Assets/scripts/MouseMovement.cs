using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseMovement : MonoBehaviour
{
    private PlayerInput playerInput;
    private Rigidbody2D _rb;
	private TrailRenderer _trailRenderer;

    private Vector2 xMove;
    private Vector2 mousePos;
	private Vector2 oldVec;

	public float downfallValue = -2f;
	[SerializeField] private int speedMultiplier = 100;
	[SerializeField] private float xSens;

	private float xPosInput;
	float trailStartTime = 2.3f;


	// Start is called before the first frame update
	void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); 
		_trailRenderer = GetComponent<TrailRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
		float endTrailTime = 1;
		float trailDecrement = 0.001f;

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		float xMouse = xPosInput * Time.deltaTime * xSens;
        xMove = new Vector2(xMouse, downfallValue);

		if (trailStartTime>endTrailTime) 
		{
			trailStartTime = trailStartTime - trailDecrement;
			_trailRenderer.time = trailStartTime;
		}

    }
	private void FixedUpdate()
	{

		if ((_rb.position.x < mousePos.x&& xMove.x >0)|| (_rb.position.x > mousePos.x && xMove.x < 0))
        {
			_rb.AddForce(xMove * Time.deltaTime * speedMultiplier, ForceMode2D.Force);
			oldVec = xMove;
		}
		else
        {
			if (oldVec.x > 0)
			{
				_rb.velocity = new Vector2(1, downfallValue);
			}
			else if (oldVec.x < 0)
			{
				_rb.velocity = new Vector2(-1, downfallValue);
			}
			else _rb.velocity = new Vector2(0, downfallValue);
		}
		if (downfallValue > -8)
		{

			downfallValue = downfallValue - 0.002f;
		}
	}

	public void OnLook(InputAction.CallbackContext inputValue)
    {
		xPosInput = inputValue.ReadValue<Vector2>().x;
		
	}
}
