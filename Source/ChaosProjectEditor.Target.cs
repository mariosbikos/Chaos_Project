// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class ChaosProjectEditorTarget : TargetRules
{
	public ChaosProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        bCompileChaos = true;
        BuildEnvironment = TargetBuildEnvironment.Unique;
        ExtraModuleNames.AddRange( new string[] { "ChaosProject" } );
	}
}
