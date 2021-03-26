using UnrealBuildTool;

public class Ryuuji_OnsenTarget : TargetRules
{
	public Ryuuji_OnsenTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Ryuuji_Onsen");
	}
}
