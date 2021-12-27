﻿using LuaInterface;
using Nova.Exceptions;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Nova
{
    public class LocalizedDialogueEntry
    {
        public string displayName;
        public string dialogue;
    }

    /// <summary>
    /// Dialogue entry without action. Used for serialization.
    /// </summary>
    [Serializable]
    public class DialogueDisplayData
    {
        /// <value>Internally used character name.</value>
        public readonly string characterName;

        /// <value>Displayed character name for each locale.</value>
        public readonly Dictionary<SystemLanguage, string> displayNames;

        /// <value>Displayed dialogue for each locale.</value>
        public readonly Dictionary<SystemLanguage, string> dialogues;

        public DialogueDisplayData(string characterName, Dictionary<SystemLanguage, string> displayNames,
            Dictionary<SystemLanguage, string> dialogues)
        {
            this.characterName = characterName;
            this.displayNames = displayNames;
            this.dialogues = dialogues;
        }

        public string FormatNameDialogue()
        {
            var name = I18n.__(displayNames);
            var dialogue = I18n.__(dialogues);
            if (string.IsNullOrEmpty(name))
            {
                return dialogue;
            }
            else
            {
                return string.Format(I18n.__("format.namedialogue"), name, dialogue);
            }
        }
    }

    /// <summary>
    /// A dialogue entry contains the character name and the dialogue in each locale, and the action to execute.
    /// </summary>
    public class DialogueEntry
    {
        public readonly DialogueDisplayData displayData;

        public string characterName => displayData.characterName;
        public Dictionary<SystemLanguage, string> displayNames => displayData.displayNames;
        public Dictionary<SystemLanguage, string> dialogues => displayData.dialogues;

        /// <value>
        /// The action to execute when the game processes to this point.
        /// </value>
        private readonly Dictionary<DialogueActionStage, LuaFunction> actions;

        public DialogueEntry(string characterName, string displayName, string dialogue,
            Dictionary<DialogueActionStage, LuaFunction> actions)
        {
            var displayNames = new Dictionary<SystemLanguage, string> { [I18n.DefaultLocale] = displayName };
            var dialogues = new Dictionary<SystemLanguage, string> { [I18n.DefaultLocale] = dialogue };
            this.displayData = new DialogueDisplayData(characterName, displayNames, dialogues);
            this.actions = actions;
        }

        public DialogueEntry(string characterName, string displayName, string dialogue, LuaFunction action)
            : this(characterName, displayName, dialogue, new Dictionary<DialogueActionStage, LuaFunction>
            {
                [DialogueActionStage.Default] = action
            })
        { }

        public void AddLocale(SystemLanguage locale, LocalizedDialogueEntry entry)
        {
            displayNames[locale] = entry.displayName;
            dialogues[locale] = entry.dialogue;
        }

        /// <summary>
        /// Execute the action stored in this dialogue entry.
        /// </summary>
        public void ExecuteAction(DialogueActionStage stage, bool isRestore)
        {
            if (actions.TryGetValue(stage, out var action))
            {
                LuaRuntime.Instance.UpdateExecutionContext(new ExecutionContext
                {
                    mode = ExecutionMode.Lazy,
                    stage = stage,
                    isRestore = isRestore
                });
                try
                {
                    action.Call();
                }
                catch (LuaException ex)
                {
                    throw new ScriptActionException(
                        $"Nova: Exception occurred when executing action: {I18n.__(dialogues)}", ex);
                }
            }
        }

        private const string ActionCoroutineName = "__Nova.action_coroutine";

        public static string WrapCoroutine(string code)
        {
            return $@"
{ActionCoroutineName} = coroutine.start(function()
    __Nova.coroutineHelper:AcquireGameStateLock()
    {code}
    __Nova.coroutineHelper:ReleaseGameStateLock()
end)";
        }

        public static void StopActionCoroutine()
        {
            LuaRuntime.Instance.DoString($"coroutine.stop({ActionCoroutineName})");
        }
    }
}