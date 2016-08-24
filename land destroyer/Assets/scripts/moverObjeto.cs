using UnityEngine;
using System.Collections;

public class moverObjeto : MonoBehaviour {
    //public GameObject personaje;
    public float move;
    
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(this.gameObject.GetComponent<Rigidbody>().velocity.x,move, this.gameObject.GetComponent<Rigidbody>().velocity.z);
        
    }
}
