using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // StartSceneManager Ŭ������ ����ϱ� ����

public class StartSceneManager2 : MonoBehaviour
{
    public void OnClickStart2()
    {
        SceneManager.LoadScene("#1.room.girl"); // ���⵵ �Ȱ��ƾ� ��
    }
}