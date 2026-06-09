using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001DF RID: 479
[Token(Token = "0x20001DF")]
public static class AudioFacade
{
	// Token: 0x060009DA RID: 2522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DA")]
	[Address(RVA = "0x1F8B10C", Offset = "0x1F8B10C", VA = "0x7BBC78B10C")]
	public static void SetImpl(IAudioInterface impl)
	{
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x00003DE0 File Offset: 0x00001FE0
	[Token(Token = "0x60009DB")]
	[Address(RVA = "0x1F8B198", Offset = "0x1F8B198", VA = "0x7BBC78B198")]
	public static ResourceID GetTwoDAudioSourceResID()
	{
		return default(ResourceID);
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x00003DF8 File Offset: 0x00001FF8
	[Token(Token = "0x60009DC")]
	[Address(RVA = "0x1F8B2D4", Offset = "0x1F8B2D4", VA = "0x7BBC78B2D4")]
	public static float GetDistanceToListener(Vector3 sound_pos)
	{
		return 0f;
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x00003E10 File Offset: 0x00002010
	[Token(Token = "0x60009DD")]
	[Address(RVA = "0x1F8B41C", Offset = "0x1F8B41C", VA = "0x7BBC78B41C")]
	public static int GetOneShotLimitInOneFrame()
	{
		return 0;
	}

	// Token: 0x0400093F RID: 2367
	[Token(Token = "0x400093F")]
	[FieldOffset(Offset = "0x0")]
	private static IAudioInterface m_Impl;
}
