using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E3 RID: 483
[Token(Token = "0x20001E3")]
public class HeroMaterialUtility
{
	// Token: 0x060009E0 RID: 2528 RVA: 0x00003E28 File Offset: 0x00002028
	[Token(Token = "0x60009E0")]
	[Address(RVA = "0x2751550", Offset = "0x2751550", VA = "0x7BBCF51550")]
	public static bool IsHeroBattleShader(Material m)
	{
		return default(bool);
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E1")]
	[Address(RVA = "0x2751674", Offset = "0x2751674", VA = "0x7BBCF51674")]
	public static void GetShaderProperty(string name, out bool shadow, out bool translucent, out bool occlusion)
	{
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E2")]
	[Address(RVA = "0x2751784", Offset = "0x2751784", VA = "0x7BBCF51784")]
	public static string MakeShaderName(string name, bool shadow, bool translucent, bool occlusion)
	{
		return null;
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E3")]
	[Address(RVA = "0x27519F8", Offset = "0x27519F8", VA = "0x7BBCF519F8")]
	public HeroMaterialUtility()
	{
	}

	// Token: 0x0400094F RID: 2383
	[Token(Token = "0x400094F")]
	private const string token_shadow = " (Shadow)";

	// Token: 0x04000950 RID: 2384
	[Token(Token = "0x4000950")]
	private const string token_translucent = " (Translucent)";

	// Token: 0x04000951 RID: 2385
	[Token(Token = "0x4000951")]
	private const string token_occlusion = " (Occlusion)";
}
