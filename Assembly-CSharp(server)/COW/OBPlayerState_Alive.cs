using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AAB RID: 6827
	[Token(Token = "0x2001AAB")]
	internal class OBPlayerState_Alive : OBPlayerState_Base
	{
		// Token: 0x06008FF8 RID: 36856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FF8")]
		[Address(RVA = "0x1A66894", Offset = "0x1A66894", VA = "0x7BBC266894")]
		public OBPlayerState_Alive(UIOBPlayerNamePlateView view)
		{
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06008FF9 RID: 36857 RVA: 0x000265C8 File Offset: 0x000247C8
		[Token(Token = "0x170009F1")]
		public override EOBPlayerStateType StateType
		{
			[Token(Token = "0x6008FF9")]
			[Address(RVA = "0x1A668EC", Offset = "0x1A668EC", VA = "0x7BBC2668EC", Slot = "4")]
			get
			{
				return EOBPlayerStateType.eNone;
			}
		}

		// Token: 0x06008FFA RID: 36858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FFA")]
		[Address(RVA = "0x1A668F4", Offset = "0x1A668F4", VA = "0x7BBC2668F4", Slot = "5")]
		public override void EnterState(EOBPlayerStateType next_state_type)
		{
		}

		// Token: 0x06008FFB RID: 36859 RVA: 0x000265E0 File Offset: 0x000247E0
		[Token(Token = "0x6008FFB")]
		[Address(RVA = "0x1A669B4", Offset = "0x1A669B4", VA = "0x7BBC2669B4", Slot = "6")]
		public override bool ExitState(EOBPlayerStateType next_state_type)
		{
			return default(bool);
		}

		// Token: 0x06008FFC RID: 36860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FFC")]
		[Address(RVA = "0x1A66A64", Offset = "0x1A66A64", VA = "0x7BBC266A64", Slot = "7")]
		public override void IsShowTeamIcon(bool show)
		{
		}
	}
}
