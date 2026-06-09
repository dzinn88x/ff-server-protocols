using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EF5 RID: 3829
	[Token(Token = "0x2000EF5")]
	public class GridValueBase
	{
		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060035A8 RID: 13736 RVA: 0x00010320 File Offset: 0x0000E520
		[Token(Token = "0x170006B6")]
		public Vector3 GridCoordinate
		{
			[Token(Token = "0x60035A8")]
			[Address(RVA = "0x211D1E0", Offset = "0x211D1E0", VA = "0x7BBC91D1E0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A9")]
		[Address(RVA = "0x211D1EC", Offset = "0x211D1EC", VA = "0x7BBC91D1EC", Slot = "4")]
		public virtual void InitGridValue(Vector3 coordinate)
		{
		}

		// Token: 0x060035AA RID: 13738 RVA: 0x00010338 File Offset: 0x0000E538
		[Token(Token = "0x60035AA")]
		[Address(RVA = "0x211D1F8", Offset = "0x211D1F8", VA = "0x7BBC91D1F8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060035AB RID: 13739 RVA: 0x00010350 File Offset: 0x0000E550
		[Token(Token = "0x60035AB")]
		[Address(RVA = "0x211D328", Offset = "0x211D328", VA = "0x7BBC91D328", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060035AC RID: 13740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035AC")]
		[Address(RVA = "0x211D330", Offset = "0x211D330", VA = "0x7BBC91D330")]
		public GridValueBase()
		{
		}

		// Token: 0x040048CB RID: 18635
		[Token(Token = "0x40048CB")]
		[FieldOffset(Offset = "0x10")]
		protected Vector3 m_GridCoordinate;
	}
}
