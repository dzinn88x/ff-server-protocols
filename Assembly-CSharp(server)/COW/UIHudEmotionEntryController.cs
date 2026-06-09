using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018B1 RID: 6321
	[Token(Token = "0x20018B1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F49BC", Offset = "0x10F49BC")]
	internal class UIHudEmotionEntryController : UIHudButtonBaseController
	{
		// Token: 0x06007DAA RID: 32170 RVA: 0x000226E0 File Offset: 0x000208E0
		[Token(Token = "0x6007DAA")]
		[Address(RVA = "0x1C0263C", Offset = "0x1C0263C", VA = "0x7BBC40263C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007DAB RID: 32171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DAB")]
		[Address(RVA = "0x1C0268C", Offset = "0x1C0268C", VA = "0x7BBC40268C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007DAC RID: 32172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DAC")]
		[Address(RVA = "0x1C027EC", Offset = "0x1C027EC", VA = "0x7BBC4027EC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007DAD RID: 32173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DAD")]
		[Address(RVA = "0x1C028B8", Offset = "0x1C028B8", VA = "0x7BBC4028B8")]
		private void OnUseMicrophone(object[] param)
		{
		}

		// Token: 0x06007DAE RID: 32174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DAE")]
		[Address(RVA = "0x1C02D80", Offset = "0x1C02D80", VA = "0x7BBC402D80")]
		private void OnBtnEmotionEntryClick()
		{
		}

		// Token: 0x06007DAF RID: 32175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DAF")]
		[Address(RVA = "0x1C02974", Offset = "0x1C02974", VA = "0x7BBC402974")]
		private void RequestOpenEmotionPanel()
		{
		}

		// Token: 0x06007DB0 RID: 32176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007DB0")]
		[Address(RVA = "0x1C02E3C", Offset = "0x1C02E3C", VA = "0x7BBC402E3C", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06007DB1 RID: 32177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DB1")]
		[Address(RVA = "0x1C02EF8", Offset = "0x1C02EF8", VA = "0x7BBC402EF8")]
		public UIHudEmotionEntryController()
		{
		}

		// Token: 0x0400912E RID: 37166
		[Token(Token = "0x400912E")]
		[FieldOffset(Offset = "0x60")]
		private UIHudEmotionEntryView m_View;
	}
}
