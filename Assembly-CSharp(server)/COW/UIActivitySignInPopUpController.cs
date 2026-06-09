using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020014EB RID: 5355
	[Token(Token = "0x20014EB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDC44", Offset = "0x10EDC44")]
	public class UIActivitySignInPopUpController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06005B98 RID: 23448 RVA: 0x0001ABE0 File Offset: 0x00018DE0
		[Token(Token = "0x6005B98")]
		[Address(RVA = "0x195CDA0", Offset = "0x195CDA0", VA = "0x7BBC15CDA0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005B99 RID: 23449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B99")]
		[Address(RVA = "0x195CDF0", Offset = "0x195CDF0", VA = "0x7BBC15CDF0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005B9A RID: 23450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9A")]
		[Address(RVA = "0x195D348", Offset = "0x195D348", VA = "0x7BBC15D348", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06005B9B RID: 23451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9B")]
		[Address(RVA = "0x195D418", Offset = "0x195D418", VA = "0x7BBC15D418", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005B9C RID: 23452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9C")]
		[Address(RVA = "0x195D4CC", Offset = "0x195D4CC", VA = "0x7BBC15D4CC")]
		private void ClearItem()
		{
		}

		// Token: 0x06005B9D RID: 23453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9D")]
		[Address(RVA = "0x195D618", Offset = "0x195D618", VA = "0x7BBC15D618")]
		private void RefreshList()
		{
		}

		// Token: 0x06005B9E RID: 23454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9E")]
		[Address(RVA = "0x195D8EC", Offset = "0x195D8EC", VA = "0x7BBC15D8EC")]
		private void RepositionItem()
		{
		}

		// Token: 0x06005B9F RID: 23455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9F")]
		[Address(RVA = "0x195DAB4", Offset = "0x195DAB4", VA = "0x7BBC15DAB4")]
		private void ScrollToLastSignedLine()
		{
		}

		// Token: 0x06005BA0 RID: 23456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA0")]
		[Address(RVA = "0x195DDFC", Offset = "0x195DDFC", VA = "0x7BBC15DDFC")]
		private void RefreshSignDesc()
		{
		}

		// Token: 0x06005BA1 RID: 23457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA1")]
		[Address(RVA = "0x195E0E8", Offset = "0x195E0E8", VA = "0x7BBC15E0E8", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005BA2 RID: 23458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA2")]
		[Address(RVA = "0x195E160", Offset = "0x195E160", VA = "0x7BBC15E160")]
		private void AutoSignIn()
		{
		}

		// Token: 0x06005BA3 RID: 23459 RVA: 0x0001ABF8 File Offset: 0x00018DF8
		[Token(Token = "0x6005BA3")]
		[Address(RVA = "0x195E3A8", Offset = "0x195E3A8", VA = "0x7BBC15E3A8", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005BA4 RID: 23460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA4")]
		[Address(RVA = "0x195E3EC", Offset = "0x195E3EC", VA = "0x7BBC15E3EC")]
		public UIActivitySignInPopUpController()
		{
		}

		// Token: 0x04007E17 RID: 32279
		[Token(Token = "0x4007E17")]
		[FieldOffset(Offset = "0x98")]
		private UIActivitySignInPopUpView m_View;

		// Token: 0x04007E18 RID: 32280
		[Token(Token = "0x4007E18")]
		private const int MaxItemPerLine = 6;

		// Token: 0x04007E19 RID: 32281
		[Token(Token = "0x4007E19")]
		[FieldOffset(Offset = "0xA0")]
		private List<UIAnnouncementRewardItemController> m_ItemList;

		// Token: 0x04007E1A RID: 32282
		[Token(Token = "0x4007E1A")]
		[FieldOffset(Offset = "0xA8")]
		private int m_lastSignedIndex;

		// Token: 0x04007E1B RID: 32283
		[Token(Token = "0x4007E1B")]
		[FieldOffset(Offset = "0xB0")]
		private Transform[] m_ItemContainerList;
	}
}
