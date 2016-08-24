using UnityEngine;
using System.Collections;

public class timerYpuntajes : MonoBehaviour {
    public TextMesh timer;
    float tiempo;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        tiempo = tiempo + Time.deltaTime;
        timer.text = tiempo.ToString();
        //Debug.Log(tiempo);
    }
}
