using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001388 RID: 5000
	[Token(Token = "0x2001388")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB788", Offset = "0x10EB788")]
	public class UIGoliathPeakDayWndController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06005089 RID: 20617 RVA: 0x00018708 File Offset: 0x00016908
		[Token(Token = "0x6005089")]
		[Address(RVA = "0x1A80258", Offset = "0x1A80258", VA = "0x7BBC280258")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600508A RID: 20618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600508A")]
		[Address(RVA = "0x1A802A8", Offset = "0x1A802A8", VA = "0x7BBC2802A8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600508B RID: 20619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600508B")]
		[Address(RVA = "0x1A80A64", Offset = "0x1A80A64", VA = "0x7BBC280A64", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600508C RID: 20620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600508C")]
		[Address(RVA = "0x1A80B10", Offset = "0x1A80B10", VA = "0x7BBC280B10", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600508D RID: 20621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600508D")]
		[Address(RVA = "0x1A804B8", Offset = "0x1A804B8", VA = "0x7BBC2804B8")]
		private void SetViewData()
		{
		}

		// Token: 0x0600508E RID: 20622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600508E")]
		[Address(RVA = "0x1A80B50", Offset = "0x1A80B50", VA = "0x7BBC280B50")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x0600508F RID: 20623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600508F")]
		[Address(RVA = "0x1A80B58", Offset = "0x1A80B58", VA = "0x7BBC280B58")]
		private void OnBtnClaimClick()
		{
		}

		// Token: 0x06005090 RID: 20624 RVA: 0x00018720 File Offset: 0x00016920
		[Token(Token = "0x6005090")]
		[Address(RVA = "0x1A80C34", Offset = "0x1A80C34", VA = "0x7BBC280C34", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005091 RID: 20625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005091")]
		[Address(RVA = "0x1A80C78", Offset = "0x1A80C78", VA = "0x7BBC280C78", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005092 RID: 20626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005092")]
		[Address(RVA = "0x1A80D04", Offset = "0x1A80D04", VA = "0x7BBC280D04")]
		public UIGoliathPeakDayWndController()
		{
		}

		// Token: 0x04007703 RID: 30467
		[Token(Token = "0x4007703")]
		[FieldOffset(Offset = "0x98")]
		private UIGoliathPeakDayWndView m_View;

		// Token: 0x04007704 RID: 30468
		[Token(Token = "0x4007704")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x04007705 RID: 30469
		[Token(Token = "0x4007705")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x04007706 RID: 30470
		[Token(Token = "0x4007706")]
		[FieldOffset(Offset = "0xB0")]
		private UIStandardItemMiniController m_AwardCtrl;

		// Token: 0x04007707 RID: 30471
		[Token(Token = "0x4007707")]
		[FieldOffset(Offset = "0xB8")]
		private ClientActivityDesc m_Desc;
	}
}
