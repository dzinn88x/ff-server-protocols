using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001314 RID: 4884
	[Token(Token = "0x2001314")]
	internal class SparkEventData_Revived : SparkEventData_Base
	{
		// Token: 0x06004D69 RID: 19817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D69")]
		[Address(RVA = "0x1B3BAE8", Offset = "0x1B3BAE8", VA = "0x7BBC33BAE8", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D6A RID: 19818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D6A")]
		[Address(RVA = "0x1B3BB30", Offset = "0x1B3BB30", VA = "0x7BBC33BB30")]
		public SparkEventData_Revived()
		{
		}

		// Token: 0x04007516 RID: 29974
		[Token(Token = "0x4007516")]
		[FieldOffset(Offset = "0x18")]
		public ulong from_account_id;
	}
}
