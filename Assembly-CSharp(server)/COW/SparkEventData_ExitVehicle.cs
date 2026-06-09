using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200131B RID: 4891
	[Token(Token = "0x200131B")]
	internal class SparkEventData_ExitVehicle : SparkEventData_Base
	{
		// Token: 0x06004D77 RID: 19831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D77")]
		[Address(RVA = "0x1B3B728", Offset = "0x1B3B728", VA = "0x7BBC33B728", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D78")]
		[Address(RVA = "0x1B3B770", Offset = "0x1B3B770", VA = "0x7BBC33B770")]
		public SparkEventData_ExitVehicle()
		{
		}

		// Token: 0x0400751F RID: 29983
		[Token(Token = "0x400751F")]
		[FieldOffset(Offset = "0x18")]
		public int vehicle_id;

		// Token: 0x04007520 RID: 29984
		[Token(Token = "0x4007520")]
		[FieldOffset(Offset = "0x1C")]
		public int vehicle_hp;
	}
}
