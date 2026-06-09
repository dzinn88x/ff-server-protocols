using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200209E RID: 8350
	[Token(Token = "0x200209E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FDBCC", Offset = "0x10FDBCC")]
	internal class UIHudCatapultLaunchButtonController : UIHudButtonBaseController
	{
		// Token: 0x0600BBC6 RID: 48070 RVA: 0x00035220 File Offset: 0x00033420
		[Token(Token = "0x600BBC6")]
		[Address(RVA = "0x19D1614", Offset = "0x19D1614", VA = "0x7BBC1D1614")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600BBC7 RID: 48071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBC7")]
		[Address(RVA = "0x19D1664", Offset = "0x19D1664", VA = "0x7BBC1D1664", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600BBC8 RID: 48072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BBC8")]
		[Address(RVA = "0x19D16DC", Offset = "0x19D16DC", VA = "0x7BBC1D16DC", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x0600BBC9 RID: 48073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBC9")]
		[Address(RVA = "0x19D1724", Offset = "0x19D1724", VA = "0x7BBC1D1724", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x0600BBCA RID: 48074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBCA")]
		[Address(RVA = "0x19D18BC", Offset = "0x19D18BC", VA = "0x7BBC1D18BC")]
		private void ShowTutorialFireCatapult()
		{
		}

		// Token: 0x0600BBCB RID: 48075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBCB")]
		[Address(RVA = "0x19D195C", Offset = "0x19D195C", VA = "0x7BBC1D195C")]
		public UIHudCatapultLaunchButtonController()
		{
		}

		// Token: 0x0400BC8E RID: 48270
		[Token(Token = "0x400BC8E")]
		[FieldOffset(Offset = "0x60")]
		private UIHudCatapultLaunchView m_View;
	}
}
