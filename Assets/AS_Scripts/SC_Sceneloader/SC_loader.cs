using UnityEngine;
using UnityEngine.SceneManagement; // �� ������ ���� ���ӽ����̽�

public class SceneLoader : MonoBehaviour
{
    public string sceneName; // ����Ƽ �����Ϳ��� �� �̸��� ������ �� �ִ� ����

    public void LoadScene()
    {
        // �� �ε�
        SceneManager.LoadScene(sceneName);
    }
}
