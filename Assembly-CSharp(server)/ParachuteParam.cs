using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000C3 RID: 195
[Token(Token = "0x20000C3")]
[Serializable]
public class ParachuteParam
{
	// Token: 0x0600031D RID: 797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600031D")]
	[Address(RVA = "0x23C151C", Offset = "0x23C151C", VA = "0x7BBCBC151C")]
	public ParachuteParam()
	{
	}

	// Token: 0x04000322 RID: 802
	[Token(Token = "0x4000322")]
	[FieldOffset(Offset = "0x10")]
	public float UpOffset;

	// Token: 0x04000323 RID: 803
	[Token(Token = "0x4000323")]
	[FieldOffset(Offset = "0x14")]
	public float BackOffset;

	// Token: 0x04000324 RID: 804
	[Token(Token = "0x4000324")]
	[FieldOffset(Offset = "0x18")]
	public float FOV;

	// Token: 0x04000325 RID: 805
	[Token(Token = "0x4000325")]
	[FieldOffset(Offset = "0x1C")]
	public bool ImmediateChange;

	// Token: 0x04000326 RID: 806
	[Token(Token = "0x4000326")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve AnimCur;

	// Token: 0x04000327 RID: 807
	[Token(Token = "0x4000327")]
	[FieldOffset(Offset = "0x28")]
	public CameraShakeParam ShakeParam;
}
