using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DialogueSystem
{
    public class DialogueManager : MonoBehaviour
    {
        [Header("UI")]
        [SerializeField] private DialogueChoiceUI choicePrefab;
        [SerializeField] private Transform choiceContainer;
        [SerializeField] private GameObject dialogueBox;
        [SerializeField] private TMP_Text dialogueText;
        [SerializeField] private Image dialogueImage;

        private List<GameObject> activeChoices = new List<GameObject>();

        private DialogueEventBase currentEvent;

        public void ShowChoices(DialogueNode node)
        {
            ClearChoices();

            foreach (var response in node.responses)
            {
                var choice = Instantiate(choicePrefab, choiceContainer);
                choice.Setup(response, this);

                activeChoices.Add(choice.gameObject);
            }
            dialogueImage.enabled = true;
            dialogueBox.SetActive(true);
            dialogueText.text = node.dialogueText;
            dialogueImage.sprite = node.image;
            //Animate text/image
            var textEvent = Instantiate(node.eventPrefab);
            currentEvent = textEvent;
        }
        private void ClearChoices()
        {
            foreach (var obj in activeChoices)
                Destroy(obj);

            activeChoices.Clear();
            if (currentEvent != null) { Destroy(currentEvent.gameObject); }
            dialogueImage.enabled = false;
            dialogueBox.SetActive(false);

        }
        public void SelectResponse(DialogueResponse response)
        {
            currentEvent.Execute(response, this);
        }
    }
}
