using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // StartSceneManager 클래스를 사용하기 위해

public class StartSceneManager2 : MonoBehaviour
{
    public void OnClickStart2()
    {
        SceneManager.LoadScene("#1.room.girl"); // 띄어쓰기도 똑같아야 함
    }
}