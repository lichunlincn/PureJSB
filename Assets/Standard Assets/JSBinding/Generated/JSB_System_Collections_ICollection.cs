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

public class JSB_System_Collections_ICollection
{

////////////////////// ICollection ///////////////////////////////////////
// constructors

// fields

// properties
static void ICollection_Count(JSVCall vc)
{
        System.Collections.ICollection _this = (System.Collections.ICollection)vc.csObj;
        var result = _this.Count;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}
static void ICollection_IsSynchronized(JSVCall vc)
{
        System.Collections.ICollection _this = (System.Collections.ICollection)vc.csObj;
        var result = _this.IsSynchronized;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void ICollection_SyncRoot(JSVCall vc)
{
        System.Collections.ICollection _this = (System.Collections.ICollection)vc.csObj;
        var result = _this.SyncRoot;
                JSMgr.datax.setWhatever((int)JSApi.SetType.Rval, result);
}

// methods

static bool ICollection_CopyTo__Array__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.Array arg0 = (System.Array)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        ((System.Collections.ICollection)vc.csObj).CopyTo(arg0, arg1);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(System.Collections.ICollection);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        ICollection_Count,
        ICollection_IsSynchronized,
        ICollection_SyncRoot,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(ICollection_CopyTo__Array__Int32, "CopyTo"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}