using UnityEngine;
using UnityEngine.SceneManagement; // 씬 관리를 위한 네임스페이스

public class SceneLoader : MonoBehaviour
{
    public string sceneName; // 유니티 에디터에서 씬 이름을 설정할 수 있는 변수

    public void LoadScene()
    {
        // 씬 로드
        SceneManager.LoadScene(sceneName);
    }
}
