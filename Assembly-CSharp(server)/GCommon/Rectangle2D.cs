using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F12 RID: 3858
	[Token(Token = "0x2000F12")]
	public class Rectangle2D : IShape2D
	{
		// Token: 0x0600368C RID: 13964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600368C")]
		[Address(RVA = "0x247BA50", Offset = "0x247BA50", VA = "0x7BBCC7BA50")]
		public Rectangle2D(Vector3 pos, float length, float width)
		{
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600368D")]
		[Address(RVA = "0x247BAB0", Offset = "0x247BAB0", VA = "0x7BBCC7BAB0")]
		public Rectangle2D(Vector3 leftBottom, Vector3 rightTop)
		{
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x00010B30 File Offset: 0x0000ED30
		[Token(Token = "0x600368E")]
		[Address(RVA = "0x247BBE0", Offset = "0x247BBE0", VA = "0x7BBCC7BBE0", Slot = "4")]
		public Vector3 GetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600368F")]
		[Address(RVA = "0x247BBEC", Offset = "0x247BBEC", VA = "0x7BBCC7BBEC")]
		public void SetPosition(Vector3 v)
		{
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003690")]
		[Address(RVA = "0x247BBF8", Offset = "0x247BBF8", VA = "0x7BBCC7BBF8")]
		public void UpdateSize(float length, float width)
		{
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x00010B48 File Offset: 0x0000ED48
		[Token(Token = "0x6003691")]
		[Address(RVA = "0x247BC0C", Offset = "0x247BC0C", VA = "0x7BBCC7BC0C", Slot = "6")]
		public Vector3 GetSize()
		{
			return default(Vector3);
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x00010B60 File Offset: 0x0000ED60
		[Token(Token = "0x6003692")]
		[Address(RVA = "0x247BC50", Offset = "0x247BC50", VA = "0x7BBCC7BC50", Slot = "5")]
		public Vector3 GetCenter()
		{
			return default(Vector3);
		}

		// Token: 0x06003693 RID: 13971 RVA: 0x00010B78 File Offset: 0x0000ED78
		[Token(Token = "0x6003693")]
		[Address(RVA = "0x247BC5C", Offset = "0x247BC5C", VA = "0x7BBCC7BC5C", Slot = "7")]
		public bool IsPointInside(Vector3 v, float margin = 0f)
		{
			return default(bool);
		}

		// Token: 0x06003694 RID: 13972 RVA: 0x00010B90 File Offset: 0x0000ED90
		[Token(Token = "0x6003694")]
		[Address(RVA = "0x247BCB8", Offset = "0x247BCB8", VA = "0x7BBCC7BCB8", Slot = "8")]
		public Vector3 GetRandomPoint(float margin = 0f)
		{
			return default(Vector3);
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x00010BA8 File Offset: 0x0000EDA8
		[Token(Token = "0x6003695")]
		[Address(RVA = "0x247BD54", Offset = "0x247BD54", VA = "0x7BBCC7BD54", Slot = "9")]
		public Vector3 ClampPoint(Vector3 v, float margin = 0f)
		{
			return default(Vector3);
		}

		// Token: 0x040049B2 RID: 18866
		[Token(Token = "0x40049B2")]
		[FieldOffset(Offset = "0x10")]
		private Vector3 m_Position;

		// Token: 0x040049B3 RID: 18867
		[Token(Token = "0x40049B3")]
		[FieldOffset(Offset = "0x1C")]
		private float m_HalfLength;

		// Token: 0x040049B4 RID: 18868
		[Token(Token = "0x40049B4")]
		[FieldOffset(Offset = "0x20")]
		private float m_HalfWidth;
	}
}
