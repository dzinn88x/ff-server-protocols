using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A8 RID: 168
[Token(Token = "0x20000A8")]
public class NPCAnimPlay : MonoBehaviour
{
	// Token: 0x0600027B RID: 635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600027B")]
	[Address(RVA = "0x2290B0C", Offset = "0x2290B0C", VA = "0x7BBCA90B0C")]
	private void OnEnable()
	{
	}

	// Token: 0x0600027C RID: 636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600027C")]
	[Address(RVA = "0x2290C5C", Offset = "0x2290C5C", VA = "0x7BBCA90C5C")]
	public void OnAnimEventFire(bool isFire)
	{
	}

	// Token: 0x0600027D RID: 637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600027D")]
	[Address(RVA = "0x2290D0C", Offset = "0x2290D0C", VA = "0x7BBCA90D0C")]
	public NPCAnimPlay()
	{
	}

	// Token: 0x04000290 RID: 656
	[Token(Token = "0x4000290")]
	[FieldOffset(Offset = "0x18")]
	public string AnimName;

	// Token: 0x04000291 RID: 657
	[Token(Token = "0x4000291")]
	[FieldOffset(Offset = "0x20")]
	public GameObject FireEffect;
}
