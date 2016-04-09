// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class libprotobuf : ModuleRules
{
    public libprotobuf(TargetInfo Target)
    {
        Type = ModuleType.External;

        bool is_supported = false;
        if ((Target.Platform == UnrealTargetPlatform.Win32) || (Target.Platform == UnrealTargetPlatform.Win64))
        {
            is_supported = true;

            string vs_path = "vs"
                + WindowsPlatform.GetVisualStudioCompilerVersionName()
                + ((Target.Platform == UnrealTargetPlatform.Win64) ? "win64" : "");
            string protobuf_lib_directory_full_path = System.IO.Path.Combine(ModuleDirectoryFullPath, "lib", vs_path);

            PublicLibraryPaths.Add(protobuf_lib_directory_full_path);

            PublicAdditionalLibraries.Add("libprotobuf.lib");

            Definitions.AddRange(
                new string[]
                {
                    ((Target.Platform == UnrealTargetPlatform.Win64) ? "WIN64" : "WIN32"),
                    "_WINDOWS",
                    "NDEBUG",
                    "GOOGLE_PROTOBUF_CMAKE_BUILD",
                });
        }

        if (is_supported)
        {
            string protobuf_code_directory_full_path = System.IO.Path.Combine(ModuleDirectoryFullPath, "protobuf", "src");

            PublicSystemIncludePaths.Add(protobuf_code_directory_full_path);
        }
    }

    string ModuleDirectoryFullPath
    {
        get { return System.IO.Path.GetFullPath(ModuleDirectory); }
    }
}

