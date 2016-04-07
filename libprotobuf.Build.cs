// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class libprotobuf : ModuleRules
{
	public libprotobuf(TargetInfo Target)
	{
		Type = ModuleType.External;

		string protobuf_code_directory_path = ModuleDirectoryPath + "/protobuf";

		PublicSystemIncludePaths.Add(protobuf_code_directory_path + "/src");

		string protobuf_lib_directory_full_path = ModuleDirectoryFullPath + "/lib";

        if (Target.Platform == UnrealTargetPlatform.Win32)
        {
            protobuf_lib_directory_full_path += "/vs" + WindowsPlatform.GetVisualStudioCompilerVersionName();
            PublicLibraryPaths.Add(protobuf_lib_directory_full_path);

            PublicAdditionalLibraries.Add("libprotobuf-lite.lib");

            Definitions.AddRange(
                new string[]
                {
                    "WIN32",
                    "_WINDOWS",
                    "NDEBUG",
                    "GOOGLE_PROTOBUF_CMAKE_BUILD",
                });
        }
        else if (Target.Platform == UnrealTargetPlatform.Win64)
		{
            protobuf_lib_directory_full_path += "/vs" + WindowsPlatform.GetVisualStudioCompilerVersionName() + "win64";
			PublicLibraryPaths.Add(protobuf_lib_directory_full_path);

			PublicAdditionalLibraries.Add("libprotobuf-lite.lib");

            Definitions.AddRange(
                new string[]
                {
                    "WIN64",
                    "_WINDOWS",
                    "NDEBUG",
                    "GOOGLE_PROTOBUF_CMAKE_BUILD",
                });
        }
    }

    string ModuleDirectoryPath
    {
        get { return "./"; }
    }

    string ModuleDirectoryFullPath
    {
        get { return System.IO.Path.GetFullPath(ModuleDirectory); }
    }
}

