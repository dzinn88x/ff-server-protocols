using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C2B RID: 7211
	[Token(Token = "0x2001C2B")]
	public class EdgeDetectHudItem : CustomHudItem
	{
		// Token: 0x06009CED RID: 40173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CED")]
		[Address(RVA = "0x1616D68", Offset = "0x1616D68", VA = "0x7BBBE16D68")]
		protected new void Awake()
		{
		}

		// Token: 0x06009CEE RID: 40174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CEE")]
		[Address(RVA = "0x1616FB0", Offset = "0x1616FB0", VA = "0x7BBBE16FB0", Slot = "7")]
		protected new virtual void OnHudDragEnd(GameObject go)
		{
		}

		// Token: 0x06009CEF RID: 40175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CEF")]
		[Address(RVA = "0x161710C", Offset = "0x161710C", VA = "0x7BBBE1710C")]
		public void EdgeDetect()
		{
		}

		// Token: 0x06009CF0 RID: 40176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CF0")]
		[Address(RVA = "0x1617344", Offset = "0x1617344", VA = "0x7BBBE17344")]
		public EdgeDetectHudItem()
		{
		}

		// Token: 0x0400A2ED RID: 41709
		[Token(Token = "0x400A2ED")]
		[FieldOffset(Offset = "0x48")]
		protected UIWidget m_Wiget;

		// Token: 0x0400A2EE RID: 41710
		[Token(Token = "0x400A2EE")]
		[FieldOffset(Offset = "0x50")]
		protected int m_ScreenWidth;

		// Token: 0x0400A2EF RID: 41711
		[Token(Token = "0x400A2EF")]
		[FieldOffset(Offset = "0x54")]
		protected int m_ScreenHeight;
	}
}
