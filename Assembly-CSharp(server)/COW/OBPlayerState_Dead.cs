using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AAD RID: 6829
	[Token(Token = "0x2001AAD")]
	internal class OBPlayerState_Dead : OBPlayerState_Base
	{
		// Token: 0x06009001 RID: 36865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009001")]
		[Address(RVA = "0x1A66B4C", Offset = "0x1A66B4C", VA = "0x7BBC266B4C")]
		public OBPlayerState_Dead(UIOBPlayerNamePlateView view)
		{
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06009002 RID: 36866 RVA: 0x00026628 File Offset: 0x00024828
		[Token(Token = "0x170009F3")]
		public override EOBPlayerStateType StateType
		{
			[Token(Token = "0x6009002")]
			[Address(RVA = "0x1A66B78", Offset = "0x1A66B78", VA = "0x7BBC266B78", Slot = "4")]
			get
			{
				return EOBPlayerStateType.eNone;
			}
		}

		// Token: 0x06009003 RID: 36867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009003")]
		[Address(RVA = "0x1A66B80", Offset = "0x1A66B80", VA = "0x7BBC266B80", Slot = "5")]
		public override void EnterState(EOBPlayerStateType next_state_type)
		{
		}

		// Token: 0x06009004 RID: 36868 RVA: 0x00026640 File Offset: 0x00024840
		[Token(Token = "0x6009004")]
		[Address(RVA = "0x1A66BDC", Offset = "0x1A66BDC", VA = "0x7BBC266BDC", Slot = "6")]
		public override bool ExitState(EOBPlayerStateType next_state)
		{
			return default(bool);
		}
	}
}
