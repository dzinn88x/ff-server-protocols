using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001312 RID: 4882
	[Token(Token = "0x2001312")]
	internal class SparkEventData_Death : SparkEventData_Base
	{
		// Token: 0x06004D65 RID: 19813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D65")]
		[Address(RVA = "0x1B3B638", Offset = "0x1B3B638", VA = "0x7BBC33B638", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D66 RID: 19814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D66")]
		[Address(RVA = "0x1B3B680", Offset = "0x1B3B680", VA = "0x7BBC33B680")]
		public SparkEventData_Death()
		{
		}

		// Token: 0x04007512 RID: 29970
		[Token(Token = "0x4007512")]
		[FieldOffset(Offset = "0x18")]
		public ulong from_account_id;

		// Token: 0x04007513 RID: 29971
		[Token(Token = "0x4007513")]
		[FieldOffset(Offset = "0x20")]
		public int weapon_id;
	}
}
