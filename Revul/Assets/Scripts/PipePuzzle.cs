using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PipePuzzle : MonoBehaviour
{
	public MouseClick one_oneScript;
	public MouseClick one_twoScript;
	public MouseClick one_threeScript;
	//public MouseClick one_fourScript;
	public MouseClick two_oneScript;
	public MouseClick two_twoScript;
	public MouseClick two_threeScript;
	public MouseClick two_fourScript;
	public MouseClick three_oneScript;
	public MouseClick three_twoScript;
	public MouseClick three_threeScript;
	public MouseClick three_fourScript;
	//public MouseClick four_oneScript;
	public MouseClick four_twoScript;
	public MouseClick four_threeScript;
	public MouseClick four_fourScript;

	public Animator animPipe;
	public GameObject _collider;
	public GameObject _wall;
	public GameObject _person;
	public GameObject _camera;
	public GameObject laptopLock;
	public GameObject pause;


	public int _sceneNumber;
	public bool result;


	// Start is called before the first frame update
	public void NextLevel(int _sceneNumber)
	{
		SceneManager.LoadScene(_sceneNumber);
	}
	
    void Start()
    {
	    
    }

    // Update is called once per frame
    void Update()
    {
	    MouseClick[] Data = { one_twoScript, one_threeScript, two_twoScript, two_threeScript, two_fourScript,
		    three_twoScript, three_threeScript, four_twoScript, four_threeScript};

	    foreach (MouseClick i in Data)
	    {
		    //Debug.Log(Quaternion.Angle(i.transform.rotation, Quaternion.Euler(0f, 0f, i.properAngle)) < 1f);
		    //Debug.Log(Quaternion.Angle(i.transform.rotation, Quaternion.Euler(0f, 0f, i.properAngleTwo)) < 1f);
		    //Debug.Log("Qua" + Quaternion.Euler(0f, 0f, i.properAngle));
		    //Debug.Log("Trans" + i.transform.rotation);
		    if ((Quaternion.Angle(i.transform.rotation, Quaternion.Euler(0f, 0f, i.properAngle)) < 1f) || (Quaternion.Angle(i.transform.rotation, Quaternion.Euler(0f, 0f, i.properAngleTwo)) < 1f))
			    i.position = true;
		    else
		    {
			    i.position = false;
		    }

		    //result = result && i.position;
	    }

	    if (one_twoScript.position && one_threeScript.position && two_twoScript.position && two_threeScript.position &&  two_fourScript.position &&
	        three_twoScript.position &&  three_threeScript.position && four_twoScript.position && four_threeScript.position)
	    {
		    result = true;
		    //NextLevel(_sceneNumber);
		    animPipe.SetBool("state", true);
		    Cursor.visible = false;
		    Cursor.lockState = CursorLockMode.Locked;
		    _camera.SetActive(false);
		    _person.SetActive(true);
		    _wall.SetActive(false);
		    _collider.SetActive(false);
		    laptopLock.SetActive(true);
		    pause.SetActive(true);

	    }

    }
}
