﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {

    public Camera firstPersonCam;
    public Camera thirdPersonCam;
    public Camera birdPersonCam;
    public Camera NoPersonCam;
    public GameObject thirdPersonplayer;
    public GameObject firstPersonplayer;

  /*  public void SetToFirstPerson(){
        firstPersonCam.enabled = true;
        firstPersonplayer.SetActive(true);
        thirdPersonCam.enabled = false;
        thirdPersonplayer.SetActive(false);
        birdPersonCam.enabled = false;
        NoPersonCam.enabled = false;
    }

    public void SetToThirdPerson(){
        firstPersonCam.enabled = false;
        firstPersonplayer.SetActive(false);
        thirdPersonCam.enabled = true;
        thirdPersonplayer.SetActive(true);
        birdPersonCam.enabled = false;
        NoPersonCam.enabled = false;

    }

    public void SetToBirdPerson() {
        firstPersonCam.enabled = false;
        firstPersonplayer.SetActive(false);
        thirdPersonCam.enabled = false;
        thirdPersonplayer.SetActive(false);
        birdPersonCam.enabled = true;
        NoPersonCam.enabled = false;
    }
        public void SetToNoPerson() {
        firstPersonCam.enabled = false;
        firstPersonplayer.SetActive(false);
        thirdPersonCam.enabled = false;
        thirdPersonplayer.SetActive(false);
        birdPersonCam.enabled = false;
        NoPersonCam.enabled = true;
    }*/

    private void Start()
    {
        firstPersonCam.enabled = false;
        firstPersonplayer.SetActive(false);
        thirdPersonCam.enabled = false;
        thirdPersonplayer.SetActive(false);
        birdPersonCam.enabled = true;
        NoPersonCam.enabled = false;
    }

    void ToggleView()
    {
        if (birdPersonCam.enabled = true && Input.GetKeyDown(KeyCode.V))
        {
            firstPersonCam.enabled = true;
            firstPersonplayer.SetActive(true);
            thirdPersonCam.enabled = false;
            thirdPersonplayer.SetActive(false);
            birdPersonCam.enabled = false;
            NoPersonCam.enabled = false;
        }
        else if (firstPersonCam.enabled = true && Input.GetKey(KeyCode.V))
        {
            firstPersonCam.enabled = false;
            firstPersonplayer.SetActive(false);
            thirdPersonCam.enabled = true;
            thirdPersonplayer.SetActive(true);
            birdPersonCam.enabled = false;
            NoPersonCam.enabled = false;
        }
        else if (thirdPersonCam.enabled = true && Input.GetKey(KeyCode.V))
        {
            firstPersonCam.enabled = false;
            firstPersonplayer.SetActive(false);
            thirdPersonCam.enabled = false;
            thirdPersonplayer.SetActive(false);
            birdPersonCam.enabled = false;
            NoPersonCam.enabled = true;
        }
        else if (NoPersonCam.enabled = true && Input.GetKey(KeyCode.V))
        {
            firstPersonCam.enabled = false;
            firstPersonplayer.SetActive(false);
            thirdPersonCam.enabled = false;
            thirdPersonplayer.SetActive(false);
            birdPersonCam.enabled = true;
            NoPersonCam.enabled = false;
        }
    }
}