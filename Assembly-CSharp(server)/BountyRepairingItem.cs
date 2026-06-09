using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000D8 RID: 216
[Token(Token = "0x20000D8")]
public class BountyRepairingItem : MonoBehaviour
{
	// Token: 0x060003B4 RID: 948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x1F90B50", Offset = "0x1F90B50", VA = "0x7BBC790B50")]
	public void PlayEffect()
	{
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x1F90C78", Offset = "0x1F90C78", VA = "0x7BBC790C78")]
	public BountyRepairingItem()
	{
	}

	// Token: 0x04000379 RID: 889
	[Token(Token = "0x4000379")]
	[FieldOffset(Offset = "0x18")]
	public UILabel PlayerName;

	// Token: 0x0400037A RID: 890
	[Token(Token = "0x400037A")]
	[FieldOffset(Offset = "0x20")]
	public UILabel PlayerPoint;

	// Token: 0x0400037B RID: 891
	[Token(Token = "0x400037B")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem Effec;
}
