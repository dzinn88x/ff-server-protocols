using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200180D RID: 6157
	[Token(Token = "0x200180D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3504", Offset = "0x10F3504")]
	public class UIGachaNormalBuyBtnController : UIGachaBuyBtnController
	{
		// Token: 0x060077BF RID: 30655 RVA: 0x000211B0 File Offset: 0x0001F3B0
		[Token(Token = "0x60077BF")]
		[Address(RVA = "0x2067854", Offset = "0x2067854", VA = "0x7BBC867854")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060077C0 RID: 30656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077C0")]
		[Address(RVA = "0x20678A4", Offset = "0x20678A4", VA = "0x7BBC8678A4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060077C1 RID: 30657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077C1")]
		[Address(RVA = "0x2067904", Offset = "0x2067904", VA = "0x7BBC867904", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060077C2 RID: 30658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077C2")]
		[Address(RVA = "0x206790C", Offset = "0x206790C", VA = "0x7BBC86790C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060077C3 RID: 30659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077C3")]
		[Address(RVA = "0x2067914", Offset = "0x2067914", VA = "0x7BBC867914", Slot = "28")]
		protected override void InitBuyBtnBaseView()
		{
		}

		// Token: 0x060077C4 RID: 30660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077C4")]
		[Address(RVA = "0x2067948", Offset = "0x2067948", VA = "0x7BBC867948")]
		public UIGachaNormalBuyBtnController()
		{
		}

		// Token: 0x04008E06 RID: 36358
		[Token(Token = "0x4008E06")]
		[FieldOffset(Offset = "0x78")]
		private UIGachaNormalBuyBtnView m_NormalView;
	}
}
