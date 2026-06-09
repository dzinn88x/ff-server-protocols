using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F0F RID: 3855
	[Token(Token = "0x2000F0F")]
	public class Circle2D : IShape2D
	{
		// Token: 0x06003662 RID: 13922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003662")]
		[Address(RVA = "0x25EBE5C", Offset = "0x25EBE5C", VA = "0x7BBCDEBE5C")]
		public Circle2D(Vector3 pos, float radius)
		{
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x00010848 File Offset: 0x0000EA48
		[Token(Token = "0x6003663")]
		[Address(RVA = "0x25EBEA8", Offset = "0x25EBEA8", VA = "0x7BBCDEBEA8", Slot = "4")]
		public Vector3 GetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x00010860 File Offset: 0x0000EA60
		[Token(Token = "0x6003664")]
		[Address(RVA = "0x25EBEB4", Offset = "0x25EBEB4", VA = "0x7BBCDEBEB4", Slot = "6")]
		public Vector3 GetSize()
		{
			return default(Vector3);
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x00010878 File Offset: 0x0000EA78
		[Token(Token = "0x6003665")]
		[Address(RVA = "0x25EBEF8", Offset = "0x25EBEF8", VA = "0x7BBCDEBEF8", Slot = "5")]
		public Vector3 GetCenter()
		{
			return default(Vector3);
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003666")]
		[Address(RVA = "0x25EBF04", Offset = "0x25EBF04", VA = "0x7BBCDEBF04")]
		public void SetPosition(Vector3 pos)
		{
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x00010890 File Offset: 0x0000EA90
		[Token(Token = "0x6003667")]
		[Address(RVA = "0x25EBF10", Offset = "0x25EBF10", VA = "0x7BBCDEBF10")]
		public float GetRadius()
		{
			return 0f;
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003668")]
		[Address(RVA = "0x25EBF18", Offset = "0x25EBF18", VA = "0x7BBCDEBF18")]
		public void SetRadius(float radius)
		{
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x000108A8 File Offset: 0x0000EAA8
		[Token(Token = "0x6003669")]
		[Address(RVA = "0x25EBF20", Offset = "0x25EBF20", VA = "0x7BBCDEBF20", Slot = "7")]
		public bool IsPointInside(Vector3 v, float margin = 0f)
		{
			return default(bool);
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x000108C0 File Offset: 0x0000EAC0
		[Token(Token = "0x600366A")]
		[Address(RVA = "0x25EBFDC", Offset = "0x25EBFDC", VA = "0x7BBCDEBFDC", Slot = "8")]
		public Vector3 GetRandomPoint(float margin = 0f)
		{
			return default(Vector3);
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x000108D8 File Offset: 0x0000EAD8
		[Token(Token = "0x600366B")]
		[Address(RVA = "0x25EC0DC", Offset = "0x25EC0DC", VA = "0x7BBCDEC0DC", Slot = "9")]
		public Vector3 ClampPoint(Vector3 v, float margin = 0f)
		{
			return default(Vector3);
		}

		// Token: 0x04004999 RID: 18841
		[Token(Token = "0x4004999")]
		[FieldOffset(Offset = "0x10")]
		private Vector3 m_Position;

		// Token: 0x0400499A RID: 18842
		[Token(Token = "0x400499A")]
		[FieldOffset(Offset = "0x1C")]
		private float m_Radius;
	}
}
