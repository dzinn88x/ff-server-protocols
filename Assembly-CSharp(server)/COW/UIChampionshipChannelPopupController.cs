using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200146B RID: 5227
	[Token(Token = "0x200146B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECD20", Offset = "0x10ECD20")]
	public class UIChampionshipChannelPopupController : UIPopupWindowController
	{
		// Token: 0x060057E6 RID: 22502 RVA: 0x00019FC8 File Offset: 0x000181C8
		[Token(Token = "0x60057E6")]
		[Address(RVA = "0x1C27674", Offset = "0x1C27674", VA = "0x7BBC427674")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060057E7 RID: 22503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057E7")]
		[Address(RVA = "0x1C276C4", Offset = "0x1C276C4", VA = "0x7BBC4276C4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060057E8 RID: 22504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057E8")]
		[Address(RVA = "0x1C27A1C", Offset = "0x1C27A1C", VA = "0x7BBC427A1C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060057E9 RID: 22505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057E9")]
		[Address(RVA = "0x1C277B0", Offset = "0x1C277B0", VA = "0x7BBC4277B0")]
		private void RefreshView()
		{
		}

		// Token: 0x060057EA RID: 22506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057EA")]
		[Address(RVA = "0x1C27AE8", Offset = "0x1C27AE8", VA = "0x7BBC427AE8")]
		private void ChannelSelectHandler(params object[] param)
		{
		}

		// Token: 0x060057EB RID: 22507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057EB")]
		[Address(RVA = "0x1C27AF0", Offset = "0x1C27AF0", VA = "0x7BBC427AF0")]
		public UIChampionshipChannelPopupController()
		{
		}

		// Token: 0x04007BF8 RID: 31736
		[Token(Token = "0x4007BF8")]
		[FieldOffset(Offset = "0x98")]
		private UIChampionshipChannelPopupView m_View;
	}
}
