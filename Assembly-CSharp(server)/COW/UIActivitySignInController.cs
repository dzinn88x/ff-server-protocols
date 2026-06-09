using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001407 RID: 5127
	[Token(Token = "0x2001407")]
	public class UIActivitySignInController : UIActivityBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06005469 RID: 21609 RVA: 0x00019308 File Offset: 0x00017508
		[Token(Token = "0x6005469")]
		[Address(RVA = "0x195B758", Offset = "0x195B758", VA = "0x7BBC15B758")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600546A RID: 21610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600546A")]
		[Address(RVA = "0x195B7A8", Offset = "0x195B7A8", VA = "0x7BBC15B7A8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600546B RID: 21611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600546B")]
		[Address(RVA = "0x195BC84", Offset = "0x195BC84", VA = "0x7BBC15BC84", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x0600546C RID: 21612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600546C")]
		[Address(RVA = "0x195BD54", Offset = "0x195BD54", VA = "0x7BBC15BD54", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600546D RID: 21613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600546D")]
		[Address(RVA = "0x195BE08", Offset = "0x195BE08", VA = "0x7BBC15BE08")]
		private void ClearItem()
		{
		}

		// Token: 0x0600546E RID: 21614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600546E")]
		[Address(RVA = "0x195BF54", Offset = "0x195BF54", VA = "0x7BBC15BF54")]
		private void RefreshList()
		{
		}

		// Token: 0x0600546F RID: 21615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600546F")]
		[Address(RVA = "0x195C228", Offset = "0x195C228", VA = "0x7BBC15C228")]
		private void RepositionItem()
		{
		}

		// Token: 0x06005470 RID: 21616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005470")]
		[Address(RVA = "0x195C3F0", Offset = "0x195C3F0", VA = "0x7BBC15C3F0")]
		private void ScrollToLastSignedLine()
		{
		}

		// Token: 0x06005471 RID: 21617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005471")]
		[Address(RVA = "0x195C738", Offset = "0x195C738", VA = "0x7BBC15C738")]
		private void RefreshSignDesc()
		{
		}

		// Token: 0x06005472 RID: 21618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005472")]
		[Address(RVA = "0x195CA24", Offset = "0x195CA24", VA = "0x7BBC15CA24", Slot = "32")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005473 RID: 21619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005473")]
		[Address(RVA = "0x195CA9C", Offset = "0x195CA9C", VA = "0x7BBC15CA9C")]
		private void AutoSignIn()
		{
		}

		// Token: 0x06005474 RID: 21620 RVA: 0x00019320 File Offset: 0x00017520
		[Token(Token = "0x6005474")]
		[Address(RVA = "0x195CCE4", Offset = "0x195CCE4", VA = "0x7BBC15CCE4", Slot = "33")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005475 RID: 21621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005475")]
		[Address(RVA = "0x195CD28", Offset = "0x195CD28", VA = "0x7BBC15CD28")]
		public UIActivitySignInController()
		{
		}

		// Token: 0x040079CF RID: 31183
		[Token(Token = "0x40079CF")]
		[FieldOffset(Offset = "0x58")]
		private UIActivitySignInView m_View;

		// Token: 0x040079D0 RID: 31184
		[Token(Token = "0x40079D0")]
		private const int MaxItemPerLine = 6;

		// Token: 0x040079D1 RID: 31185
		[Token(Token = "0x40079D1")]
		[FieldOffset(Offset = "0x60")]
		private List<UIAnnouncementRewardItemController> m_ItemList;

		// Token: 0x040079D2 RID: 31186
		[Token(Token = "0x40079D2")]
		[FieldOffset(Offset = "0x68")]
		private int m_lastSignedIndex;

		// Token: 0x040079D3 RID: 31187
		[Token(Token = "0x40079D3")]
		[FieldOffset(Offset = "0x70")]
		private Transform[] m_ItemContainerList;
	}
}
