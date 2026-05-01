using TMPro;
using UnityEngine;
using UnityEngine.UI;
namespace DialogueSystem
{
    public class DialogueChoiceUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text text;
        [SerializeField] private Button button;

        private DialogueResponse response;
        private DialogueManager manager;

        public void Setup(DialogueResponse response, DialogueManager manager)
        {
            this.response = response;
            this.manager = manager;

            text.text = response.text;

            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(OnClicked);
        }
        private void OnClicked()
        {
            manager.SelectResponse(response);
        }
    }
}
