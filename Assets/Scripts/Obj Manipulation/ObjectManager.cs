﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour {

	private bool selected;
	public float moveSpeed = 0.5f;
	public float rotationSpeed = 10f;

	DrawAxis axis;
	Material lineMaterial;

	void Start () {
		axis = GetComponent<DrawAxis>();
	}


    void selectObject() {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo = new RaycastHit();
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo))
            {
                if(hitInfo.transform.tag == "Object")
                selected = true;
            }
            else {
                selected = false;
            }
        }
    }

	void Update () {
        selectObject();
		if (selected == true)
		{
			axis.canDraw = true;
			if (Input.GetKey(KeyCode.LeftControl))
				RotateObject();
			if (Input.GetKey(KeyCode.LeftAlt))
				TranslateObject();
			if (Input.GetKeyDown(KeyCode.Delete))
				Destroy(gameObject);
		}
		else
		{
			axis.canDraw = false;
		}
	}

	void RotateObject()
	{
    if (Input.GetKey(KeyCode.LeftControl) && Input.GetAxis("Mouse ScrollWheel") > 0) {
    transform.Rotate(Vector3.up * 0.5f, Space.Self);
    }
    if (Input.GetKey(KeyCode.LeftControl) && Input.GetAxis("Mouse ScrollWheel") < 0) {
    transform.Rotate(Vector3.down * 0.5f, Space.Self);
}
	}

	void TranslateObject()
	{
        if (Input.GetKey(KeyCode.Mouse0))
        {
            float dist = transform.position.z - Camera.main.transform.position.z;
            Vector3 pos = Input.mousePosition;
            pos.z = dist;
            pos = Camera.main.ScreenToWorldPoint(pos);
            pos.y = transform.position.y;
            transform.position = pos;
        }
    }

}
