using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200208E RID: 8334
	[Token(Token = "0x200208E")]
	internal class UITeamModeBaseGameScene : UIInGameScene
	{
		// Token: 0x0600BB0C RID: 47884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB0C")]
		[Address(RVA = "0x1F530EC", Offset = "0x1F530EC", VA = "0x7BBC7530EC", Slot = "12")]
		protected override void OpenCommonHud()
		{
		}

		// Token: 0x0600BB0D RID: 47885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB0D")]
		[Address(RVA = "0x1F532C0", Offset = "0x1F532C0", VA = "0x7BBC7532C0", Slot = "25")]
		protected override void OnOpenHudInPregame()
		{
		}

		// Token: 0x0600BB0E RID: 47886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB0E")]
		[Address(RVA = "0x1F4FEA4", Offset = "0x1F4FEA4", VA = "0x7BBC74FEA4", Slot = "10")]
		public override void RegisterGameEventHandler()
		{
		}

		// Token: 0x0600BB0F RID: 47887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB0F")]
		[Address(RVA = "0x1F500EC", Offset = "0x1F500EC", VA = "0x7BBC7500EC", Slot = "9")]
		protected override void OnDestory()
		{
		}

		// Token: 0x0600BB10 RID: 47888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB10")]
		[Address(RVA = "0x1F534F8", Offset = "0x1F534F8", VA = "0x7BBC7534F8")]
		public void OnShowTDMLikeShop(params object[] data)
		{
		}

		// Token: 0x0600BB11 RID: 47889 RVA: 0x000350E8 File Offset: 0x000332E8
		[Token(Token = "0x600BB11")]
		[Address(RVA = "0x1F5386C", Offset = "0x1F5386C", VA = "0x7BBC75386C")]
		public bool IsBombLikeShopIsShowing()
		{
			return default(bool);
		}

		// Token: 0x0600BB12 RID: 47890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB12")]
		[Address(RVA = "0x1F53910", Offset = "0x1F53910", VA = "0x7BBC753910")]
		private void OnShowMatchInfo(params object[] param)
		{
		}

		// Token: 0x0600BB13 RID: 47891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB13")]
		[Address(RVA = "0x1F53B0C", Offset = "0x1F53B0C", VA = "0x7BBC753B0C", Slot = "29")]
		protected virtual void ShowTeamScore(params object[] data)
		{
		}

		// Token: 0x0600BB14 RID: 47892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB14")]
		[Address(RVA = "0x1F502E0", Offset = "0x1F502E0", VA = "0x7BBC7502E0")]
		public UITeamModeBaseGameScene()
		{
		}

		// Token: 0x0600BB15 RID: 47893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB15")]
		[Address(RVA = "0x1F53B10", Offset = "0x1F53B10", VA = "0x7BBC753B10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147CB4", Offset = "0x1147CB4")]
		private void <OnOpenHudInPregame>b__4_0()
		{
		}

		// Token: 0x0400BC36 RID: 48182
		[Token(Token = "0x400BC36")]
		[FieldOffset(Offset = "0x3D0")]
		private UIHudGameShowInfoController m_ShowInfoCtrl;

		// Token: 0x0400BC37 RID: 48183
		[Token(Token = "0x400BC37")]
		[FieldOffset(Offset = "0x3D8")]
		protected UIHudTDMLikeShopController m_TDMLikeShopController;

		// Token: 0x0400BC38 RID: 48184
		[Token(Token = "0x400BC38")]
		[FieldOffset(Offset = "0x3E0")]
		protected UIHudCSShopEntryController m_TDMShopEntryCtrl;
	}
}
