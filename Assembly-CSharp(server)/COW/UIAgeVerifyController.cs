using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016A1 RID: 5793
	[Token(Token = "0x20016A1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F079C", Offset = "0x10F079C")]
	public class UIAgeVerifyController : UIPopupWindowController
	{
		// Token: 0x06006988 RID: 27016 RVA: 0x0001DE98 File Offset: 0x0001C098
		[Token(Token = "0x6006988")]
		[Address(RVA = "0x1969308", Offset = "0x1969308", VA = "0x7BBC169308")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006989 RID: 27017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006989")]
		[Address(RVA = "0x1969358", Offset = "0x1969358", VA = "0x7BBC169358", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600698A RID: 27018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600698A")]
		[Address(RVA = "0x1969544", Offset = "0x1969544", VA = "0x7BBC169544")]
		private void OnlowAgeClick()
		{
		}

		// Token: 0x0600698B RID: 27019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600698B")]
		[Address(RVA = "0x19695F8", Offset = "0x19695F8", VA = "0x7BBC1695F8")]
		public void SetCallback(Action callback)
		{
		}

		// Token: 0x0600698C RID: 27020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600698C")]
		[Address(RVA = "0x1969600", Offset = "0x1969600", VA = "0x7BBC169600")]
		private void OnMidAgeClick()
		{
		}

		// Token: 0x0600698D RID: 27021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600698D")]
		[Address(RVA = "0x1969698", Offset = "0x1969698", VA = "0x7BBC169698")]
		private void OnHighAgeClick()
		{
		}

		// Token: 0x0600698E RID: 27022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600698E")]
		[Address(RVA = "0x1969730", Offset = "0x1969730", VA = "0x7BBC169730")]
		private void OnSkipClick()
		{
		}

		// Token: 0x0600698F RID: 27023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600698F")]
		[Address(RVA = "0x19695DC", Offset = "0x19695DC", VA = "0x7BBC1695DC")]
		private void DoCallback()
		{
		}

		// Token: 0x06006990 RID: 27024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006990")]
		[Address(RVA = "0x1969770", Offset = "0x1969770", VA = "0x7BBC169770")]
		public UIAgeVerifyController()
		{
		}

		// Token: 0x04008662 RID: 34402
		[Token(Token = "0x4008662")]
		[FieldOffset(Offset = "0x98")]
		public UIAgeVerifyView m_View;

		// Token: 0x04008663 RID: 34403
		[Token(Token = "0x4008663")]
		[FieldOffset(Offset = "0xA0")]
		public Action m_Callback;
	}
}
