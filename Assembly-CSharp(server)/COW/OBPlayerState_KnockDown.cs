using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AAC RID: 6828
	[Token(Token = "0x2001AAC")]
	internal class OBPlayerState_KnockDown : OBPlayerState_Base
	{
		// Token: 0x06008FFD RID: 36861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FFD")]
		[Address(RVA = "0x1A66C4C", Offset = "0x1A66C4C", VA = "0x7BBC266C4C")]
		public OBPlayerState_KnockDown(UIOBPlayerNamePlateView view)
		{
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06008FFE RID: 36862 RVA: 0x000265F8 File Offset: 0x000247F8
		[Token(Token = "0x170009F2")]
		public override EOBPlayerStateType StateType
		{
			[Token(Token = "0x6008FFE")]
			[Address(RVA = "0x1A66C78", Offset = "0x1A66C78", VA = "0x7BBC266C78", Slot = "4")]
			get
			{
				return EOBPlayerStateType.eNone;
			}
		}

		// Token: 0x06008FFF RID: 36863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FFF")]
		[Address(RVA = "0x1A66C80", Offset = "0x1A66C80", VA = "0x7BBC266C80", Slot = "5")]
		public override void EnterState(EOBPlayerStateType next_state_type)
		{
		}

		// Token: 0x06009000 RID: 36864 RVA: 0x00026610 File Offset: 0x00024810
		[Token(Token = "0x6009000")]
		[Address(RVA = "0x1A66CDC", Offset = "0x1A66CDC", VA = "0x7BBC266CDC", Slot = "6")]
		public override bool ExitState(EOBPlayerStateType next_state_type)
		{
			return default(bool);
		}
	}
}
