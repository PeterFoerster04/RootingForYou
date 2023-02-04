using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseMovement : MonoBehaviour
{
    private PlayerInput playerInput;
    private Rigidbody2D _rb;
	private Camera _cam;

    private Vector2 xMove;
    private Vector2 mousePos;
	private Vector2 oldVec;

	[SerializeField] private float downfallValue = -1f;
	[SerializeField] private int speedMultiplier = 100;
	[SerializeField] private float xSens;

	private float xPosInput;


	// Start is called before the first frame update
	void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); 
		_cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		float xMouse = xPosInput * Time.deltaTime * xSens;
        xMove = new Vector2(xMouse, downfallValue);
		//Camera.main.transform.position += new Vector3(0, downfallValue,-10)*Time.deltaTime;

    }
	private void FixedUpdate()
	{

		if ((_rb.position.x < mousePos.x&& xMove.x >0)|| (_rb.position.x > mousePos.x && xMove.x < 0) )
        {
			_rb.AddForce(xMove * Time.deltaTime * speedMultiplier, ForceMode2D.Force);
			Debug.Log(xMove);
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

	}

	public void OnLook(InputAction.CallbackContext inputValue)
    {
		xPosInput = inputValue.ReadValue<Vector2>().x;
		
	}
}
