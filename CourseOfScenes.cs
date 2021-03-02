using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;              //Esto es el controlador de escenas

public class CourseOfScenes : MonoBehaviour
{
    public void ChangeSceneTo(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
