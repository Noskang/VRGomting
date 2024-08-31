using System.Collections;
using UnityEngine;
using TMPro; // TextMeshPro를 사용하기 위한 네임스페이스

public class MyChatControllermboy2 : MonoBehaviour
{
    public TextMeshProUGUI chatText; // TextMeshProUGUI 컴포넌트
    public float typingSpeed = 0.05f; // 타이핑 속도

    private bool isTyping = false; // 현재 타이핑 중인지 여부

    void Start()
    {
        // 예시 대사 시작
        StartCoroutine(TypeText("너 어디 가서 이런 거 구할 수 있는 줄 알아?"));
    }

    IEnumerator TypeText(string textToType)
    {
        chatText.text = ""; // 텍스트를 비웁니다
        isTyping = true;

        foreach (char letter in textToType.ToCharArray())
        {
            chatText.text += letter; // 한 글자씩 추가
            yield return new WaitForSeconds(typingSpeed); // 타이핑 속도 조절
        }

        isTyping = false; // 타이핑 완료
    }
}
