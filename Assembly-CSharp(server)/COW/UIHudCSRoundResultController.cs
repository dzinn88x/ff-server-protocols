using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014C0 RID: 5312
	[Token(Token = "0x20014C0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED774", Offset = "0x10ED774")]
	internal class UIHudCSRoundResultController : UIHudBaseCSRoundResultController
	{
		// Token: 0x06005A49 RID: 23113 RVA: 0x0001A8C8 File Offset: 0x00018AC8
		[Token(Token = "0x6005A49")]
		[Address(RVA = "0x19C2050", Offset = "0x19C2050", VA = "0x7BBC1C2050")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005A4A RID: 23114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A4A")]
		[Address(RVA = "0x19C20A0", Offset = "0x19C20A0", VA = "0x7BBC1C20A0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005A4B RID: 23115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A4B")]
		[Address(RVA = "0x19C2300", Offset = "0x19C2300", VA = "0x7BBC1C2300", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06005A4C RID: 23116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A4C")]
		[Address(RVA = "0x19C23CC", Offset = "0x19C23CC", VA = "0x7BBC1C23CC", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06005A4D RID: 23117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A4D")]
		[Address(RVA = "0x19C288C", Offset = "0x19C288C", VA = "0x7BBC1C288C")]
		private void OnEarnedCoinChanged(params object[] data)
		{
		}

		// Token: 0x06005A4E RID: 23118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A4E")]
		[Address(RVA = "0x19C2404", Offset = "0x19C2404", VA = "0x7BBC1C2404")]
		private void SetUIData()
		{
		}

		// Token: 0x06005A4F RID: 23119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A4F")]
		[Address(RVA = "0x19C29E8", Offset = "0x19C29E8", VA = "0x7BBC1C29E8")]
		public UIHudCSRoundResultController()
		{
		}

		// Token: 0x04007D59 RID: 32089
		[Token(Token = "0x4007D59")]
		[FieldOffset(Offset = "0x80")]
		private UIHudCSRoundResultView m_View;
	}
}
