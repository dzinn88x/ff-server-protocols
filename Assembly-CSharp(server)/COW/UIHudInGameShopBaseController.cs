using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018E0 RID: 6368
	[Token(Token = "0x20018E0")]
	internal class UIHudInGameShopBaseController : UIBaseController
	{
		// Token: 0x06007F25 RID: 32549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F25")]
		[Address(RVA = "0x1986A0C", Offset = "0x1986A0C", VA = "0x7BBC186A0C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007F26 RID: 32550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F26")]
		[Address(RVA = "0x1986E44", Offset = "0x1986E44", VA = "0x7BBC186E44", Slot = "28")]
		protected virtual void OnInitSpecialUIElement()
		{
		}

		// Token: 0x06007F27 RID: 32551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F27")]
		[Address(RVA = "0x1986E48", Offset = "0x1986E48", VA = "0x7BBC186E48", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007F28 RID: 32552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F28")]
		[Address(RVA = "0x1987018", Offset = "0x1987018", VA = "0x7BBC187018")]
		private void OnTokenChanged(params object[] data)
		{
		}

		// Token: 0x06007F29 RID: 32553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F29")]
		[Address(RVA = "0x19870F0", Offset = "0x19870F0", VA = "0x7BBC1870F0")]
		public void SetTokenType(UIHudInGameShopItemViewExt.CoinIconType coinType)
		{
		}

		// Token: 0x06007F2A RID: 32554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F2A")]
		[Address(RVA = "0x19871FC", Offset = "0x19871FC", VA = "0x7BBC1871FC", Slot = "29")]
		protected virtual void OnItemSelected(params object[] data)
		{
		}

		// Token: 0x06007F2B RID: 32555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F2B")]
		[Address(RVA = "0x1987200", Offset = "0x1987200", VA = "0x7BBC187200", Slot = "30")]
		protected virtual void OnPurchaseBtnClick()
		{
		}

		// Token: 0x06007F2C RID: 32556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F2C")]
		[Address(RVA = "0x1987204", Offset = "0x1987204", VA = "0x7BBC187204", Slot = "31")]
		protected virtual void OnBuySameBtnClick()
		{
		}

		// Token: 0x06007F2D RID: 32557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F2D")]
		[Address(RVA = "0x1987208", Offset = "0x1987208", VA = "0x7BBC187208", Slot = "32")]
		protected virtual void OnCloseBtnClick()
		{
		}

		// Token: 0x06007F2E RID: 32558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F2E")]
		[Address(RVA = "0x198720C", Offset = "0x198720C", VA = "0x7BBC18720C")]
		public void SetCountdownTime(float secs)
		{
		}

		// Token: 0x06007F2F RID: 32559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F2F")]
		[Address(RVA = "0x19873FC", Offset = "0x19873FC", VA = "0x7BBC1873FC")]
		private void Update()
		{
		}

		// Token: 0x06007F30 RID: 32560 RVA: 0x00022B90 File Offset: 0x00020D90
		[Token(Token = "0x6007F30")]
		[Address(RVA = "0x1987464", Offset = "0x1987464", VA = "0x7BBC187464")]
		public bool IsAutoHideFinished()
		{
			return default(bool);
		}

		// Token: 0x06007F31 RID: 32561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F31")]
		[Address(RVA = "0x1987494", Offset = "0x1987494", VA = "0x7BBC187494")]
		public void ManullyStopTimerTick()
		{
		}

		// Token: 0x06007F32 RID: 32562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F32")]
		[Address(RVA = "0x19874C4", Offset = "0x19874C4", VA = "0x7BBC1874C4")]
		public UIHudInGameShopBaseController()
		{
		}

		// Token: 0x0400922F RID: 37423
		[Token(Token = "0x400922F")]
		[FieldOffset(Offset = "0x58")]
		protected UIHudInGameShopView m_View;

		// Token: 0x04009230 RID: 37424
		[Token(Token = "0x4009230")]
		[FieldOffset(Offset = "0x60")]
		protected int m_TokenCount;

		// Token: 0x04009231 RID: 37425
		[Token(Token = "0x4009231")]
		[FieldOffset(Offset = "0x68")]
		private UITimeLabelHelper m_TimeHelper;
	}
}
