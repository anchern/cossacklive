// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CossackLive : ModuleRules
{
	public CossackLive(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"CossackLive",
			"CossackLive/Variant_Platforming",
			"CossackLive/Variant_Platforming/Animation",
			"CossackLive/Variant_Combat",
			"CossackLive/Variant_Combat/AI",
			"CossackLive/Variant_Combat/Animation",
			"CossackLive/Variant_Combat/Gameplay",
			"CossackLive/Variant_Combat/Interfaces",
			"CossackLive/Variant_Combat/UI",
			"CossackLive/Variant_SideScrolling",
			"CossackLive/Variant_SideScrolling/AI",
			"CossackLive/Variant_SideScrolling/Gameplay",
			"CossackLive/Variant_SideScrolling/Interfaces",
			"CossackLive/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
