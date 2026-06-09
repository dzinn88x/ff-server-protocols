using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A7E RID: 6782
	[Token(Token = "0x2001A7E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F84EC", Offset = "0x10F84EC")]
	public class UIMysteryBonusSipnWndController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06008EDF RID: 36575 RVA: 0x00026178 File Offset: 0x00024378
		[Token(Token = "0x6008EDF")]
		[Address(RVA = "0x14CD3C0", Offset = "0x14CD3C0", VA = "0x7BBBCCD3C0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008EE0 RID: 36576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EE0")]
		[Address(RVA = "0x14CD410", Offset = "0x14CD410", VA = "0x7BBBCCD410", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008EE1 RID: 36577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EE1")]
		[Address(RVA = "0x14CD668", Offset = "0x14CD668", VA = "0x7BBBCCD668", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008EE2 RID: 36578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EE2")]
		[Address(RVA = "0x14CD6A8", Offset = "0x14CD6A8", VA = "0x7BBBCCD6A8")]
		private void OnStopBtnClick()
		{
		}

		// Token: 0x06008EE3 RID: 36579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EE3")]
		[Address(RVA = "0x14CD6D8", Offset = "0x14CD6D8", VA = "0x7BBBCCD6D8")]
		private void OnConfirmBtnClick()
		{
		}

		// Token: 0x06008EE4 RID: 36580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EE4")]
		[Address(RVA = "0x14CD7A8", Offset = "0x14CD7A8", VA = "0x7BBBCCD7A8")]
		private void RefreshView()
		{
		}

		// Token: 0x06008EE5 RID: 36581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EE5")]
		[Address(RVA = "0x14CDA84", Offset = "0x14CDA84", VA = "0x7BBBCCDA84", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008EE6 RID: 36582 RVA: 0x00026190 File Offset: 0x00024390
		[Token(Token = "0x6008EE6")]
		[Address(RVA = "0x14CDAFC", Offset = "0x14CDAFC", VA = "0x7BBBCCDAFC", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008EE7 RID: 36583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EE7")]
		[Address(RVA = "0x14CDB40", Offset = "0x14CDB40", VA = "0x7BBBCCDB40")]
		public UIMysteryBonusSipnWndController()
		{
		}

		// Token: 0x04009A6C RID: 39532
		[Token(Token = "0x4009A6C")]
		[FieldOffset(Offset = "0x98")]
		private UIMysteryBonusSpinWndView m_View;

		// Token: 0x04009A6D RID: 39533
		[Token(Token = "0x4009A6D")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelPayment m_ModelPayment;
	}
}
