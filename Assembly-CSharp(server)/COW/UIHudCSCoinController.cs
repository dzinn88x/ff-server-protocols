using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014B1 RID: 5297
	[Token(Token = "0x20014B1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED574", Offset = "0x10ED574")]
	internal class UIHudCSCoinController : UIBaseController
	{
		// Token: 0x060059DB RID: 23003 RVA: 0x0001A730 File Offset: 0x00018930
		[Token(Token = "0x60059DB")]
		[Address(RVA = "0x19B5F6C", Offset = "0x19B5F6C", VA = "0x7BBC1B5F6C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060059DC RID: 23004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059DC")]
		[Address(RVA = "0x19B5FBC", Offset = "0x19B5FBC", VA = "0x7BBC1B5FBC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060059DD RID: 23005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059DD")]
		[Address(RVA = "0x19B612C", Offset = "0x19B612C", VA = "0x7BBC1B612C", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060059DE RID: 23006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059DE")]
		[Address(RVA = "0x19B624C", Offset = "0x19B624C", VA = "0x7BBC1B624C")]
		private void OnCurCoinChanged(params object[] data)
		{
		}

		// Token: 0x060059DF RID: 23007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059DF")]
		[Address(RVA = "0x19B631C", Offset = "0x19B631C", VA = "0x7BBC1B631C")]
		private void OnSpectatorTargetChanged(params object[] data)
		{
		}

		// Token: 0x060059E0 RID: 23008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059E0")]
		[Address(RVA = "0x19B6628", Offset = "0x19B6628", VA = "0x7BBC1B6628")]
		public UIHudCSCoinController()
		{
		}

		// Token: 0x04007D24 RID: 32036
		[Token(Token = "0x4007D24")]
		[FieldOffset(Offset = "0x58")]
		private UIHudCSCoinView m_View;
	}
}
