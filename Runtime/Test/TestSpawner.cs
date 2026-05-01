using UnityEngine;

namespace DialogueSystem
{
    public class TestSpawner : MonoBehaviour
    {
        public DialogueManager manager;
        public DialogueNode node;
        private void Start()
        {
            ShowResponses();
        }
        public void ShowResponses()
        {
            manager.ShowChoices(node);
        }
    }
}
