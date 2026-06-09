using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000233 RID: 563
[Token(Token = "0x2000233")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0x10E26B0", Offset = "0x10E26B0")]
public class UICustomMeshCollider : MonoBehaviour
{
	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x06000B44 RID: 2884 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B45 RID: 2885 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000C3")]
	public Mesh MMesh
	{
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x1C9EBC4", Offset = "0x1C9EBC4", VA = "0x7BBC49EBC4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x1C9EBCC", Offset = "0x1C9EBCC", VA = "0x7BBC49EBCC")]
		set
		{
		}
	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B46")]
	[Address(RVA = "0x1C9EBD4", Offset = "0x1C9EBD4", VA = "0x7BBC49EBD4")]
	private void Start()
	{
	}

	// Token: 0x06000B47 RID: 2887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B47")]
	[Address(RVA = "0x1C9EC7C", Offset = "0x1C9EC7C", VA = "0x7BBC49EC7C")]
	public UICustomMeshCollider()
	{
	}

	// Token: 0x04000A35 RID: 2613
	[Token(Token = "0x4000A35")]
	[FieldOffset(Offset = "0x18")]
	public string MeshName;

	// Token: 0x04000A36 RID: 2614
	[Token(Token = "0x4000A36")]
	[FieldOffset(Offset = "0x20")]
	public Mesh MeshRef;

	// Token: 0x04000A37 RID: 2615
	[Token(Token = "0x4000A37")]
	[FieldOffset(Offset = "0x28")]
	public bool SectorShape;

	// Token: 0x04000A38 RID: 2616
	[Token(Token = "0x4000A38")]
	[FieldOffset(Offset = "0x2C")]
	public float Radius;

	// Token: 0x04000A39 RID: 2617
	[Token(Token = "0x4000A39")]
	[FieldOffset(Offset = "0x30")]
	public float InnerRadius;

	// Token: 0x04000A3A RID: 2618
	[Token(Token = "0x4000A3A")]
	[FieldOffset(Offset = "0x34")]
	public float AngleDegree;

	// Token: 0x04000A3B RID: 2619
	[Token(Token = "0x4000A3B")]
	[FieldOffset(Offset = "0x38")]
	public uint Segments;

	// Token: 0x04000A3C RID: 2620
	[Token(Token = "0x4000A3C")]
	[FieldOffset(Offset = "0x3C")]
	public float AngleStart;

	// Token: 0x04000A3D RID: 2621
	[Token(Token = "0x4000A3D")]
	[FieldOffset(Offset = "0x40")]
	public float OffsetX;

	// Token: 0x04000A3E RID: 2622
	[Token(Token = "0x4000A3E")]
	[FieldOffset(Offset = "0x44")]
	public float OffsetY;

	// Token: 0x04000A3F RID: 2623
	[Token(Token = "0x4000A3F")]
	[FieldOffset(Offset = "0x48")]
	public uint Size;

	// Token: 0x04000A40 RID: 2624
	[Token(Token = "0x4000A40")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public Pos[] Vertices;

	// Token: 0x04000A41 RID: 2625
	[Token(Token = "0x4000A41")]
	[FieldOffset(Offset = "0x58")]
	private MeshCollider m_Collider;

	// Token: 0x04000A42 RID: 2626
	[Token(Token = "0x4000A42")]
	[FieldOffset(Offset = "0x60")]
	private Mesh m_Mesh;

	// Token: 0x04000A43 RID: 2627
	[Token(Token = "0x4000A43")]
	[FieldOffset(Offset = "0x68")]
	private uint m_OldSize;

	// Token: 0x04000A44 RID: 2628
	[Token(Token = "0x4000A44")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_NewSize;
}
