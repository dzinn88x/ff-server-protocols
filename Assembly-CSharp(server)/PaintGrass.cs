using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000202 RID: 514
[Token(Token = "0x2000202")]
public class PaintGrass : PaintMeshes
{
	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x06000A3B RID: 2619 RVA: 0x00003F90 File Offset: 0x00002190
	[Token(Token = "0x170000B7")]
	public override bool HasMesh
	{
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x23C121C", Offset = "0x23C121C", VA = "0x7BBCBC121C", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A3C")]
	[Address(RVA = "0x23C128C", Offset = "0x23C128C", VA = "0x7BBCBC128C")]
	public PaintGrass()
	{
	}

	// Token: 0x04000999 RID: 2457
	[Token(Token = "0x4000999")]
	[FieldOffset(Offset = "0x58")]
	public Sprite currentSprite;

	// Token: 0x0400099A RID: 2458
	[Token(Token = "0x400099A")]
	[FieldOffset(Offset = "0x60")]
	private readonly Vector2 grassBlockSize;
}
