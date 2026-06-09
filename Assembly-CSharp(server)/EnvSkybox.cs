using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200007F RID: 127
[Token(Token = "0x200007F")]
[Serializable]
public class EnvSkybox
{
	// Token: 0x060001AA RID: 426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x23F5FEC", Offset = "0x23F5FEC", VA = "0x7BBCBF5FEC")]
	public EnvSkybox()
	{
	}

	// Token: 0x040001B8 RID: 440
	[Token(Token = "0x40001B8")]
	[FieldOffset(Offset = "0x10")]
	public Color tint;

	// Token: 0x040001B9 RID: 441
	[Token(Token = "0x40001B9")]
	[FieldOffset(Offset = "0x20")]
	public Texture frontTex;

	// Token: 0x040001BA RID: 442
	[Token(Token = "0x40001BA")]
	[FieldOffset(Offset = "0x28")]
	public Texture backTex;

	// Token: 0x040001BB RID: 443
	[Token(Token = "0x40001BB")]
	[FieldOffset(Offset = "0x30")]
	public Texture leftTex;

	// Token: 0x040001BC RID: 444
	[Token(Token = "0x40001BC")]
	[FieldOffset(Offset = "0x38")]
	public Texture rightTex;

	// Token: 0x040001BD RID: 445
	[Token(Token = "0x40001BD")]
	[FieldOffset(Offset = "0x40")]
	public Texture upTex;

	// Token: 0x040001BE RID: 446
	[Token(Token = "0x40001BE")]
	[FieldOffset(Offset = "0x48")]
	public Texture downTex;

	// Token: 0x040001BF RID: 447
	[Token(Token = "0x40001BF")]
	[FieldOffset(Offset = "0x50")]
	public bool nightMode;
}
