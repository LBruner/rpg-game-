﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dialogue
{
    public class PlayerConversant : MonoBehaviour
    {
        [SerializeField] private Dialogue currentDialogue;

        public string GetText()
        {
            if (currentDialogue == null)
                return "";
            return currentDialogue.GetRootNode().GetText();
        }
    }
}
