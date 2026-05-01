using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace DialogueSystem
{
    [CreateAssetMenu(menuName = "Dialogue/Node")]
    public class DialogueNode : ScriptableObject
    {
        public Sprite image;
        public string dialogueText;
        public DialogueResponse[] responses;
        public DialogueEventBase eventPrefab;
    }
    [System.Serializable]
    public struct DialogueResponse
    {
        [TextArea]
        public string text;
        public string id;
    }
}
