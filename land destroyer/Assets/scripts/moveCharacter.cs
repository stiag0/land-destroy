using UnityEngine;
using System.Collections;

public class moveCharacter : MonoBehaviour {

    // Use this for initialization
    public float move;
    public float retroceso;
    private bool centroX;
    private bool centroy;
    void Start () {
	
	}

    void regresarLeft(float a)
    {
        this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(a, this.gameObject.GetComponent<Rigidbody>().velocity.y
            , this.gameObject.GetComponent<Rigidbody>().velocity.z);
    }
    void regresarUp(float a)
    {
        this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(this.gameObject.GetComponent<Rigidbody>().velocity.x,
            this.gameObject.GetComponent<Rigidbody>().velocity.y
            , a);
    }


    IEnumerator regresar() {
            Debug.Log("corutina");
            /*
            while (transform.position.x < 0){
            this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(move, this.gameObject.GetComponent<Rigidbody>().velocity.y, this.gameObject.GetComponent<Rigidbody>().velocity.z);
           
        }
         */
        yield return new WaitForSeconds(0.1f);
    }
    void Update()
    {
        //mejorable, apenas sospecho como
        if((this.transform.position.x > 0)) {
            regresarLeft(-retroceso);
        }
        if ((this.transform.position.x < 0))
        {
            regresarLeft(retroceso);
        }

        if (this.transform.position.z > 0) {
            regresarUp(-retroceso);
        }
        if (this.transform.position.z < 0)
        {
            regresarUp(retroceso);
        }
        //movimiento caracter
        if (Input.GetKey(KeyCode.D)){
            this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(-move, this.gameObject.GetComponent<Rigidbody>().velocity.y, this.gameObject.GetComponent<Rigidbody>().velocity.z);
        }
               
        if (Input.GetKey(KeyCode.A)){
            this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(move, this.gameObject.GetComponent<Rigidbody>().velocity.y, this.gameObject.GetComponent<Rigidbody>().velocity.z);
        }

        if (Input.GetKey(KeyCode.W)){
            this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(this.gameObject.GetComponent<Rigidbody>().velocity.x, this.gameObject.GetComponent<Rigidbody>().velocity.y, -move);
        }

        if (Input.GetKey(KeyCode.S)){
            this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(this.gameObject.GetComponent<Rigidbody>().velocity.x, this.gameObject.GetComponent<Rigidbody>().velocity.y, move);
        }
    }
}
