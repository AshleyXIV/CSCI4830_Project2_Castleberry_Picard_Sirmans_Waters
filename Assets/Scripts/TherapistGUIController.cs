using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEngine.EventSystems;


public class TherapistGUIController : MonoBehaviour
{

    static StreamWriter logWriter;
	
    // Start is called before the first frame update
    void Start()
    {
    string filename = Application.persistentDataPath + "\\Therapist_log" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + ".txt";

    logWriter = new StreamWriter(filename);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnApplicationQuit()
    {
        Application.Quit();


    }

    public void QuitApp()
    {
        logWriter.Flush();
        Application.Quit();
    }

    public void buttonClickedHome()
    {
		SceneManager.LoadScene(0, LoadSceneMode.Single);
        string level = "Level: Home";
        Debug.Log(level);
        logWriter.WriteLine(level);
    }
	
	public void buttonClickedOffice()
    {
		SceneManager.LoadScene(1, LoadSceneMode.Single);
        string level = "Level: Office";
        Debug.Log(level);
        logWriter.WriteLine(level);
    }
	
	public void buttonClickedSurvey()
    {
		SceneManager.LoadScene(2, LoadSceneMode.Single);
        string level = "Level: Survey";
        Debug.Log(level);
        logWriter.WriteLine(level);
    }

    public void TaskYesClicked()
    {
        string taskYes = "Task Completed";
        Debug.Log(taskYes);
        logWriter.WriteLine(taskYes);
    }

    public void TaskNoClicked()
    {
        string taskNo = "Task not Completed";
        Debug.Log(taskNo);
        logWriter.WriteLine(taskNo);
    }

    public void Survey1Bad()
    {
        string question = "Question: How real did moving in VR feel?";
        string answer = "Answer: Bad";

        Debug.Log(question);
        Debug.Log(answer);

        logWriter.WriteLine(question);
        logWriter.WriteLine(answer);
    }

    public void Survey1Ok()
    {
        string question = "Question: How real did moving in VR feel?";
        string answer = "Answer: Okay";

        Debug.Log(question);
        Debug.Log(answer);

        logWriter.WriteLine(question);
        logWriter.WriteLine(answer);
    }

    public void Survey1Good()
    {
        string question = "Question: How real did moving in VR feel?";
        string answer = "Answer: Good";

        Debug.Log(question);
        Debug.Log(answer);

        logWriter.WriteLine(question);
        logWriter.WriteLine(answer);
    }

    public void Survey2Bad()
    {
        string question = "Question: How real did the interaction with objects feel?";
        string answer = "Answer: Bad";

        Debug.Log(question);
        Debug.Log(answer);

        logWriter.WriteLine(question);
        logWriter.WriteLine(answer);
    }

    public void Survey2Ok()
    {
        string question = "Question: How real did the interaction with objects feel?";
        string answer = "Answer: Okay";

        Debug.Log(question);
        Debug.Log(answer);

        logWriter.WriteLine(question);
        logWriter.WriteLine(answer);
    }

    public void Survey2Good()
    {
        string question = "Question: How real did the interaction with objects feel?";
        string answer = "Answer: Good";

        Debug.Log(question);
        Debug.Log(answer);

        logWriter.WriteLine(question);
        logWriter.WriteLine(answer);
    }

    public void Survey3Yes()
    {
        string question = "Question: Did you feel like you were in a dark room?";
        string answer = "Answer: Yes";

        Debug.Log(question);
        Debug.Log(answer);

        logWriter.WriteLine(question);
        logWriter.WriteLine(answer);
    }

    public void Survey3No()
    {
        string question = "Question: Did you feel like you were in a dark room?";
        string answer = "Answer: No";

        Debug.Log(question);
        Debug.Log(answer);

        logWriter.WriteLine(question);
        logWriter.WriteLine(answer);
    }

    
}
