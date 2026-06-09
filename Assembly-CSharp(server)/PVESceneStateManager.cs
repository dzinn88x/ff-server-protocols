using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200006F RID: 111
[Token(Token = "0x200006F")]
public class PVESceneStateManager : MonoBehaviour
{
	// Token: 0x06000151 RID: 337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000151")]
	[Address(RVA = "0x23C0F50", Offset = "0x23C0F50", VA = "0x7BBCBC0F50")]
	private void Start()
	{
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000152")]
	[Address(RVA = "0x23C105C", Offset = "0x23C105C", VA = "0x7BBCBC105C")]
	public void EnterState(int index)
	{
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000153")]
	[Address(RVA = "0x23C1214", Offset = "0x23C1214", VA = "0x7BBCBC1214")]
	public PVESceneStateManager()
	{
	}

	// Token: 0x04000170 RID: 368
	[Token(Token = "0x4000170")]
	[FieldOffset(Offset = "0x18")]
	public List<PVESceneState> Scenestats;

	// Token: 0x04000171 RID: 369
	[Token(Token = "0x4000171")]
	[FieldOffset(Offset = "0x20")]
	public EnvWeatherController WheatherManager;
}
