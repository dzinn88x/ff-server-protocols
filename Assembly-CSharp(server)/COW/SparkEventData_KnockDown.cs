using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001310 RID: 4880
	[Token(Token = "0x2001310")]
	internal class SparkEventData_KnockDown : SparkEventData_Base
	{
		// Token: 0x06004D61 RID: 19809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D61")]
		[Address(RVA = "0x1B3B868", Offset = "0x1B3B868", VA = "0x7BBC33B868", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D62 RID: 19810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D62")]
		[Address(RVA = "0x1B3B8B0", Offset = "0x1B3B8B0", VA = "0x7BBC33B8B0")]
		public SparkEventData_KnockDown()
		{
		}

		// Token: 0x0400750F RID: 29967
		[Token(Token = "0x400750F")]
		[FieldOffset(Offset = "0x18")]
		public ulong account_id;

		// Token: 0x04007510 RID: 29968
		[Token(Token = "0x4007510")]
		[FieldOffset(Offset = "0x20")]
		public int weapon_id;
	}
}
