using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020017EA RID: 6122
	[Token(Token = "0x20017EA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F30EC", Offset = "0x10F30EC")]
	public class UIGachaExtraPreviewItemController : UIBaseController
	{
		// Token: 0x0600767B RID: 30331 RVA: 0x00020D90 File Offset: 0x0001EF90
		[Token(Token = "0x600767B")]
		[Address(RVA = "0x2163CC8", Offset = "0x2163CC8", VA = "0x7BBC963CC8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600767C RID: 30332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600767C")]
		[Address(RVA = "0x2163D18", Offset = "0x2163D18", VA = "0x7BBC963D18", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600767D RID: 30333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600767D")]
		[Address(RVA = "0x2163DA4", Offset = "0x2163DA4", VA = "0x7BBC963DA4")]
		public void SetViewData(AwardDesc desc)
		{
		}

		// Token: 0x0600767E RID: 30334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600767E")]
		[Address(RVA = "0x2163E64", Offset = "0x2163E64", VA = "0x7BBC963E64", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600767F RID: 30335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600767F")]
		[Address(RVA = "0x2163E6C", Offset = "0x2163E6C", VA = "0x7BBC963E6C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007680 RID: 30336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007680")]
		[Address(RVA = "0x2163E74", Offset = "0x2163E74", VA = "0x7BBC963E74")]
		public UIGachaExtraPreviewItemController()
		{
		}

		// Token: 0x04008D4B RID: 36171
		[Token(Token = "0x4008D4B")]
		[FieldOffset(Offset = "0x58")]
		private UIGachaExtraPreviewItemView m_View;
	}
}
