using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace PotentiallyReallyUsefulNewEditorSorter
{
    [KSPAddon(KSPAddon.Startup.EditorAny, false)]
    public class PRUNES : MonoBehaviour
    {

        public void Start()
        {
            KSP.UI.Screens.PartCategorizer.Instance.editorPartList.partListSorter.ClickButton(3);
        }

    }
}
