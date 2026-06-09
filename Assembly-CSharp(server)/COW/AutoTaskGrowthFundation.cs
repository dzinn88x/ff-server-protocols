using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001332 RID: 4914
	[Token(Token = "0x2001332")]
	public class AutoTaskGrowthFundation : AutoPopupTask
	{
		// Token: 0x06004DE9 RID: 19945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DE9")]
		[Address(RVA = "0x15595BC", Offset = "0x15595BC", VA = "0x7BBBD595BC", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004DEA RID: 19946 RVA: 0x00017A30 File Offset: 0x00015C30
		[Token(Token = "0x6004DEA")]
		[Address(RVA = "0x15595C4", Offset = "0x15595C4", VA = "0x7BBBD595C4", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004DEB RID: 19947 RVA: 0x00017A48 File Offset: 0x00015C48
		[Token(Token = "0x6004DEB")]
		[Address(RVA = "0x1559DE0", Offset = "0x1559DE0", VA = "0x7BBBD59DE0", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004DEC RID: 19948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DEC")]
		[Address(RVA = "0x1559E80", Offset = "0x1559E80", VA = "0x7BBBD59E80")]
		public AutoTaskGrowthFundation()
		{
		}

		// Token: 0x04007548 RID: 30024
		[Token(Token = "0x4007548")]
		[FieldOffset(Offset = "0x10")]
		private UIGrowthFundAdController m_GrowthFundationUI;
	}
}
