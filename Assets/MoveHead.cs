using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHead : MonoBehaviour {
    
    public Transform Head;
    private Vector3 MoveIncrement, Direction;
    private int Counter, Speed;

    // Use this for initialization
    void Start () {
        MoveIncrement = Vector3.zero;
        Direction = Vector3.zero;
        Counter = 0;
        Speed = 10;
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.W)) {
            Direction = Vector3.up / Speed;
        } else if (Input.GetKey(KeyCode.S)) {
            Direction = Vector3.down / Speed;
        } else if (Input.GetKey(KeyCode.A)) {
            Direction = Vector3.left / Speed;
        } else if (Input.GetKey(KeyCode.D)) {
            Direction = Vector3.right / Speed;
        }

        if (Counter % Speed == 0) {
            MoveIncrement = Direction;
        }

        Head.position += MoveIncrement;

        Counter = (Counter + 1) % Speed;
    }

    public void OnCollisionEnter2D (Collision2D collision) {
        // Debug.Log("Collide");
        // Destroy(Head.gameObject);
        // collision.gameObject.tag;

        Debug.Log(collision.gameObject.tag);

        

        switch (collision.gameObject.tag) {
            case "Untagged":
            Debug.Log("Snek stepped on");
            Destroy(Head.gameObject);
            break;
            case "Food":
            Debug.Log("Food eaten");
            Destroy(collision.gameObject);
            break;
        }
    }

}
