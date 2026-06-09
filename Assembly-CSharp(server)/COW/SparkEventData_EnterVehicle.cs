using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200131A RID: 4890
	[Token(Token = "0x200131A")]
	internal class SparkEventData_EnterVehicle : SparkEventData_Base
	{
		// Token: 0x06004D75 RID: 19829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D75")]
		[Address(RVA = "0x1B3B6D8", Offset = "0x1B3B6D8", VA = "0x7BBC33B6D8", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D76 RID: 19830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D76")]
		[Address(RVA = "0x1B3B720", Offset = "0x1B3B720", VA = "0x7BBC33B720")]
		public SparkEventData_EnterVehicle()
		{
		}

		// Token: 0x0400751D RID: 29981
		[Token(Token = "0x400751D")]
		[FieldOffset(Offset = "0x18")]
		public int vehicle_id;

		// Token: 0x0400751E RID: 29982
		[Token(Token = "0x400751E")]
		[FieldOffset(Offset = "0x1C")]
		public int vehicle_hp;
	}
}
