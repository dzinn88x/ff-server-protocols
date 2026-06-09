using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001783 RID: 6019
	[Token(Token = "0x2001783")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F233C", Offset = "0x10F233C")]
	public class UIDebrisRewardWindowController : UIPopupWindowController
	{
		// Token: 0x06007249 RID: 29257 RVA: 0x0001FCF8 File Offset: 0x0001DEF8
		[Token(Token = "0x6007249")]
		[Address(RVA = "0x1BAFB30", Offset = "0x1BAFB30", VA = "0x7BBC3AFB30")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600724A RID: 29258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600724A")]
		[Address(RVA = "0x1BAFB80", Offset = "0x1BAFB80", VA = "0x7BBC3AFB80", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600724B RID: 29259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600724B")]
		[Address(RVA = "0x1BAFBFC", Offset = "0x1BAFBFC", VA = "0x7BBC3AFBFC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600724C RID: 29260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600724C")]
		[Address(RVA = "0x1BAFCE0", Offset = "0x1BAFCE0", VA = "0x7BBC3AFCE0")]
		public void SetViewData(List<BaseItemInfo> infos)
		{
		}

		// Token: 0x0600724D RID: 29261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600724D")]
		[Address(RVA = "0x1BAFEEC", Offset = "0x1BAFEEC", VA = "0x7BBC3AFEEC")]
		private void OnOKBtnClick()
		{
		}

		// Token: 0x0600724E RID: 29262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600724E")]
		[Address(RVA = "0x1BAFEF4", Offset = "0x1BAFEF4", VA = "0x7BBC3AFEF4", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600724F RID: 29263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600724F")]
		[Address(RVA = "0x1BAFFA0", Offset = "0x1BAFFA0", VA = "0x7BBC3AFFA0", Slot = "38")]
		public override void EnterByReturn()
		{
		}

		// Token: 0x06007250 RID: 29264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007250")]
		[Address(RVA = "0x1BB0038", Offset = "0x1BB0038", VA = "0x7BBC3B0038")]
		public UIDebrisRewardWindowController()
		{
		}

		// Token: 0x04008B64 RID: 35684
		[Token(Token = "0x4008B64")]
		[FieldOffset(Offset = "0x98")]
		private UIDebrisRewardWindowView m_View;
	}
}
