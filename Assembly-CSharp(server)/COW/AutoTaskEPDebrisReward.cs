using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x0200132E RID: 4910
	[Token(Token = "0x200132E")]
	public class AutoTaskEPDebrisReward : AutoPopupTask
	{
		// Token: 0x06004DD9 RID: 19929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD9")]
		[Address(RVA = "0x1558AEC", Offset = "0x1558AEC", VA = "0x7BBBD58AEC", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004DDA RID: 19930 RVA: 0x00017970 File Offset: 0x00015B70
		[Token(Token = "0x6004DDA")]
		[Address(RVA = "0x1558B6C", Offset = "0x1558B6C", VA = "0x7BBBD58B6C", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004DDB RID: 19931 RVA: 0x00017988 File Offset: 0x00015B88
		[Token(Token = "0x6004DDB")]
		[Address(RVA = "0x1558D7C", Offset = "0x1558D7C", VA = "0x7BBBD58D7C", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004DDC RID: 19932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DDC")]
		[Address(RVA = "0x1558E1C", Offset = "0x1558E1C", VA = "0x7BBBD58E1C")]
		public AutoTaskEPDebrisReward()
		{
		}

		// Token: 0x04007544 RID: 30020
		[Token(Token = "0x4007544")]
		[FieldOffset(Offset = "0x10")]
		private UIEPDebrisRewardController m_EPDebrisRewardUI;
	}
}
