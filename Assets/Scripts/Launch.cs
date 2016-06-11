using UnityEngine;
using System.Collections;

public class Launch : MonoBehaviour {

    Rigidbody2D rb;
    [SerializeField]
    private float xf;
    [SerializeField]
    private float yf;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(new Vector2(xf,yf));
        }
	}
}
