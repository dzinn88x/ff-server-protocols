using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200130F RID: 4879
	[Token(Token = "0x200130F")]
	internal class SparkEventData_Kill : SparkEventData_Base
	{
		// Token: 0x06004D5F RID: 19807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5F")]
		[Address(RVA = "0x1B3B818", Offset = "0x1B3B818", VA = "0x7BBC33B818", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D60 RID: 19808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D60")]
		[Address(RVA = "0x1B3B860", Offset = "0x1B3B860", VA = "0x7BBC33B860")]
		public SparkEventData_Kill()
		{
		}

		// Token: 0x0400750C RID: 29964
		[Token(Token = "0x400750C")]
		[FieldOffset(Offset = "0x18")]
		public ulong account_id;

		// Token: 0x0400750D RID: 29965
		[Token(Token = "0x400750D")]
		[FieldOffset(Offset = "0x20")]
		public int weapon_id;

		// Token: 0x0400750E RID: 29966
		[Token(Token = "0x400750E")]
		[FieldOffset(Offset = "0x24")]
		public int kill_count;
	}
}
