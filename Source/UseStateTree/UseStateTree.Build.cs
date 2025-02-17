﻿// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UseStateTree : ModuleRules
{
	public UseStateTree(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"CommonUI",
			}
		);


		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CommonUI",
				"CoreUObject",
				"Engine",
				"GameplayAbilities",
				"GameplayStateTreeModule",
				"GameplayTags",
				"Slate",
				"SlateCore",
				"StateTreeModule",
				"UMG",
			}
		);
	}
}