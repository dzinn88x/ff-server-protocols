using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200180A RID: 6154
	[Token(Token = "0x200180A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F345C", Offset = "0x10F345C")]
	internal class UIGachaLimitRemoveConfirmController : UIPopupWindowController
	{
		// Token: 0x060077AE RID: 30638 RVA: 0x00021138 File Offset: 0x0001F338
		[Token(Token = "0x60077AE")]
		[Address(RVA = "0x2066358", Offset = "0x2066358", VA = "0x7BBC866358")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060077AF RID: 30639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077AF")]
		[Address(RVA = "0x20663A8", Offset = "0x20663A8", VA = "0x7BBC8663A8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060077B0 RID: 30640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077B0")]
		[Address(RVA = "0x20664E4", Offset = "0x20664E4", VA = "0x7BBC8664E4")]
		private void OnOKClick()
		{
		}

		// Token: 0x060077B1 RID: 30641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077B1")]
		[Address(RVA = "0x2061680", Offset = "0x2061680", VA = "0x7BBC861680")]
		public void SetViewData(uint gachaID, uint subID)
		{
		}

		// Token: 0x060077B2 RID: 30642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077B2")]
		[Address(RVA = "0x2066538", Offset = "0x2066538", VA = "0x7BBC866538")]
		public UIGachaLimitRemoveConfirmController()
		{
		}

		// Token: 0x04008E00 RID: 36352
		[Token(Token = "0x4008E00")]
		[FieldOffset(Offset = "0x98")]
		private UIGachaLimitRemoveConfrimWndView m_View;

		// Token: 0x04008E01 RID: 36353
		[Token(Token = "0x4008E01")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelGacha m_ModelGacha;

		// Token: 0x04008E02 RID: 36354
		[Token(Token = "0x4008E02")]
		[FieldOffset(Offset = "0xA8")]
		private uint m_GachaID;

		// Token: 0x04008E03 RID: 36355
		[Token(Token = "0x4008E03")]
		[FieldOffset(Offset = "0xAC")]
		private uint m_SubID;
	}
}
