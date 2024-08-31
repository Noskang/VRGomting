using System.Collections;
using UnityEngine;
using TMPro; // TextMeshPro�� ����ϱ� ���� ���ӽ����̽�

public class MyChatController : MonoBehaviour
{
    public TextMeshProUGUI chatText; // TextMeshProUGUI ������Ʈ
    public float typingSpeed = 0.05f; // Ÿ���� �ӵ�

    private bool isTyping = false; // ���� Ÿ���� ������ ����

    void Start()
    {
        // ���� ��� ����
        StartCoroutine(TypeText("      ��, �� �̰� ��¥ ��ư� ���Ѱž�\r\n������ �ѹ��� �ؼ��� ���ۿ뵵 ���� ���� \r\n             �� �� �ϰ� �ѹ��� �غ�!"));
    }

    IEnumerator TypeText(string textToType)
    {
        chatText.text = ""; // �ؽ�Ʈ�� ���ϴ�
        isTyping = true;

        foreach (char letter in textToType.ToCharArray())
        {
            chatText.text += letter; // �� ���ھ� �߰�
            yield return new WaitForSeconds(typingSpeed); // Ÿ���� �ӵ� ����
        }

        isTyping = false; // Ÿ���� �Ϸ�
    }
}
