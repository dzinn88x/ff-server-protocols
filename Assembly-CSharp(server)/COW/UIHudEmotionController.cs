using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018B0 RID: 6320
	[Token(Token = "0x20018B0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4984", Offset = "0x10F4984")]
	internal class UIHudEmotionController : UIBaseController
	{
		// Token: 0x06007DA2 RID: 32162 RVA: 0x000226C8 File Offset: 0x000208C8
		[Token(Token = "0x6007DA2")]
		[Address(RVA = "0x1C01A04", Offset = "0x1C01A04", VA = "0x7BBC401A04")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007DA3 RID: 32163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DA3")]
		[Address(RVA = "0x1C01A54", Offset = "0x1C01A54", VA = "0x7BBC401A54", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007DA4 RID: 32164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DA4")]
		[Address(RVA = "0x1C01EE4", Offset = "0x1C01EE4", VA = "0x7BBC401EE4", Slot = "28")]
		protected virtual void InitEmotions()
		{
		}

		// Token: 0x06007DA5 RID: 32165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DA5")]
		[Address(RVA = "0x1C01D60", Offset = "0x1C01D60", VA = "0x7BBC401D60")]
		private void RefreshBtnCustomoAnimVisibility()
		{
		}

		// Token: 0x06007DA6 RID: 32166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DA6")]
		[Address(RVA = "0x1C0246C", Offset = "0x1C0246C", VA = "0x7BBC40246C")]
		protected void OnBtnCustomAnimClick()
		{
		}

		// Token: 0x06007DA7 RID: 32167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DA7")]
		[Address(RVA = "0x1C02594", Offset = "0x1C02594", VA = "0x7BBC402594")]
		protected void OnBtnMaskClick()
		{
		}

		// Token: 0x06007DA8 RID: 32168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DA8")]
		[Address(RVA = "0x1C02630", Offset = "0x1C02630", VA = "0x7BBC402630", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06007DA9 RID: 32169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DA9")]
		[Address(RVA = "0x1C02634", Offset = "0x1C02634", VA = "0x7BBC402634")]
		public UIHudEmotionController()
		{
		}

		// Token: 0x0400912C RID: 37164
		[Token(Token = "0x400912C")]
		[FieldOffset(Offset = "0x58")]
		protected UIHudEmotionView m_View;

		// Token: 0x0400912D RID: 37165
		[Token(Token = "0x400912D")]
		[FieldOffset(Offset = "0x60")]
		protected List<UIHudEmotionItem> m_EmotionItems;
	}
}
