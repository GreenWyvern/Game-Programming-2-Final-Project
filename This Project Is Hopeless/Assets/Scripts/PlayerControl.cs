using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float movespeed;
    public float rotatespeed;
	

    void Update()
    {

        var x2 = Input.GetAxis("Horizontal2") * Time.deltaTime * 3.0f;
        var z2 = Input.GetAxis("Vertical2") * Time.deltaTime * 3.0f;

        transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical1") * movespeed);
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal1") * movespeed);
        
        var x = Input.GetAxis("Horizontal2") * Time.deltaTime * rotatespeed;
        transform.Rotate(0, x, 0);

    }
}
