﻿using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Nova
{
    public class DialogueTextController : MonoBehaviour
    {
        public GameObject dialogueEntryPrefab;
        public readonly List<DialogueEntryController> dialogueEntryControllers = new List<DialogueEntryController>();

        private PrefabFactory _prefabFactory;

        private PrefabFactory prefabFactory
        {
            get
            {
                if (_prefabFactory == null)
                {
                    var t = transform.root.Find("DialogueEntryFactory");
                    GameObject go;
                    if (t == null)
                    {
                        go = new GameObject("DialogueEntryFactory");
                        go.transform.SetParent(transform.root);
                    }
                    else
                    {
                        go = t.gameObject;
                    }

                    var prefabFactoryGO = new GameObject("For " + name);
                    prefabFactoryGO.transform.SetParent(go.transform);
                    _prefabFactory = prefabFactoryGO.AddComponent<PrefabFactory>();
                    _prefabFactory.prefab = dialogueEntryPrefab;
                    _prefabFactory.maxBufferSize = 10;
                }

                return _prefabFactory;
            }
        }

        public void Clear()
        {
            foreach (var dec in dialogueEntryControllers)
            {
                dec.Clear();
                prefabFactory.Put(dec.gameObject);
            }

            dialogueEntryControllers.Clear();
        }

        public DialogueEntryController AddEntry(DialogueDisplayData displayData, TextAlignmentOptions alignment,
            Color characterNameColor, Color textColor, string materialName, DialogueEntryLayoutSetting layoutSetting, int textLeftExtraPadding)
        {
            var dec = prefabFactory.Get<DialogueEntryController>();
            var _transform = dec.transform;
            _transform.SetParent(transform);
            _transform.SetAsLastSibling();
            _transform.localPosition = Vector3.zero;
            _transform.localRotation = Quaternion.identity;
            _transform.localScale = Vector3.one;
            dialogueEntryControllers.Add(dec);
            dec.Init(displayData, alignment, characterNameColor, textColor, materialName,
                layoutSetting, textLeftExtraPadding);
            return dec;
        }
    }
}