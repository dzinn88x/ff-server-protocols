using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200208D RID: 8333
	[Token(Token = "0x200208D")]
	internal class UITDMGameScene : UITeamModeBaseGameScene
	{
		// Token: 0x0600BB07 RID: 47879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB07")]
		[Address(RVA = "0x1F4FD98", Offset = "0x1F4FD98", VA = "0x7BBC74FD98", Slot = "27")]
		protected override void OnOpenHudBeginFight()
		{
		}

		// Token: 0x0600BB08 RID: 47880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB08")]
		[Address(RVA = "0x1F4FDDC", Offset = "0x1F4FDDC", VA = "0x7BBC74FDDC", Slot = "10")]
		public override void RegisterGameEventHandler()
		{
		}

		// Token: 0x0600BB09 RID: 47881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB09")]
		[Address(RVA = "0x1F50024", Offset = "0x1F50024", VA = "0x7BBC750024", Slot = "9")]
		protected override void OnDestory()
		{
		}

		// Token: 0x0600BB0A RID: 47882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BB0A")]
		[Address(RVA = "0x1F5026C", Offset = "0x1F5026C", VA = "0x7BBC75026C", Slot = "14")]
		protected override Type GetMatchResultType()
		{
			return null;
		}

		// Token: 0x0600BB0B RID: 47883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB0B")]
		[Address(RVA = "0x1F502DC", Offset = "0x1F502DC", VA = "0x7BBC7502DC")]
		public UITDMGameScene()
		{
		}

		// Token: 0x0400BC35 RID: 48181
		[Token(Token = "0x400BC35")]
		[FieldOffset(Offset = "0x3E8")]
		private UIHudGameShowInfoController m_ShowInfoCtrl;
	}
}
