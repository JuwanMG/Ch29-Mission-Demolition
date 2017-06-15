using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour {
    static public FollowCam S;
    public float easing = 0.05f;
    public Vector2 minXY;
    public bool _____________;
    public GameObject poi;
    public float camZ;

    void Awake()
    {
        S = this;
        camZ = this.transform.position.z;
    }

    // Use this for initialization
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (poi == null) return;

        Vector3 destination = poi.transform.position;
        destination.x = Mathf.Max(minXY.x, destination.x);
        destination.y = Mathf.Max(minXY.y, destination.y);
        destination = Vector3.Lerp(transform.position, destination, easing);
        destination.z = camZ;
        transform.position = destination;
        this.GetComponent<Camera>().orthographicSize = destination.y + 10;
        
	}
}
