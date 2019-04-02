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
    
    
    public static string filename;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {

        TherapistGUIController.filename = Application.persistentDataPath + "\\Therapist_log" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Hour +  ".txt";
        
    }

    void makeFile()
    {

    }

    void OnApplicationQuit()
    {
        string level = PlayerPrefs.GetString("level") + "\n";
        string survey = PlayerPrefs.GetString("level2") + "\n";
        string task = PlayerPrefs.GetString("task") + "\n";
        string question1 = PlayerPrefs.GetString("question1") + "\n";
        string answer1 = PlayerPrefs.GetString("answer1") + "\n";
        string question2 = PlayerPrefs.GetString("question2") + "\n";
        string answer2 = PlayerPrefs.GetString("answer2") + "\n";
        string question3 = PlayerPrefs.GetString("question3") + "\n";
        string answer3 = PlayerPrefs.GetString("answer3") + "\n";

        File.WriteAllText(filename, DateTime.Now + "\n\n" + level + task + survey + question1 + answer1 + question2 + answer2 + question3 + answer3);

        Application.Quit();


    }

    public void QuitApp()
    {
        Application.Quit();
    }

    public void buttonClickedHome()
    {
		SceneManager.LoadScene(0, LoadSceneMode.Single);
        string level = "Level: Home";
        Debug.Log(level);
        
        PlayerPrefs.SetString("level", level);
    }
	
	public void buttonClickedOffice()
    {
		SceneManager.LoadScene(1, LoadSceneMode.Single);
        string level = "Level: Office";
        Debug.Log(level);
        
        PlayerPrefs.SetString("level", level);
    }
	
	public void buttonClickedSurvey()
    {
		SceneManager.LoadScene(2, LoadSceneMode.Single);
        string level = "Level: Survey";
        Debug.Log(level);
        
        PlayerPrefs.SetString("level2", level);
    }

    public void TaskYesClicked()
    {
        string taskYes = "Task Completed";
        Debug.Log(taskYes);
        
        PlayerPrefs.SetString("task", taskYes);
    }

    public void TaskNoClicked()
    {
        string taskNo = "Task not Completed";
        Debug.Log(taskNo);
        
        PlayerPrefs.SetString("task", taskNo);
    }

    public void Survey1Bad()
    {
        string question = "Question: How real did moving in VR feel?";
        string answer = "Answer: Bad";

        Debug.Log(question);
        Debug.Log(answer);

        
        PlayerPrefs.SetString("question1", question);
        PlayerPrefs.SetString("answer1", answer);
    }

    public void Survey1Ok()
    {
        string question = "Question: How real did moving in VR feel?";
        string answer = "Answer: Okay";

        Debug.Log(question);
        Debug.Log(answer);

        
        PlayerPrefs.SetString("question1", question);
        PlayerPrefs.SetString("answer1", answer);
    }

    public void Survey1Good()
    {
        string question = "Question: How real did moving in VR feel?";
        string answer = "Answer: Good";

        Debug.Log(question);
        Debug.Log(answer);

        
        PlayerPrefs.SetString("question1", question);
        PlayerPrefs.SetString("answer1", answer);
    }

    public void Survey2Bad()
    {
        string question = "Question: How real did the interaction with objects feel?";
        string answer = "Answer: Bad";

        Debug.Log(question);
        Debug.Log(answer);

        
        PlayerPrefs.SetString("question2", question);
        PlayerPrefs.SetString("answer2", answer);
    }

    public void Survey2Ok()
    {
        string question = "Question: How real did the interaction with objects feel?";
        string answer = "Answer: Okay";

        Debug.Log(question);
        Debug.Log(answer);

        
        PlayerPrefs.SetString("question2", question);
        PlayerPrefs.SetString("answer2", answer);
    }

    public void Survey2Good()
    {
        string question = "Question: How real did the interaction with objects feel?";
        string answer = "Answer: Good";

        Debug.Log(question);
        Debug.Log(answer);

        
        PlayerPrefs.SetString("question2", question);
        PlayerPrefs.SetString("answer2", answer);
    }

    public void Survey3Yes()
    {
        string question = "Question: Did you feel like you were in a dark room?";
        string answer = "Answer: Yes";

        Debug.Log(question);
        Debug.Log(answer);

        
        PlayerPrefs.SetString("question3", question);
        PlayerPrefs.SetString("answer3", answer);
    }

    public void Survey3No()
    {
        string question = "Question: Did you feel like you were in a dark room?";
        string answer = "Answer: No";

        Debug.Log(question);
        Debug.Log(answer);

        
        PlayerPrefs.SetString("question3", question);
        PlayerPrefs.SetString("answer3", answer);
    }

    
}
