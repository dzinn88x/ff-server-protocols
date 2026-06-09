using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001315 RID: 4885
	[Token(Token = "0x2001315")]
	internal class SparkEventData_PickUpItem : SparkEventData_Base
	{
		// Token: 0x06004D6B RID: 19819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D6B")]
		[Address(RVA = "0x1B3B9F8", Offset = "0x1B3B9F8", VA = "0x7BBC33B9F8", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D6C RID: 19820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D6C")]
		[Address(RVA = "0x1B3BA40", Offset = "0x1B3BA40", VA = "0x7BBC33BA40")]
		public SparkEventData_PickUpItem()
		{
		}

		// Token: 0x04007517 RID: 29975
		[Token(Token = "0x4007517")]
		[FieldOffset(Offset = "0x18")]
		public uint item_id;

		// Token: 0x04007518 RID: 29976
		[Token(Token = "0x4007518")]
		[FieldOffset(Offset = "0x1C")]
		public uint skin_id;
	}
}
