using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag() {
        Vector3 objectPos = Camera.main.WorldToScreenPoint( transform.position );
        Vector3 pointScreen = new Vector3( Input.mousePosition.x, Input.mousePosition.y, 0 );

        Vector3 pointworld = Camera.main.ScreenToWorldPoint( pointScreen );
        pointworld.z = transform.position.z;

        transform.position = pointworld;

        //this.GetComponent<Rigidbody2D>().isKinematic = false;
    }
}