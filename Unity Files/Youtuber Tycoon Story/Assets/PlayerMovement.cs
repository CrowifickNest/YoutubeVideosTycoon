using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float playerSpeed = 0.0f;

    private Rigidbody rigid;

    private Cursor cursor;

	void Start () {

        rigid = GetComponent<Rigidbody>();

    }
	
	void Update () {
	
        if (Input.GetKey(KeyCode.W))
        {

            rigid.transform.Translate(new Vector3(playerSpeed, rigid.velocity.y, rigid.velocity.z));

        }

        if (Input.GetKey(KeyCode.A))
        {

            rigid.transform.Translate(new Vector3(rigid.velocity.x, playerSpeed, rigid.velocity.z));

        }


    }

}
