using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001311 RID: 4881
	[Token(Token = "0x2001311")]
	internal class SparkEventData_Revive : SparkEventData_Base
	{
		// Token: 0x06004D63 RID: 19811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D63")]
		[Address(RVA = "0x1B3BA98", Offset = "0x1B3BA98", VA = "0x7BBC33BA98", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D64 RID: 19812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D64")]
		[Address(RVA = "0x1B3BAE0", Offset = "0x1B3BAE0", VA = "0x7BBC33BAE0")]
		public SparkEventData_Revive()
		{
		}

		// Token: 0x04007511 RID: 29969
		[Token(Token = "0x4007511")]
		[FieldOffset(Offset = "0x18")]
		public ulong account_id;
	}
}
