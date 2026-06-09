using System;
using System.Collections.Generic;
using Beebyte.Obfuscator;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001E RID: 30
[Token(Token = "0x200001E")]
public class AnimTriggerEffectHelper : MonoBehaviour
{
	// Token: 0x06000076 RID: 118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1F8A9CC", Offset = "0x1F8A9CC", VA = "0x7BBC78A9CC")]
	[SkipRename]
	public void TriggerEffect(int effectIndex)
	{
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1F8AB08", Offset = "0x1F8AB08", VA = "0x7BBC78AB08")]
	[SkipRename]
	public void CloseEffect(int effectIndex)
	{
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1F8AC44", Offset = "0x1F8AC44", VA = "0x7BBC78AC44")]
	public AnimTriggerEffectHelper()
	{
	}

	// Token: 0x04000091 RID: 145
	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x18")]
	public List<ParticleSystem> m_EffectsList;
}
