using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001313 RID: 4883
	[Token(Token = "0x2001313")]
	internal class SparkEventData_KnockedDown : SparkEventData_Base
	{
		// Token: 0x06004D67 RID: 19815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D67")]
		[Address(RVA = "0x1B3B8B8", Offset = "0x1B3B8B8", VA = "0x7BBC33B8B8", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D68 RID: 19816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D68")]
		[Address(RVA = "0x1B3B900", Offset = "0x1B3B900", VA = "0x7BBC33B900")]
		public SparkEventData_KnockedDown()
		{
		}

		// Token: 0x04007514 RID: 29972
		[Token(Token = "0x4007514")]
		[FieldOffset(Offset = "0x18")]
		public ulong from_account_id;

		// Token: 0x04007515 RID: 29973
		[Token(Token = "0x4007515")]
		[FieldOffset(Offset = "0x20")]
		public int weapon_id;
	}
}
