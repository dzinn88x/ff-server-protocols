using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001DE RID: 478
[Token(Token = "0x20001DE")]
public class IAudioInterfaceImplNone : IAudioInterface
{
	// Token: 0x060009D6 RID: 2518 RVA: 0x00003D98 File Offset: 0x00001F98
	[Token(Token = "0x60009D6")]
	[Address(RVA = "0x2751A00", Offset = "0x2751A00", VA = "0x7BBCF51A00", Slot = "4")]
	public ResourceID GetTwoDAudioSourceResID()
	{
		return default(ResourceID);
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x00003DB0 File Offset: 0x00001FB0
	[Token(Token = "0x60009D7")]
	[Address(RVA = "0x2751A68", Offset = "0x2751A68", VA = "0x7BBCF51A68", Slot = "5")]
	public float GetDistanceToListener(Vector3 sound_pos)
	{
		return 0f;
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x00003DC8 File Offset: 0x00001FC8
	[Token(Token = "0x60009D8")]
	[Address(RVA = "0x2751A70", Offset = "0x2751A70", VA = "0x7BBCF51A70", Slot = "6")]
	public int GetOneShotLimitInOneFrame()
	{
		return 0;
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D9")]
	[Address(RVA = "0x2751A78", Offset = "0x2751A78", VA = "0x7BBCF51A78")]
	public IAudioInterfaceImplNone()
	{
	}
}
