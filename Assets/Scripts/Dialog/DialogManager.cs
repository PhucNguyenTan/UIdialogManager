using System.Collections.Generic;
using UnityEditor;

public class DialogManager : SingletonBase<DialogManager>
{
    private Stack<DialogBase> dialogStack = null;

    private int limit = 0;

    public DialogManager()
    {
        this.dialogStack = new Stack<DialogBase>();
    }

    public void AddPopup(DialogBase dialogIn)
    {
        if (dialogStack.Count > limit) return;
        dialogStack.Push(dialogIn);
        dialogIn.enabled = true;
        dialogIn.Setup();
    }

    public void RemovePopup()
    {
        if (dialogStack.Count == 0) return;
        var dialogOut = dialogStack.Pop();
        dialogOut.enabled = false;
        dialogOut.Close();
    }
}
