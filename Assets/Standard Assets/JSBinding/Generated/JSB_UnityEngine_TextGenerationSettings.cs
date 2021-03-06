﻿
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by CSGenerator.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

using jsval = JSApi.jsval;

public class JSB_UnityEngine_TextGenerationSettings
{

////////////////////// TextGenerationSettings ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool TextGenerationSettings_TextGenerationSettings1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.TextGenerationSettings());
    }

    return true;
}

// fields
static void TextGenerationSettings_font(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        var result = _this.font;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else {
        UnityEngine.Font arg0 = (UnityEngine.Font)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        _this.font = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextGenerationSettings_color(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        var result = _this.color;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else {
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        _this.color = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextGenerationSettings_fontSize(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        var result = _this.fontSize;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        _this.fontSize = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextGenerationSettings_lineSpacing(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        var result = _this.lineSpacing;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        _this.lineSpacing = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextGenerationSettings_richText(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        var result = _this.richText;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else {
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        _this.richText = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextGenerationSettings_scaleFactor(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        var result = _this.scaleFactor;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        _this.scaleFactor = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextGenerationSettings_fontStyle(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        var result = _this.fontStyle;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else {
        UnityEngine.FontStyle arg0 = (UnityEngine.FontStyle)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        _this.fontStyle = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextGenerationSettings_textAnchor(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        var result = _this.textAnchor;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else {
        UnityEngine.TextAnchor arg0 = (UnityEngine.TextAnchor)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        _this.textAnchor = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextGenerationSettings_resizeTextForBestFit(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        var result = _this.resizeTextForBestFit;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else {
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        _this.resizeTextForBestFit = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextGenerationSettings_resizeTextMinSize(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        var result = _this.resizeTextMinSize;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        _this.resizeTextMinSize = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextGenerationSettings_resizeTextMaxSize(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        var result = _this.resizeTextMaxSize;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        _this.resizeTextMaxSize = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextGenerationSettings_updateBounds(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        var result = _this.updateBounds;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else {
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        _this.updateBounds = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextGenerationSettings_verticalOverflow(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        var result = _this.verticalOverflow;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else {
        UnityEngine.VerticalWrapMode arg0 = (UnityEngine.VerticalWrapMode)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        _this.verticalOverflow = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextGenerationSettings_horizontalOverflow(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        var result = _this.horizontalOverflow;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else {
        UnityEngine.HorizontalWrapMode arg0 = (UnityEngine.HorizontalWrapMode)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        _this.horizontalOverflow = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextGenerationSettings_generationExtents(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        var result = _this.generationExtents;
                JSApi.setVector2S((int)JSApi.SetType.Rval, result);
    }
    else {
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        _this.generationExtents = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextGenerationSettings_pivot(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        var result = _this.pivot;
                JSApi.setVector2S((int)JSApi.SetType.Rval, result);
    }
    else {
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        _this.pivot = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextGenerationSettings_generateOutOfBounds(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        var result = _this.generateOutOfBounds;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else {
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.TextGenerationSettings _this = (UnityEngine.TextGenerationSettings)vc.csObj;
        _this.generateOutOfBounds = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// properties

// methods

static bool TextGenerationSettings_Equals__TextGenerationSettings(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.TextGenerationSettings arg0 = (UnityEngine.TextGenerationSettings)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
UnityEngine.TextGenerationSettings argThis = (UnityEngine.TextGenerationSettings)vc.csObj;                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(argThis.Equals(arg0)));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.TextGenerationSettings);
    ci.fields = new JSMgr.CSCallbackField[]
    {
        TextGenerationSettings_font,
        TextGenerationSettings_color,
        TextGenerationSettings_fontSize,
        TextGenerationSettings_lineSpacing,
        TextGenerationSettings_richText,
        TextGenerationSettings_scaleFactor,
        TextGenerationSettings_fontStyle,
        TextGenerationSettings_textAnchor,
        TextGenerationSettings_resizeTextForBestFit,
        TextGenerationSettings_resizeTextMinSize,
        TextGenerationSettings_resizeTextMaxSize,
        TextGenerationSettings_updateBounds,
        TextGenerationSettings_verticalOverflow,
        TextGenerationSettings_horizontalOverflow,
        TextGenerationSettings_generationExtents,
        TextGenerationSettings_pivot,
        TextGenerationSettings_generateOutOfBounds,

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(TextGenerationSettings_TextGenerationSettings1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(TextGenerationSettings_Equals__TextGenerationSettings, "Equals"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
