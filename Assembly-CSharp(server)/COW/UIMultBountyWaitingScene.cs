using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02002089 RID: 8329
	[Token(Token = "0x2002089")]
	internal class UIMultBountyWaitingScene : UIInGameScene
	{
		// Token: 0x0600BADE RID: 47838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BADE")]
		[Address(RVA = "0x14CB8F4", Offset = "0x14CB8F4", VA = "0x7BBBCCB8F4", Slot = "10")]
		public override void RegisterGameEventHandler()
		{
		}

		// Token: 0x0600BADF RID: 47839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BADF")]
		[Address(RVA = "0x14CB9C0", Offset = "0x14CB9C0", VA = "0x7BBBCCB9C0")]
		private void OnTeleportMachineStateCome(params object[] param)
		{
		}

		// Token: 0x0600BAE0 RID: 47840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAE0")]
		[Address(RVA = "0x14CBD14", Offset = "0x14CBD14", VA = "0x7BBBCCBD14")]
		public void ShowRepairTip(string str)
		{
		}

		// Token: 0x0600BAE1 RID: 47841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAE1")]
		[Address(RVA = "0x14CBB70", Offset = "0x14CBB70", VA = "0x7BBBCCBB70")]
		private void OpenRankController()
		{
		}

		// Token: 0x0600BAE2 RID: 47842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAE2")]
		[Address(RVA = "0x14CBC48", Offset = "0x14CBC48", VA = "0x7BBBCCBC48")]
		private void OpenProgressController()
		{
		}

		// Token: 0x0600BAE3 RID: 47843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAE3")]
		[Address(RVA = "0x14CBDDC", Offset = "0x14CBDDC", VA = "0x7BBBCCBDDC")]
		public void CloseFakeLoadingMask()
		{
		}

		// Token: 0x0600BAE4 RID: 47844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAE4")]
		[Address(RVA = "0x14CBDE4", Offset = "0x14CBDE4", VA = "0x7BBBCCBDE4", Slot = "13")]
		protected override void CloseHUDMask()
		{
		}

		// Token: 0x0600BAE5 RID: 47845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAE5")]
		[Address(RVA = "0x14CBDE8", Offset = "0x14CBDE8", VA = "0x7BBBCCBDE8")]
		public UIMultBountyWaitingScene()
		{
		}

		// Token: 0x0400BC29 RID: 48169
		[Token(Token = "0x400BC29")]
		[FieldOffset(Offset = "0x3D0")]
		private |l\u007Fz\u0081JY m_CurState;

		// Token: 0x0400BC2A RID: 48170
		[Token(Token = "0x400BC2A")]
		[FieldOffset(Offset = "0x3D8")]
		private BountyRepairingRankController m_RankController;

		// Token: 0x0400BC2B RID: 48171
		[Token(Token = "0x400BC2B")]
		[FieldOffset(Offset = "0x3E0")]
		private BountyRepairingProgressController m_ProgressController;

		// Token: 0x0400BC2C RID: 48172
		[Token(Token = "0x400BC2C")]
		[FieldOffset(Offset = "0x3E8")]
		private UIHudPopupController m_TipUI;
	}
}
