﻿using UnityEngine;
using System.Collections;

namespace LocalizationEditor
{
    public class LECodeGenConstants
    {
        public static string ClassFilePathPrefix = "APIScripts/";
        public static string StaticKeysFilePath = ClassFilePathPrefix + "LEKeys.cs";

        public static string AutoGenMsg = @"// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by the Localization Editor.
//
//      Changes to this file will be lost if the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------";
        
        public static string StaticKeyClassHeader = @"using UnityEngine;
using System;

namespace LocalizationEditor
{
    public class LEKeys
    {";

        public static string StaticKeyFormat = "public static string {0} = \"{0}\";";

        public static int IndentLevel1 = 4;
        public static int IndentLevel2 = IndentLevel1 * 2;
    }
}