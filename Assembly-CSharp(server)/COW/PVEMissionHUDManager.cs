using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200161D RID: 5661
	[Token(Token = "0x200161D")]
	internal class PVEMissionHUDManager
	{
		// Token: 0x060065B9 RID: 26041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B9")]
		[Address(RVA = "0x203CD50", Offset = "0x203CD50", VA = "0x7BBC83CD50")]
		public void InitManager(UIInGameScene uiScene)
		{
		}

		// Token: 0x060065BA RID: 26042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065BA")]
		[Address(RVA = "0x203CD5C", Offset = "0x203CD5C", VA = "0x7BBC83CD5C")]
		public void MissionCome(string content)
		{
		}

		// Token: 0x060065BB RID: 26043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065BB")]
		[Address(RVA = "0x203CF98", Offset = "0x203CF98", VA = "0x7BBC83CF98")]
		public void OnCenterShowFinish(string content)
		{
		}

		// Token: 0x060065BC RID: 26044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065BC")]
		[Address(RVA = "0x203D0A8", Offset = "0x203D0A8", VA = "0x7BBC83D0A8")]
		public PVEMissionHUDManager()
		{
		}

		// Token: 0x040083D7 RID: 33751
		[Token(Token = "0x40083D7")]
		[FieldOffset(Offset = "0x10")]
		private UIHUDPVEMissionListController m_ListController;

		// Token: 0x040083D8 RID: 33752
		[Token(Token = "0x40083D8")]
		[FieldOffset(Offset = "0x18")]
		private UIHUDPVEMissionCenterTipController m_CenterTipController;

		// Token: 0x040083D9 RID: 33753
		[Token(Token = "0x40083D9")]
		[FieldOffset(Offset = "0x20")]
		private UIInGameScene m_UIScene;

		// Token: 0x040083DA RID: 33754
		[Token(Token = "0x40083DA")]
		[FieldOffset(Offset = "0x28")]
		private string m_MissionContent;
	}
}
