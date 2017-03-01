﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigMovement : MonoBehaviour {

    int speed = 20;
    int rotSpeed = 120;

    public GameObject bullet;

    public VirtualJoystick joystick;

	/*
	public VirtualJoystick joystickRotate;
	*/

    GameObject spawnPoint;

    void Start () {
        spawnPoint = GameObject.Find("SpawnPoint");
	}
	
	void Update () {

        float toMove = speed * Time.deltaTime;
        float toRotate = rotSpeed * Time.deltaTime;

        float front = 0;
        float ang = 0;

		float frontRotate = 0;
		float angRotate = 0;

        //front = Input.GetAxis("Vertical");
        //ang = Input.GetAxis("Horizontal");

        front = joystick.Vertical();
        ang = joystick.Horizontal();

		frontRotate = joystickRotate.Vertical();
		angRotate = joystickRotate.Horizontal();

        //transform.Translate(Vector3.right * front * toMove);
        //transform.Rotate(new Vector3(0, ang * toRotate, 0));

		transform.Translate (new Vector3 (front*toMove, 0, ang*toMove*-1));


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, spawnPoint.transform.position, transform.rotation);   
        }
    }
}
