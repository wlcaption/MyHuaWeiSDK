using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
using System.Text;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

public class Build : MonoBehaviour
{

    public static string[] scenes;

    private static string scriptingDefineSymbolsForGroup = "";

    public static string buildfilename = "Info.plist";

    private static List<string> channelList = new List<string> { "MY_WAR_DEBUG", "XIAOMI", "HUAWEI", "QIHOO360", "OPPO", "UC", "VIVO", "KY", "QQ","IYIQI","LESHI","DOWNJOY","MEIZU","AMIGO","COOLPAD","MZW","ANZHI","WDJ","LENOVO","PYW","HOLA","VIVO","TT","HAIMA" };

    // Scenes in this list will not be included in builds using asset bundles
    public static List<string> sceneDisableList = new List<string>{"LoadingScreen", "BattleScene", "FrontEndScene",
																   "AppReloadScene", "debugScene"};

    [MenuItem("build/Andriod/QQ")]
    static void AndroidQQ()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.tencent.tmgp.yxgsd";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();
        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "QQ");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("QQ") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";QQ");
        }

        AndroidBuild(options, "Android_QQ");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/xiaomi")]
    static void AndroidXiaomi()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.wpgsd.mi";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();
        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "XIAOMI");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("XIAOMI") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";XIAOMI");
        }

        AndroidBuild(options, "Android_Xiaomi");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/Debug")]
    static void AndroidBuildDebug()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.tencent.tmgp.yxgsd";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();
        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "MY_WAR_DEBUG");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("MY_WAR_DEBUG") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";MY_WAR_DEBUG");
        }

        AndroidBuild(options, "Android_MY_WAR_DEBUG");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }


    [MenuItem("build/Andriod/Huawei")]
    static void AndroidHuawei()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.huawei";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();
        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "HUAWEI");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("HUAWEI") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";HUAWEI");
        }

        AndroidBuild(options, "Android_HUAWEI");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/360")]
    static void Android360()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.qihoo360";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "QIHOO360");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("QIHOO360") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";QIHOO360");
        }

        AndroidBuild(options, "Android_360");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/OPPO")]
    static void AndroidOPPO()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.nearme.gamecenter";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "OPPO");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("OPPO") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";OPPO");
        }

        AndroidBuild(options, "Android_OPPO");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/UC")]
    static void AndroidUC()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.uc";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "UC");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("UC") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";UC");
        }

        AndroidBuild(options, "Android_UC");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/VIVO")]
    static void AndroidVIVO()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.vivo";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "VIVO");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("VIVO") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";VIVO");
        }

        AndroidBuild(options, "Android_VIVO");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

   
    [MenuItem("build/Andriod/IQIYI")]
    static void AndroidIQIYI()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.iqiyi";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "IQIYI");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("IQIYI") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";IQIYI");
        }

        AndroidBuild(options, "Android_IQIYI");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/MZW")]
    static void AndroidMZW()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.mzw";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "MZW");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("MZW") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";MZW");
        }

        AndroidBuild(options, "Android_MZW");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/BAIDU")]
    static void AndroidBAIDU()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.baidu";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "BAIDU");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("BAIDU") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";BAIDU");
        }

        AndroidBuild(options, "Android_BAIDU");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/AMIGO")]
    static void AndroidAMIGO()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.am";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "AMIGO");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("AMIGO") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";AMIGO");
        }

        AndroidBuild(options, "Android_AMIGO");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/MEIZU")]
    static void AndroidMEIZU()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.mz";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "MEIZU");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("MEIZU") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";MEIZU");
        }

        AndroidBuild(options, "Android_MEIZU");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/COOLPAD")]
    static void AndroidCOOLPAD()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.coolpad";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "COOLPAD");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("COOLPAD") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";COOLPAD");
        }

        AndroidBuild(options, "Android_COOLPAD");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/LESHI")]
    static void AndroidLESHI()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.leshi";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "LESHI");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("LESHI") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";LESHI");
        }

        AndroidBuild(options, "Android_LESHI");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }
    [MenuItem("build/Andriod/DOWNJOY")]
    static void AndroidDOWNJOY()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.downjoy";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "DOWNJOY");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("DOWNJOY") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";DOWNJOY");
        }

        AndroidBuild(options, "Android_DOWNJOY");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/SIGNBAIDU")]
    static void AndroidTESTBAIDU()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.test.myactivity";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "SIGNBAIDU");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("SIGNBAIDU") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";SIGNBAIDU");
        }

        AndroidBuild(options, "Android_SIGNBAIDU");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/ANZHI")]
    static void AndroidANZHI()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.anzhi";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "ANZHI");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("ANZHI") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";ANZHI");
        }

        AndroidBuild(options, "Android_ANZHI");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/WDJ")]
    static void AndroidWDJ()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.wdj";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "WDJ");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("WDJ") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";WDJ");
        }

        AndroidBuild(options, "Android_WDJ");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/LENOVO")]
    static void AndroidLENOVO()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.lenovo";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "LENOVO");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("LENOVO") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";LENOVO");
        }

        AndroidBuild(options, "Android_LENOVO");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/PYW")]
    static void AndroidPYW()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.pyw";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "PYW");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("PYW") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";PYW");
        }

        AndroidBuild(options, "Android_PYW");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/HOLA")]
    static void AndroidHOLA()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.hola";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "HOLA");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("HOLA") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";PYW");
        }

        AndroidBuild(options, "Android_HOLA");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/TT")]
    static void AndroidTT()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.tt";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "TT");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("TT") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";TT");
        }

        AndroidBuild(options, "Android_TT");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    [MenuItem("build/Andriod/HAIMA")]
    static void AndroidHaiMa()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.hm";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
        ResetscriptingDefineSymbolsForGroup();

        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "HAIMA");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("HAIMA") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup + ";HAIMA");
        }

        AndroidBuild(options, "Android_HAIMA");

        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, scriptingDefineSymbolsForGroup);
    }

    static void AndroidBuild(BuildOptions options = BuildOptions.None, string buildPath = "Android_apk")
    {

        if (!Directory.Exists(buildPath))
        {
            Directory.CreateDirectory(buildPath);
        }
        else
        {
            Directory.Delete(buildPath, true);
            Directory.CreateDirectory(buildPath);
        }


        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
        Debug.ClearDeveloperConsole();
        AndroidManifestobbUpdate();
        DisableBundledScenes();
        MoiveFilestoPlugins();




        BuildPipeline.BuildPlayer(scenes, buildPath + "/My_war_" + buildPath + "_" + PlayerSettings.shortBundleVersion + ".apk", BuildTarget.Android, options);


        MoiveFilesFromPlugins();
    }


    static void IosBuild(BuildOptions options = BuildOptions.None, string buildPath = "ios_default")
    {

        if (!Directory.Exists(buildPath))
        {
            Directory.CreateDirectory(buildPath);
        }
        else
        {
            Directory.Delete(buildPath, true);
            Directory.CreateDirectory(buildPath);
        }


        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.iPhone);
        Debug.ClearDeveloperConsole();
        DisableBundledScenes();
        BuildPipeline.BuildPlayer(scenes, buildPath + "/My_war_" + buildPath, BuildTarget.iPhone, options);

    }


    [MenuItem("build/ios/KY")]
    static void IOSKuaiyong()
    {
        BuildOptions options = BuildOptions.None;

        PlayerSettings.productName = "一血敢死队";
        PlayerSettings.bundleIdentifier = "com.qianhuan.yxgsd.7659";
        PlayerSettings.Android.useAPKExpansionFiles = false;

        scriptingDefineSymbolsForGroup = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.iPhone);
        ResetscriptingDefineSymbolsForGroup();
        if (scriptingDefineSymbolsForGroup == "")
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iPhone, "KY");
        }
        else if (scriptingDefineSymbolsForGroup.IndexOf("KY") == -1)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iPhone, scriptingDefineSymbolsForGroup + ";KY");
        }

        IosBuild(options, "ios_KY");



        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iPhone, scriptingDefineSymbolsForGroup);
    }


    private static void ResetscriptingDefineSymbolsForGroup()
    {
        string[] mList = scriptingDefineSymbolsForGroup.Split(';');

        StringBuilder _newStr = new StringBuilder();
        for (var i = 0; i < mList.Length; i++)
        {
            if (!channelList.Contains(mList[i]))
            {
                if (_newStr.Length > 0)
                {
                    _newStr.Append(";");
                }
                _newStr.Append(mList[i]);
            }
        }

        scriptingDefineSymbolsForGroup = _newStr.ToString();
    }

    private static void DisableBundledScenes()
    {
        EditorBuildSettingsScene[] sceneList = EditorBuildSettings.scenes;
        foreach (EditorBuildSettingsScene scene in sceneList)
        {
            scene.enabled = !scene.path.Contains("Bundled");
        }

        EditorBuildSettings.scenes = sceneList;

        scenes = sceneList.Where(s => s.enabled).Select(s => s.path).ToArray();
    }

    static List<string> mFilesList = new List<string>();
    static List<string> mAssestFiles = new List<string>();
    static List<string> mAssestDirects = new List<string>();
    static List<string> mLibsFiles = new List<string>();
    static List<string> mLibsDirects = new List<string>();
    static List<string> mLibsAllFiles = new List<string>();
    static List<string> mLibsAllDirects = new List<string>();
    static void MoiveFilestoPlugins()
    {

        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("MY_WAR_DEBUG") != -1)
        {
            return;
        }

        mFilesList.Clear();
        mAssestDirects.Clear();
        mAssestFiles.Clear();
        mLibsDirects.Clear();
        mLibsFiles.Clear();

        mLibsAllDirects.Clear();
        mLibsAllFiles.Clear();

        string _path = "";
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("XIAOMI") != -1)
        {
            _path = "./Assets/xiaomi/";
        }

        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("QIHOO360") != -1)
        {
            _path = "./Assets/360/";
        }

        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("UC") != -1)
        {
            _path = "./Assets/UC/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("OPPO") != -1)
        {
            _path = "./Assets/oppo/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("HUAWEI") != -1)
        {
            _path = "./Assets/huawei/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("VIVO") != -1)
        {
            _path = "./Assets/VIVO/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("QQ") != -1)
        {
            _path = "./Assets/QQ/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("BAIDU") != -1)
        {
            _path = "./Assets/BAIDU/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("IQIYI") != -1)
        {
            _path = "./Assets/IQIYI/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("MZW") != -1)
        {
            _path = "./Assets/MZW/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("AMIGO") != -1)
        {
            _path = "./Assets/AMIGO/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("MEIZU") != -1)
        {
            _path = "./Assets/MEIZU/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("COOLPAD") != -1)
        {
            _path = "./Assets/COOLPAD/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("LESHI") != -1)
        {
            _path = "./Assets/LESHI/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("DOWNJOY") != -1)
        {
            _path = "./Assets/DOWNJOY/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("SIGNBAIDU") != -1)
        {
            _path = "./Assets/SIGNBAIDU/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("ANZHI") != -1)
        {
            _path = "./Assets/ANZHI/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("WDJ") != -1)
        {
            _path = "./Assets/WDJ/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("LENOVO") != -1)
        {
            _path = "./Assets/LENOVO/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("PYW") != -1)
        {
            _path = "./Assets/PYW/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("HOLA") != -1)
        {
            _path = "./Assets/HOLA/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("TT") != -1)
        {
            _path = "./Assets/TT/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("HAIMA") != -1)
        {
            _path = "./Assets/HaiMa/";
        }

        //先删除保证能复制进去
        if (Directory.Exists("./Assets/Plugins/Android/res"))
        {
            Directory.Delete("./Assets/Plugins/Android/res", true);
        }
        if (Directory.Exists("./Assets/Plugins/Android/assets"))
        {
            Directory.Delete("./Assets/Plugins/Android/assets", true);
        }

        Directory.CreateDirectory("./Assets/Plugins/Android/assets");
        if (Directory.Exists(_path + "res"))
        {
            Directory.Move(_path + "res", "./Assets/Plugins/Android/res");
        }

        DirectoryInfo di = new DirectoryInfo(_path);
        DirectoryInfo diAssets = new DirectoryInfo(_path + "assets/");
        DirectoryInfo diLibs = new DirectoryInfo(_path + "libs/");


        FileInfo[] mFiles = di.GetFiles();
        foreach (var i in mFiles)
        {
            if (i.Name.IndexOf(".meta") == -1)
            {
                Debug.Log("moveFile=" + i.Name);
                File.Move(_path + i.Name, "./Assets/Plugins/Android/" + i.Name);
                mFilesList.Add(i.Name);
            }
        }

        FileInfo[] mFilesAsstes = diAssets.GetFiles();
        foreach (var i in mFilesAsstes)
        {

            if (i.Name.IndexOf(".meta") == -1)
            {
                Debug.Log("mFilesAsstes=" + i.Name);
                File.Move(_path + "assets/" + i.Name, "./Assets/Plugins/Android/assets/" + i.Name);
                mAssestFiles.Add(i.Name);
            }
        }

        DirectoryInfo[] mDicretions = diAssets.GetDirectories();
        foreach (var i in mDicretions)
        {
            Debug.Log("mDicretions=" + i.Name);
            mAssestDirects.Add(i.Name);
            Directory.Move(_path + "assets/" + i.Name, "./Assets/Plugins/Android/assets/" + i.Name);
        }




        FileInfo[] mLibs = diLibs.GetFiles();
        foreach (var i in mLibs)
        {
            if (i.Name.IndexOf(".meta") == -1)
            {
                Debug.Log("mFilesAsstes=" + i.Name);
                File.Move(_path + "libs/" + i.Name, "./Assets/Plugins/Android/libs/" + i.Name);
                mLibsFiles.Add(i.Name);
            }
        }

        DirectoryInfo[] mLibsDicretions = diLibs.GetDirectories();
        foreach (var i in mLibsDicretions)
        {
            Debug.Log("mDicretions=" + i.Name);
            mLibsDirects.Add(i.Name);
            //Directory.Move(_path + "libs/" + i.Name, "./Assets/Plugins/Android/libs/" + i.Name);

            FileInfo[] mLibsFile = i.GetFiles();
            foreach (var j in mLibsFile)
            {
                if (j.Name.IndexOf(".meta") == -1)
                {
                    mLibsAllDirects.Add(i.Name);
                    mLibsAllFiles.Add(j.Name);
                    Debug.Log(i.Name);
                    File.Move(_path + "libs/" + i.Name + "/" + j.Name, "./Assets/Plugins/Android/libs/" + i.Name + "/" + j.Name);
                }
            }
        }

    }

    static void MoiveFilesFromPlugins()
    {

        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("MY_WAR_DEBUG") != -1)
        {
            return;
        }

        string _path = "";
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("XIAOMI") != -1)
        {
            _path = "./Assets/xiaomi/";
        }

        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("UC") != -1)
        {
            _path = "./Assets/UC/";
        }

        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("QIHOO360") != -1)
        {
            _path = "./Assets/360/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("MYFOUR") != -1)
        {
            _path = "./Assets/MYFOUR/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("OPPO") != -1)
        {
            _path = "./Assets/oppo/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("HUAWEI") != -1)
        {
            _path = "./Assets/huawei/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("VIVO") != -1)
        {
            _path = "./Assets/VIVO/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("QQ") != -1)
        {
            _path = "./Assets/QQ/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("BAIDU") != -1)
        {
            _path = "./Assets/BAIDU/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("IQIYI") != -1)
        {
            _path = "./Assets/IQIYI/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("MZW") != -1)
        {
            _path = "./Assets/MZW/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("AMIGO") != -1)
        {
            _path = "./Assets/AMIGO/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("MEIZU") != -1)
        {
            _path = "./Assets/MEIZU/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("COOLPAD") != -1)
        {
            _path = "./Assets/COOLPAD/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("LESHI") != -1)
        {
            _path = "./Assets/LESHI/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("DOWNJOY") != -1)
        {
            _path = "./Assets/DOWNJOY/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("ANZHI") != -1)
        {
            _path = "./Assets/ANZHI/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("WDJ") != -1)
        {
            _path = "./Assets/WDJ/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("LENOVO") != -1)
        {
            _path = "./Assets/LENOVO/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("PYW") != -1)
        {
            _path = "./Assets/PYW/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("HOLA") != -1)
        {
            _path = "./Assets/HOLA/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("TT") != -1)
        {
            _path = "./Assets/TT/";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("HAIMA") != -1)
        {
            _path = "./Assets/HAIMA/";
        }

        //先删除，保证能复制进去
        if (Directory.Exists(_path + "res"))
        {
            Directory.Delete(_path + "res", true);
        }

        if (Directory.Exists("./Assets/Plugins/Android/res"))
        {
            Directory.Move("./Assets/Plugins/Android/res", _path + "res");
        }

        if (Directory.Exists("./Assets/Plugins/Android/res"))
        {
            Directory.Delete("./Assets/Plugins/Android/res", true);
        }


        foreach (var i in mFilesList)
        {
            if (File.Exists("./Assets/Plugins/Android/" + i))
            {
                File.Move("./Assets/Plugins/Android/" + i, _path + i);
            }
        }

        //先删除，保证能复制进去
        if (Directory.Exists(_path + "assets"))
        {
            Directory.Delete(_path + "assets", true);
        }
        Directory.CreateDirectory(_path + "assets");

        foreach (var i in mAssestFiles)
        {
            if (File.Exists("./Assets/Plugins/Android/assets/" + i))
            {
                File.Move("./Assets/Plugins/Android/assets/" + i, _path + "assets/" + i);
            }
        }

        foreach (var i in mAssestDirects)
        {
            if (Directory.Exists(_path + "assets/" + i))
            {
                Directory.Delete(_path + "assets/" + i);
            }
            if (Directory.Exists("./Assets/Plugins/Android/assets/" + i))
            {
                Directory.Move("./Assets/Plugins/Android/assets/" + i, _path + "assets/" + i);
            }
        }



        //先删除，保证能复制进去
        if (Directory.Exists(_path + "libs"))
        {
            Directory.Delete(_path + "libs", true);
        }
        Directory.CreateDirectory(_path + "libs");

        foreach (var i in mLibsFiles)
        {
            if (File.Exists("./Assets/Plugins/Android/libs/" + i))
            {
                File.Move("./Assets/Plugins/Android/libs/" + i, _path + "libs/" + i);
            }
        }

        foreach (var i in mLibsDirects)
        {
            if (Directory.Exists(_path + "libs/" + i))
            {
                Directory.Delete(_path + "libs/" + i);
            }
            Directory.CreateDirectory(_path + "libs/" + i);
        }


        for (int i = 0; i < mLibsAllDirects.Count; i++)
        {
            Debug.Log(mLibsAllDirects[i]);
            //if (File.Exists("./Assets/Plugins/Android/libs/" + mLibsAllDirects[i]))
            {
                Debug.Log(mLibsAllDirects[i]);
                File.Move("./Assets/Plugins/Android/libs/" + mLibsAllDirects[i] + "/" + mLibsAllFiles[i], _path + "libs/" + mLibsAllDirects[i] + "/" + mLibsAllFiles[i]);
            }
        }
    }

    static void AndroidManifestobbUpdate()
    {
        string androidManifest = "./Assets/Plugins/Android/AndroidManifest.xml";
        string androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_debug.xml";


        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("HUAWEI") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_huawei.xml";
        }

        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("XIAOMI") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_xiaomi.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("QIHOO360") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_360.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("OPPO") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_oppo.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("UC") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_uc.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("VIVO") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_vivo.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("QQ") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_QQ.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("BAIDU") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_baidu.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("IQIYI") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_iqiyi.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("MZW") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_mzw.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("AMIGO") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_am.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("MEIZU") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_mz.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("COOLPAD") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_coolpad.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("LESHI") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_leshi.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("DOWNJOY") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_downjoy.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("SIGNBAIDU") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_signbaidu.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("ANZHI") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_anzhi.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("WDJ") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_wdj.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("LENOVO") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_lenovo.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("PYW") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_pyw.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("HOLA") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_hola.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("TT") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_tt.xml";
        }
        if (PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android).IndexOf("HAIMA") != -1)
        {
            androidManifest_replace = "./Assets/Plugins/Android/AndroidManifest_hm.xml";
        }
        if (File.Exists(androidManifest))
        {
            FileInfo myFile = new FileInfo(androidManifest);
            myFile.IsReadOnly = false;


            var fileContents = System.IO.File.ReadAllText(androidManifest_replace);


            Debug.Log(PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android));
            Debug.Log(fileContents);

            System.IO.File.WriteAllText(androidManifest, fileContents);
        }
        else
        {
            Debug.LogError("AndroidManifest.xml does not exist to update for splitting.");

        }
    }
}
