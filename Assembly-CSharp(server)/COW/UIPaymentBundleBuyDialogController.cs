using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001AB1 RID: 6833
	[Token(Token = "0x2001AB1")]
	public class UIPaymentBundleBuyDialogController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x0600902F RID: 36911 RVA: 0x000266A0 File Offset: 0x000248A0
		[Token(Token = "0x600902F")]
		[Address(RVA = "0x16F016C", Offset = "0x16F016C", VA = "0x7BBBEF016C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009030 RID: 36912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009030")]
		[Address(RVA = "0x16F01BC", Offset = "0x16F01BC", VA = "0x7BBBEF01BC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009031 RID: 36913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009031")]
		[Address(RVA = "0x16F038C", Offset = "0x16F038C", VA = "0x7BBBEF038C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009032 RID: 36914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009032")]
		[Address(RVA = "0x16F04C4", Offset = "0x16F04C4", VA = "0x7BBBEF04C4")]
		public void SetViewData(uint bundleId, string title)
		{
		}

		// Token: 0x06009033 RID: 36915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009033")]
		[Address(RVA = "0x16F09A8", Offset = "0x16F09A8", VA = "0x7BBBEF09A8")]
		private void OnPaidFailed(params object[] data)
		{
		}

		// Token: 0x06009034 RID: 36916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009034")]
		[Address(RVA = "0x16F0A7C", Offset = "0x16F0A7C", VA = "0x7BBBEF0A7C", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009035 RID: 36917 RVA: 0x000266B8 File Offset: 0x000248B8
		[Token(Token = "0x6009035")]
		[Address(RVA = "0x16F0B90", Offset = "0x16F0B90", VA = "0x7BBBEF0B90", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009036 RID: 36918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009036")]
		[Address(RVA = "0x16F0B98", Offset = "0x16F0B98", VA = "0x7BBBEF0B98")]
		private void OnBtnClick()
		{
		}

		// Token: 0x06009037 RID: 36919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009037")]
		[Address(RVA = "0x16F0FA4", Offset = "0x16F0FA4", VA = "0x7BBBEF0FA4")]
		public UIPaymentBundleBuyDialogController()
		{
		}

		// Token: 0x06009038 RID: 36920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009038")]
		[Address(RVA = "0x16F0FAC", Offset = "0x16F0FAC", VA = "0x7BBBEF0FAC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144858", Offset = "0x1144858")]
		private void <OnBtnClick>b__9_0()
		{
		}

		// Token: 0x04009BFB RID: 39931
		[Token(Token = "0x4009BFB")]
		[FieldOffset(Offset = "0x98")]
		private UIPaymentBundleBuyDialogView m_View;

		// Token: 0x04009BFC RID: 39932
		[Token(Token = "0x4009BFC")]
		[FieldOffset(Offset = "0xA0")]
		private PayBundleWindowDesc m_Data;
	}
}
