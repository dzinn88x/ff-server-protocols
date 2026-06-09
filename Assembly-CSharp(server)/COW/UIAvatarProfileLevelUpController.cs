using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020016C3 RID: 5827
	[Token(Token = "0x20016C3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0B9C", Offset = "0x10F0B9C")]
	public class UIAvatarProfileLevelUpController : UIPopupWindowController
	{
		// Token: 0x06006ACC RID: 27340 RVA: 0x0001E438 File Offset: 0x0001C638
		[Token(Token = "0x6006ACC")]
		[Address(RVA = "0x208D3CC", Offset = "0x208D3CC", VA = "0x7BBC88D3CC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006ACD RID: 27341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ACD")]
		[Address(RVA = "0x208D41C", Offset = "0x208D41C", VA = "0x7BBC88D41C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006ACE RID: 27342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ACE")]
		[Address(RVA = "0x208D63C", Offset = "0x208D63C", VA = "0x7BBC88D63C")]
		private void OnConfirmClick()
		{
		}

		// Token: 0x06006ACF RID: 27343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ACF")]
		[Address(RVA = "0x208A3BC", Offset = "0x208A3BC", VA = "0x7BBC88A3BC")]
		public void SetLevelUpResult(uint avatarId, int oldProfileLv, int nowProfileLv, List<Item> rewards, [Optional] Action callback)
		{
		}

		// Token: 0x06006AD0 RID: 27344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD0")]
		[Address(RVA = "0x208D7D8", Offset = "0x208D7D8", VA = "0x7BBC88D7D8")]
		public UIAvatarProfileLevelUpController()
		{
		}

		// Token: 0x04008708 RID: 34568
		[Token(Token = "0x4008708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UIAvatarProfileLevelUpView m_View;

		// Token: 0x04008709 RID: 34569
		[Token(Token = "0x4008709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private UIModelAvatarProfile m_Model;

		// Token: 0x0400870A RID: 34570
		[Token(Token = "0x400870A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BaseItemView[] mLevelUpRewardLst;

		// Token: 0x0400870B RID: 34571
		[Token(Token = "0x400870B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int mOldProfileLv;

		// Token: 0x0400870C RID: 34572
		[Token(Token = "0x400870C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private int mNowProfileLv;
	}
}
