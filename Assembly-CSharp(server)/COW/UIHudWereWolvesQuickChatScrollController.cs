using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200199A RID: 6554
	[Token(Token = "0x200199A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6ADC", Offset = "0x10F6ADC")]
	public class UIHudWereWolvesQuickChatScrollController : UIBaseController, IEasyList
	{
		// Token: 0x06008603 RID: 34307 RVA: 0x00024510 File Offset: 0x00022710
		[Token(Token = "0x6008603")]
		[Address(RVA = "0x1D1441C", Offset = "0x1D1441C", VA = "0x7BBC51441C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008604 RID: 34308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008604")]
		[Address(RVA = "0x1D1446C", Offset = "0x1D1446C", VA = "0x7BBC51446C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008605 RID: 34309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008605")]
		[Address(RVA = "0x1D14600", Offset = "0x1D14600", VA = "0x7BBC514600", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008606 RID: 34310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008606")]
		[Address(RVA = "0x1D146CC", Offset = "0x1D146CC", VA = "0x7BBC5146CC", Slot = "28")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06008607 RID: 34311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008607")]
		[Address(RVA = "0x1D14788", Offset = "0x1D14788", VA = "0x7BBC514788", Slot = "29")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06008608 RID: 34312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008608")]
		[Address(RVA = "0x1D147B8", Offset = "0x1D147B8", VA = "0x7BBC5147B8")]
		public void SetData(uint playerId)
		{
		}

		// Token: 0x06008609 RID: 34313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008609")]
		[Address(RVA = "0x1D148FC", Offset = "0x1D148FC", VA = "0x7BBC5148FC")]
		private void OnSendWereWolvesQuickChat(params object[] data)
		{
		}

		// Token: 0x0600860A RID: 34314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600860A")]
		[Address(RVA = "0x1D14C74", Offset = "0x1D14C74", VA = "0x7BBC514C74")]
		private void OnBgClick()
		{
		}

		// Token: 0x0600860B RID: 34315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600860B")]
		[Address(RVA = "0x1D14C84", Offset = "0x1D14C84", VA = "0x7BBC514C84")]
		public UIHudWereWolvesQuickChatScrollController()
		{
		}

		// Token: 0x04009565 RID: 38245
		[Token(Token = "0x4009565")]
		[FieldOffset(Offset = "0x58")]
		private uint m_Select;

		// Token: 0x04009566 RID: 38246
		[Token(Token = "0x4009566")]
		[FieldOffset(Offset = "0x60")]
		private UIHudWereWolvesQuickChatScrollView m_View;
	}
}
