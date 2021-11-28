// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class C_M_PT_09 : ModuleRules
{
	public C_M_PT_09(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
