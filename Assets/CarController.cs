using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    float speed = 0;
    Vector2 startPos;

	void Start () {

	}
	
	void Update () {

        if(Input.GetMouseButtonDown(0)) {
            this.startPos = Input.mousePosition;
        } else if(Input.GetMouseButtonUp(0)) {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = (endPos.x - this.startPos.x);

            this.speed = swipeLength / 500.0f;

            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
	}
}
