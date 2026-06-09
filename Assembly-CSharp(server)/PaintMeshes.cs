using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000203 RID: 515
[Token(Token = "0x2000203")]
public class PaintMeshes : MonoBehaviour
{
	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00003FA8 File Offset: 0x000021A8
	[Token(Token = "0x170000B8")]
	public int meshCount
	{
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x23C1410", Offset = "0x23C1410", VA = "0x7BBCBC1410")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x06000A3E RID: 2622 RVA: 0x00003FC0 File Offset: 0x000021C0
	[Token(Token = "0x170000B9")]
	public virtual bool HasMesh
	{
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x23C1500", Offset = "0x23C1500", VA = "0x7BBCBC1500", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000A3F RID: 2623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A3F")]
	[Address(RVA = "0x23C12D0", Offset = "0x23C12D0", VA = "0x7BBCBC12D0")]
	public PaintMeshes()
	{
	}

	// Token: 0x0400099B RID: 2459
	[Token(Token = "0x400099B")]
	[FieldOffset(Offset = "0x18")]
	public float radius;

	// Token: 0x0400099C RID: 2460
	[Token(Token = "0x400099C")]
	[FieldOffset(Offset = "0x1C")]
	public float offset;

	// Token: 0x0400099D RID: 2461
	[Token(Token = "0x400099D")]
	[FieldOffset(Offset = "0x20")]
	public float density;

	// Token: 0x0400099E RID: 2462
	[Token(Token = "0x400099E")]
	[FieldOffset(Offset = "0x24")]
	public float slopeInfluence;

	// Token: 0x0400099F RID: 2463
	[Token(Token = "0x400099F")]
	[FieldOffset(Offset = "0x28")]
	public float randomRotation;

	// Token: 0x040009A0 RID: 2464
	[Token(Token = "0x40009A0")]
	[FieldOffset(Offset = "0x2C")]
	public bool slopeCorrection;

	// Token: 0x040009A1 RID: 2465
	[Token(Token = "0x40009A1")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 randomScaleRange;

	// Token: 0x040009A2 RID: 2466
	[Token(Token = "0x40009A2")]
	[FieldOffset(Offset = "0x38")]
	private float delay;

	// Token: 0x040009A3 RID: 2467
	[Token(Token = "0x40009A3")]
	[FieldOffset(Offset = "0x3C")]
	private float nextFeasibleStrokeTime;

	// Token: 0x040009A4 RID: 2468
	[Token(Token = "0x40009A4")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public List<GameObject> meshes;

	// Token: 0x040009A5 RID: 2469
	[Token(Token = "0x40009A5")]
	[FieldOffset(Offset = "0x48")]
	protected List<Transform> paintedMeshes;

	// Token: 0x040009A6 RID: 2470
	[Token(Token = "0x40009A6")]
	[FieldOffset(Offset = "0x50")]
	protected List<Transform> paintedMeshesInsideBrushArea;
}
