using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001420 RID: 5152
	[Token(Token = "0x2001420")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC7A0", Offset = "0x10EC7A0")]
	public class UIHUDArmsRaceBonusCardController : UIBaseController
	{
		// Token: 0x06005500 RID: 21760 RVA: 0x000195D8 File Offset: 0x000177D8
		[Token(Token = "0x6005500")]
		[Address(RVA = "0x16B0ADC", Offset = "0x16B0ADC", VA = "0x7BBBEB0ADC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005501 RID: 21761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005501")]
		[Address(RVA = "0x16B0B2C", Offset = "0x16B0B2C", VA = "0x7BBBEB0B2C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005502 RID: 21762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005502")]
		[Address(RVA = "0x16B0CE0", Offset = "0x16B0CE0", VA = "0x7BBBEB0CE0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005503 RID: 21763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005503")]
		[Address(RVA = "0x16B0DAC", Offset = "0x16B0DAC", VA = "0x7BBBEB0DAC")]
		private void OnUseCard()
		{
		}

		// Token: 0x06005504 RID: 21764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005504")]
		[Address(RVA = "0x16B0E50", Offset = "0x16B0E50", VA = "0x7BBBEB0E50")]
		private void OnLocalPlayerGetPoint(params object[] param)
		{
		}

		// Token: 0x06005505 RID: 21765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005505")]
		[Address(RVA = "0x16B0E60", Offset = "0x16B0E60", VA = "0x7BBBEB0E60")]
		public UIHUDArmsRaceBonusCardController()
		{
		}

		// Token: 0x04007A29 RID: 31273
		[Token(Token = "0x4007A29")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDArmsRaceBonucCardView m_view;
	}
}
