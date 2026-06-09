using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F01 RID: 3841
	[Token(Token = "0x2000F01")]
	public class UserButtonArea
	{
		// Token: 0x060035F0 RID: 13808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035F0")]
		[Address(RVA = "0x22443B0", Offset = "0x22443B0", VA = "0x7BBCA443B0")]
		public UserButtonArea(int key, Vector2 pos, Vector2 size, EInputButtonType buttonType, bool isEnable = true)
		{
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035F1")]
		[Address(RVA = "0x2244420", Offset = "0x2244420", VA = "0x7BBCA44420")]
		public void Update(Vector2 pos, Vector2 size, EInputButtonType buttonType, bool isEnable)
		{
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x00010560 File Offset: 0x0000E760
		[Token(Token = "0x60035F2")]
		[Address(RVA = "0x2244438", Offset = "0x2244438", VA = "0x7BBCA44438")]
		public bool InButtonRange(Vector2 point)
		{
			return default(bool);
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035F3")]
		[Address(RVA = "0x224457C", Offset = "0x224457C", VA = "0x7BBCA4457C")]
		public void Enable(bool v)
		{
		}

		// Token: 0x060035F4 RID: 13812 RVA: 0x00010578 File Offset: 0x0000E778
		[Token(Token = "0x60035F4")]
		[Address(RVA = "0x2244588", Offset = "0x2244588", VA = "0x7BBCA44588")]
		public bool IsEnable()
		{
			return default(bool);
		}

		// Token: 0x0400493F RID: 18751
		[Token(Token = "0x400493F")]
		[FieldOffset(Offset = "0x10")]
		private Vector2 m_Position;

		// Token: 0x04004940 RID: 18752
		[Token(Token = "0x4004940")]
		[FieldOffset(Offset = "0x18")]
		private Vector2 m_Size;

		// Token: 0x04004941 RID: 18753
		[Token(Token = "0x4004941")]
		[FieldOffset(Offset = "0x20")]
		private EInputButtonType m_ButtonType;

		// Token: 0x04004942 RID: 18754
		[Token(Token = "0x4004942")]
		[FieldOffset(Offset = "0x24")]
		private bool m_Enable;
	}
}
