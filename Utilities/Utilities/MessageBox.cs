﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

public class JsonData
{
    public string Script { get; set; }
    public string Html { get; set; }
    public bool Success { get; set; }
}
public class MessageBox
{
    public static JavaScriptResult Show(string message, MessageType type = MessageType.Alert, bool modal = false, MessageAlignment layout = MessageAlignment.Center, bool dismissQueue = false)
    {
        string txt = "$.noty.closeAll(); noty({ text: \"" + message + "\", type: \"" + type.ToString().ToLower() + "\", layout: \"" + layout.ToString().ToLowerFirst() + "\", dismissQueue: " + dismissQueue.ToString().ToLower() + ", modal: " + modal.ToString().ToLower() + " });";
        return new JavaScriptResult() { Script = txt };
    }
}
public enum MessageType
{
    Success,
    Error,
    Information,
    Warning,
    Alert,
    Notification
}
public enum MessageAlignment
{
    Bottom,
    BottomCenter,
    BottomLeft,
    BottomRight,
    Center,
    CenterLeft,
    CenterRight,
    Inline,
    Top,
    TopCenter,
    TopLeft,
    TopRight
}