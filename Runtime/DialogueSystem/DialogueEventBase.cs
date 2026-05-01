using UnityEngine;

namespace DialogueSystem
{
    public abstract class DialogueEventBase : MonoBehaviour
    {
        public abstract void Execute(DialogueResponse response, DialogueManager manager);
    }
}
