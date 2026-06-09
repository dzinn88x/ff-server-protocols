using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000C4 RID: 196
[Token(Token = "0x20000C4")]
public class ParachuteStateParameter : ScriptableObject
{
	// Token: 0x0600031E RID: 798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600031E")]
	[Address(RVA = "0x23C1524", Offset = "0x23C1524", VA = "0x7BBCBC1524")]
	public ParachuteStateParameter()
	{
	}

	// Token: 0x04000328 RID: 808
	[Token(Token = "0x4000328")]
	[FieldOffset(Offset = "0x18")]
	public ParachuteParam OnBoard;

	// Token: 0x04000329 RID: 809
	[Token(Token = "0x4000329")]
	[FieldOffset(Offset = "0x20")]
	public ParachuteParam OnSkyDiving;

	// Token: 0x0400032A RID: 810
	[Token(Token = "0x400032A")]
	[FieldOffset(Offset = "0x28")]
	public ParachuteParam OnSkySurfing;

	// Token: 0x0400032B RID: 811
	[Token(Token = "0x400032B")]
	[FieldOffset(Offset = "0x30")]
	public ParachuteParam OnParachuting;

	// Token: 0x0400032C RID: 812
	[Token(Token = "0x400032C")]
	[FieldOffset(Offset = "0x38")]
	public ParachuteParam OnMountSkyDiving;

	// Token: 0x0400032D RID: 813
	[Token(Token = "0x400032D")]
	[FieldOffset(Offset = "0x40")]
	public ParachuteParam OnMountSkySurfing;

	// Token: 0x0400032E RID: 814
	[Token(Token = "0x400032E")]
	[FieldOffset(Offset = "0x48")]
	public ParachuteParam OnMountParachuting;
}
