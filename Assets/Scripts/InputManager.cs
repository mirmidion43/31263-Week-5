using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Transform[] transArray;
    // Start is called before the first frame update
    void Start()
    {
        transArray = new Transform[2];
        Transform blue = GameObject.FindWithTag("Blue").transform;
        Transform red = GameObject.FindWithTag("Red").transform;
        transArray[0] = blue.transform;
        transArray[1] = red.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            transArray[0].transform.Rotate(0.0f, 0.0f, -45.0f);
            transArray[1].transform.Rotate(0.0f, 0.0f, 45.0f);
        }

        if(Input.GetButtonDown("Fire1"))
        {
            float temp = transArray[0].position.y;
            transArray[0].transform.position = new Vector3(transArray[0].position.x, transArray[1].position.y, transArray[0].position.z);
            transArray[1].transform.position = new Vector3(transArray[1].position.x, temp, transArray[1].position.z);
        }
        #region Qpressed
        if(Input.GetButtonUp("Fire1"))
        {
            float x = Random.Range(51, 255);
            x = x/255;

            float z = Random.Range(51,255);
            z = z/255;
           
            GameObject.FindWithTag("Red").GetComponent<PrintAndHide>().rend.material.color = new Color(x,0.0f,0.0f);
            GameObject.FindWithTag("Blue").GetComponent<PrintAndHide>().rend.material.color = new Color(0.0f,0.0f,z);

            Debug.Log("Red: " + GameObject.FindWithTag("Red").GetComponent<PrintAndHide>().rend.material.color);
            Debug.Log("Blue: " + GameObject.FindWithTag("Blue").GetComponent<PrintAndHide>().rend.material.color);
        }
        #endregion

        //if(Input.GetKeyDown(KeyCode.E))
        {

        }
    }
}
