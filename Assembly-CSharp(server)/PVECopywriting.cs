using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using message;
using UnityEngine;

// Token: 0x020000CA RID: 202
[Token(Token = "0x20000CA")]
public class PVECopywriting : ScriptableObject
{
	// Token: 0x06000323 RID: 803 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000323")]
	[Address(RVA = "0x22ABAE4", Offset = "0x22ABAE4", VA = "0x7BBCAABAE4")]
	public string GetRoundContent(int roundID)
	{
		return null;
	}

	// Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000324")]
	[Address(RVA = "0x22ABC38", Offset = "0x22ABC38", VA = "0x7BBCAABC38")]
	public SubtitleInfo PopBossRandomSubtitle()
	{
		return null;
	}

	// Token: 0x06000325 RID: 805 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000325")]
	[Address(RVA = "0x22ABD38", Offset = "0x22ABD38", VA = "0x7BBCAABD38")]
	public SubtitleInfo GetSkillTalkContent(\u0081}\u0082XTuu skillType)
	{
		return null;
	}

	// Token: 0x06000326 RID: 806 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000326")]
	[Address(RVA = "0x22ABE74", Offset = "0x22ABE74", VA = "0x7BBCAABE74")]
	public string GetGameRuleTipByIndex(int index)
	{
		return null;
	}

	// Token: 0x06000327 RID: 807 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000327")]
	[Address(RVA = "0x22ABF34", Offset = "0x22ABF34", VA = "0x7BBCAABF34")]
	public SubtitleInfo GetPlayerDeadContent(bool isTeamDead)
	{
		return null;
	}

	// Token: 0x06000328 RID: 808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000328")]
	[Address(RVA = "0x22AC048", Offset = "0x22AC048", VA = "0x7BBCAAC048")]
	public PVECopywriting()
	{
	}

	// Token: 0x0400033C RID: 828
	[Token(Token = "0x400033C")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x10FFE0C", Offset = "0x10FFE0C")]
	public List<RoundTargetInfo> RoundTargetContent;

	// Token: 0x0400033D RID: 829
	[Token(Token = "0x400033D")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x10FFE44", Offset = "0x10FFE44")]
	public List<SubtitleInfo> BossRandomSubtitle;

	// Token: 0x0400033E RID: 830
	[Token(Token = "0x400033E")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x10FFE7C", Offset = "0x10FFE7C")]
	public List<SubtitleInfo> PlayerDeadSubtitle;

	// Token: 0x0400033F RID: 831
	[Token(Token = "0x400033F")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x10FFEB4", Offset = "0x10FFEB4")]
	public List<SubtitleInfo> TeamDeadSubtitle;

	// Token: 0x04000340 RID: 832
	[Token(Token = "0x4000340")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x10FFEEC", Offset = "0x10FFEEC")]
	public List<SkillSubtitleInfo> BossSkillTalkContent;

	// Token: 0x04000341 RID: 833
	[Token(Token = "0x4000341")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x10FFF24", Offset = "0x10FFF24")]
	public List<RuleInfo> GameRuleInfo;
}
