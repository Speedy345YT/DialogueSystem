using System;
using Sirenix.OdinInspector.Editor;
using UnityEngine;

namespace DialogueSystem
{
    public class DebugTest : DialogueEventBase
    {
        public override void Execute(DialogueResponse response, DialogueManager manager)
        {
            Debug.Log($"{response.text} pressed!");
            if (response.id == "slime")
            {
                Debug.Log("Slimy");
            }
            if (response.id == "twin")
            {
                Debug.Log("Twinning");
            }
        }
    }
}