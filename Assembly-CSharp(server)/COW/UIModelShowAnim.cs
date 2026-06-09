using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001FEF RID: 8175
	[Token(Token = "0x2001FEF")]
	internal class UIModelShowAnim : UIBaseModel
	{
		// Token: 0x0600B5F1 RID: 46577 RVA: 0x00033D08 File Offset: 0x00031F08
		[Token(Token = "0x600B5F1")]
		[Address(RVA = "0x22F831C", Offset = "0x22F831C", VA = "0x7BBCAF831C", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B5F2 RID: 46578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5F2")]
		[Address(RVA = "0x22F8324", Offset = "0x22F8324", VA = "0x7BBCAF8324", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B5F3 RID: 46579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5F3")]
		[Address(RVA = "0x22F839C", Offset = "0x22F839C", VA = "0x7BBCAF839C")]
		public void SetAnimData(CSGetFullscreenCgRes res)
		{
		}

		// Token: 0x0600B5F4 RID: 46580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5F4")]
		[Address(RVA = "0x22F83B0", Offset = "0x22F83B0", VA = "0x7BBCAF83B0")]
		public void SetItemAnimData(CSGetFullscreenItemRes res)
		{
		}

		// Token: 0x0600B5F5 RID: 46581 RVA: 0x00033D20 File Offset: 0x00031F20
		[Token(Token = "0x600B5F5")]
		[Address(RVA = "0x22F83C4", Offset = "0x22F83C4", VA = "0x7BBCAF83C4")]
		public int CheckFullScreenItem(uint itemid)
		{
			return 0;
		}

		// Token: 0x0600B5F6 RID: 46582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B5F6")]
		[Address(RVA = "0x22F851C", Offset = "0x22F851C", VA = "0x7BBCAF851C")]
		public List<FullscreenCgDesc> FullScreenAnimByNavType(UINavigationUtil.UINavigationPageType type)
		{
			return null;
		}

		// Token: 0x0600B5F7 RID: 46583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5F7")]
		[Address(RVA = "0x22F8654", Offset = "0x22F8654", VA = "0x7BBCAF8654")]
		public UIModelShowAnim()
		{
		}

		// Token: 0x0400B7F5 RID: 47093
		[Token(Token = "0x400B7F5")]
		[FieldOffset(Offset = "0x18")]
		private List<FullscreenCgDesc> fullscreen_cgs;

		// Token: 0x0400B7F6 RID: 47094
		[Token(Token = "0x400B7F6")]
		[FieldOffset(Offset = "0x20")]
		private List<FullscreenItemDesc> fullscreen_items;
	}
}
