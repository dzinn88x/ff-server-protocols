using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200130A RID: 4874
	[Token(Token = "0x200130A")]
	internal class SparkEventData_GameEnd : SparkEventData_Base
	{
		// Token: 0x06004D55 RID: 19797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D55")]
		[Address(RVA = "0x1B3B778", Offset = "0x1B3B778", VA = "0x7BBC33B778", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D56 RID: 19798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D56")]
		[Address(RVA = "0x1B3B7C0", Offset = "0x1B3B7C0", VA = "0x7BBC33B7C0")]
		public SparkEventData_GameEnd()
		{
		}

		// Token: 0x04007502 RID: 29954
		[Token(Token = "0x4007502")]
		[FieldOffset(Offset = "0x18")]
		public int reason;

		// Token: 0x04007503 RID: 29955
		[Token(Token = "0x4007503")]
		[FieldOffset(Offset = "0x1C")]
		public uint kills;

		// Token: 0x04007504 RID: 29956
		[Token(Token = "0x4007504")]
		[FieldOffset(Offset = "0x20")]
		public uint rank;
	}
}
