using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TherapistGUIController : MonoBehaviour
{
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonClickedHome()
    {
		SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
	
	public void buttonClickedOffice()
    {
		SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
	
	public void buttonClickedSurvey()
    {
		SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
	
}
