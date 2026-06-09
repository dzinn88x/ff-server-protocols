using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AAA RID: 6826
	[Token(Token = "0x2001AAA")]
	internal class OBPlayerState_Base
	{
		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06008FF3 RID: 36851 RVA: 0x00026598 File Offset: 0x00024798
		[Token(Token = "0x170009F0")]
		public virtual EOBPlayerStateType StateType
		{
			[Token(Token = "0x6008FF3")]
			[Address(RVA = "0x1A66B38", Offset = "0x1A66B38", VA = "0x7BBC266B38", Slot = "4")]
			get
			{
				return EOBPlayerStateType.eNone;
			}
		}

		// Token: 0x06008FF4 RID: 36852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FF4")]
		[Address(RVA = "0x1A66B40", Offset = "0x1A66B40", VA = "0x7BBC266B40", Slot = "5")]
		public virtual void EnterState(EOBPlayerStateType next_state_type)
		{
		}

		// Token: 0x06008FF5 RID: 36853 RVA: 0x000265B0 File Offset: 0x000247B0
		[Token(Token = "0x6008FF5")]
		[Address(RVA = "0x1A66B44", Offset = "0x1A66B44", VA = "0x7BBC266B44", Slot = "6")]
		public virtual bool ExitState(EOBPlayerStateType next_state_type)
		{
			return default(bool);
		}

		// Token: 0x06008FF6 RID: 36854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FF6")]
		[Address(RVA = "0x1A668C0", Offset = "0x1A668C0", VA = "0x7BBC2668C0")]
		public OBPlayerState_Base(UIOBPlayerNamePlateView view)
		{
		}

		// Token: 0x06008FF7 RID: 36855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FF7")]
		[Address(RVA = "0x1A66B2C", Offset = "0x1A66B2C", VA = "0x7BBC266B2C", Slot = "7")]
		public virtual void IsShowTeamIcon(bool show)
		{
		}

		// Token: 0x04009BEA RID: 39914
		[Token(Token = "0x4009BEA")]
		[FieldOffset(Offset = "0x10")]
		protected UIOBPlayerNamePlateView m_OwnedView;

		// Token: 0x04009BEB RID: 39915
		[Token(Token = "0x4009BEB")]
		[FieldOffset(Offset = "0x18")]
		public bool m_IsShowTeamIcon;
	}
}
