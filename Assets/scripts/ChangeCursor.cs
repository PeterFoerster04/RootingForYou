using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCursor : MonoBehaviour
{

    public Texture2D cursorTex;
    public CursorMode cursormode = CursorMode.ForceSoftware;
    public Vector2 hotspot = Vector2.zero;
	// Start is called before the first frame update
	void Start()
	{
		Cursor.SetCursor(cursorTex, hotspot, cursormode);
		Debug.Log("test");
	}
	private void OnMouseExit()
	{
		Cursor.SetCursor(null, Vector2.zero, cursormode);
	}

}
