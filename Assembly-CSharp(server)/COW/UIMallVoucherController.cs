using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BF6 RID: 7158
	[Token(Token = "0x2001BF6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB42C", Offset = "0x10FB42C")]
	public class UIMallVoucherController : UIVoucherController
	{
		// Token: 0x06009B91 RID: 39825 RVA: 0x00028DE8 File Offset: 0x00026FE8
		[Token(Token = "0x6009B91")]
		[Address(RVA = "0x1DF2BEC", Offset = "0x1DF2BEC", VA = "0x7BBC5F2BEC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009B92 RID: 39826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B92")]
		[Address(RVA = "0x1DF2C3C", Offset = "0x1DF2C3C", VA = "0x7BBC5F2C3C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009B93 RID: 39827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B93")]
		[Address(RVA = "0x1DF2DE4", Offset = "0x1DF2DE4", VA = "0x7BBC5F2DE4", Slot = "28")]
		public override void OnVoucherListClose(params object[] data)
		{
		}

		// Token: 0x06009B94 RID: 39828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B94")]
		[Address(RVA = "0x1DF2E5C", Offset = "0x1DF2E5C", VA = "0x7BBC5F2E5C", Slot = "29")]
		public override void OnVoucherItemClick(params object[] data)
		{
		}

		// Token: 0x06009B95 RID: 39829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B95")]
		[Address(RVA = "0x1DF317C", Offset = "0x1DF317C", VA = "0x7BBC5F317C", Slot = "30")]
		public override void OnVoucherBtnClick()
		{
		}

		// Token: 0x06009B96 RID: 39830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B96")]
		[Address(RVA = "0x1DF3488", Offset = "0x1DF3488", VA = "0x7BBC5F3488", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009B97 RID: 39831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B97")]
		[Address(RVA = "0x1DF35B0", Offset = "0x1DF35B0", VA = "0x7BBC5F35B0", Slot = "32")]
		public override void ResetSelectedVoucher()
		{
		}

		// Token: 0x06009B98 RID: 39832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B98")]
		[Address(RVA = "0x1DF36A0", Offset = "0x1DF36A0", VA = "0x7BBC5F36A0")]
		public UIMallVoucherController()
		{
		}

		// Token: 0x0400A1D3 RID: 41427
		[Token(Token = "0x400A1D3")]
		[FieldOffset(Offset = "0x70")]
		private UIMallVoucherView m_View;

		// Token: 0x0400A1D4 RID: 41428
		[Token(Token = "0x400A1D4")]
		[FieldOffset(Offset = "0x78")]
		private UIVoucherListController m_Ctrl;
	}
}
