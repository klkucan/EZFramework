/*
 * Author:      熊哲
 * CreateTime:  4/19/2017 2:20:04 PM
 * Description:
 * 
*/
using System;
using System.Collections.Generic;
using XLua;

namespace EZFramework.XLuaGen
{
    public static class CSharpGenList
    {
        [LuaCallCSharp]
        public static List<Type> LuaCallCSharp = new List<Type>()
        {
            typeof(System.Collections.Generic.Dictionary<string, object>),
        };

        [CSharpCallLua]
        public static List<Type> CSharpCallLua = new List<Type>()
        {
            typeof(System.Action),
            typeof(System.Action<string>),
            typeof(System.Action<double>),
            typeof(System.Action<float>),
            typeof(System.Action<WWWTask, bool>),
            typeof(System.Func<>),
            typeof(System.Collections.IEnumerator),
        };

        [BlackList]
        public static List<List<string>> BlackList = new List<List<string>>()
        {

        };
    }
}