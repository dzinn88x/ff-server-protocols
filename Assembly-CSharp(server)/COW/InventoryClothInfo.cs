using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001ED4 RID: 7892
	[Token(Token = "0x2001ED4")]
	public class InventoryClothInfo : InventoryItemInfo, IComparable<InventoryClothInfo>
	{
		// Token: 0x0600AD3E RID: 44350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD3E")]
		[Address(RVA = "0x13F2C08", Offset = "0x13F2C08", VA = "0x7BBBBF2C08")]
		public InventoryClothInfo(Item it)
		{
		}

		// Token: 0x0600AD3F RID: 44351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD3F")]
		[Address(RVA = "0x13F2E84", Offset = "0x13F2E84", VA = "0x7BBBBF2E84")]
		public new static implicit operator InventoryClothInfo(Item it)
		{
			return null;
		}

		// Token: 0x0600AD40 RID: 44352 RVA: 0x0002FEB0 File Offset: 0x0002E0B0
		[Token(Token = "0x600AD40")]
		[Address(RVA = "0x13F2EE4", Offset = "0x13F2EE4", VA = "0x7BBBBF2EE4", Slot = "5")]
		public int CompareTo(InventoryClothInfo other)
		{
			return 0;
		}

		// Token: 0x0400B18F RID: 45455
		[Token(Token = "0x400B18F")]
		[FieldOffset(Offset = "0x60")]
		public AvatarWardrobeData wardrobeData;
	}
}
