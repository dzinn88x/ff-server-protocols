using System;
using System.Collections.Generic;
using GCommon.Utillities;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.Trails
{
	// Token: 0x0200107E RID: 4222
	[Token(Token = "0x200107E")]
	public class PCTrail : IDisposable
	{
		// Token: 0x060040B0 RID: 16560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B0")]
		[Address(RVA = "0x249A344", Offset = "0x249A344", VA = "0x7BBCC9A344")]
		public PCTrail(int numPoints)
		{
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B1")]
		[Address(RVA = "0x249A538", Offset = "0x249A538", VA = "0x7BBCC9A538", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0400502C RID: 20524
		[Token(Token = "0x400502C")]
		[FieldOffset(Offset = "0x10")]
		public CircularBuffer<PCTrailPoint> Points;

		// Token: 0x0400502D RID: 20525
		[Token(Token = "0x400502D")]
		[FieldOffset(Offset = "0x18")]
		public Mesh Mesh;

		// Token: 0x0400502E RID: 20526
		[Token(Token = "0x400502E")]
		[FieldOffset(Offset = "0x20")]
		public List<Vector3> verticies;

		// Token: 0x0400502F RID: 20527
		[Token(Token = "0x400502F")]
		[FieldOffset(Offset = "0x28")]
		public List<Vector3> normals;

		// Token: 0x04005030 RID: 20528
		[Token(Token = "0x4005030")]
		[FieldOffset(Offset = "0x30")]
		public List<Vector2> uvs;

		// Token: 0x04005031 RID: 20529
		[Token(Token = "0x4005031")]
		[FieldOffset(Offset = "0x38")]
		public List<Color> colors;

		// Token: 0x04005032 RID: 20530
		[Token(Token = "0x4005032")]
		[FieldOffset(Offset = "0x40")]
		public int[] indicies;

		// Token: 0x04005033 RID: 20531
		[Token(Token = "0x4005033")]
		[FieldOffset(Offset = "0x48")]
		public int activePointCount;

		// Token: 0x04005034 RID: 20532
		[Token(Token = "0x4005034")]
		[FieldOffset(Offset = "0x4C")]
		public bool IsActiveTrail;
	}
}
