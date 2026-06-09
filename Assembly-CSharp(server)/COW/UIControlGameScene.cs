using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02002067 RID: 8295
	[Token(Token = "0x2002067")]
	internal class UIControlGameScene : UITeamModeBaseGameScene
	{
		// Token: 0x0600B8D3 RID: 47315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8D3")]
		[Address(RVA = "0x18173E0", Offset = "0x18173E0", VA = "0x7BBC0173E0", Slot = "12")]
		protected override void OpenCommonHud()
		{
		}

		// Token: 0x0600B8D4 RID: 47316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8D4")]
		[Address(RVA = "0x18175E8", Offset = "0x18175E8", VA = "0x7BBC0175E8", Slot = "10")]
		public override void RegisterGameEventHandler()
		{
		}

		// Token: 0x0600B8D5 RID: 47317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8D5")]
		[Address(RVA = "0x1817708", Offset = "0x1817708", VA = "0x7BBC017708", Slot = "9")]
		protected override void OnDestory()
		{
		}

		// Token: 0x0600B8D6 RID: 47318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8D6")]
		[Address(RVA = "0x1817828", Offset = "0x1817828", VA = "0x7BBC017828")]
		private void ShowBuffIcon(params object[] data)
		{
		}

		// Token: 0x0600B8D7 RID: 47319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8D7")]
		[Address(RVA = "0x1817984", Offset = "0x1817984", VA = "0x7BBC017984")]
		private void ShowControlLeaderboard(object[] data)
		{
		}

		// Token: 0x0600B8D8 RID: 47320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B8D8")]
		[Address(RVA = "0x1817A28", Offset = "0x1817A28", VA = "0x7BBC017A28", Slot = "14")]
		protected override Type GetMatchResultType()
		{
			return null;
		}

		// Token: 0x0600B8D9 RID: 47321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8D9")]
		[Address(RVA = "0x1817A98", Offset = "0x1817A98", VA = "0x7BBC017A98")]
		public UIControlGameScene()
		{
		}

		// Token: 0x0400BA84 RID: 47748
		[Token(Token = "0x400BA84")]
		[FieldOffset(Offset = "0x3E8")]
		private UIHUDControlModeBuffIconController m_BuffIcon;
	}
}
