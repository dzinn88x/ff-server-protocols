using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001E0F RID: 7695
	[Token(Token = "0x2001E0F")]
	public class VehicleSkinBaseInfo : CollectionBaseInfo, IComparable<VehicleSkinBaseInfo>
	{
		// Token: 0x0600A848 RID: 43080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A848")]
		[Address(RVA = "0x1798CF8", Offset = "0x1798CF8", VA = "0x7BBBF98CF8")]
		public VehicleSkinBaseInfo()
		{
		}

		// Token: 0x0600A849 RID: 43081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A849")]
		[Address(RVA = "0x1798D00", Offset = "0x1798D00", VA = "0x7BBBF98D00")]
		public VehicleSkinBaseInfo(uint itemid)
		{
		}

		// Token: 0x0600A84A RID: 43082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A84A")]
		[Address(RVA = "0x1798F68", Offset = "0x1798F68", VA = "0x7BBBF98F68")]
		public static implicit operator VehicleSkinBaseInfo(Item it)
		{
			return null;
		}

		// Token: 0x0600A84B RID: 43083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A84B")]
		[Address(RVA = "0x1798FD8", Offset = "0x1798FD8", VA = "0x7BBBF98FD8")]
		public static implicit operator VehicleSkinBaseInfo(VehicleSkinData data)
		{
			return null;
		}

		// Token: 0x0600A84C RID: 43084 RVA: 0x0002D810 File Offset: 0x0002BA10
		[Token(Token = "0x600A84C")]
		[Address(RVA = "0x1799048", Offset = "0x1799048", VA = "0x7BBBF99048", Slot = "5")]
		public override uint GetCurrentId()
		{
			return 0U;
		}

		// Token: 0x0600A84D RID: 43085 RVA: 0x0002D828 File Offset: 0x0002BA28
		[Token(Token = "0x600A84D")]
		[Address(RVA = "0x1799124", Offset = "0x1799124", VA = "0x7BBBF99124", Slot = "6")]
		public int CompareTo(VehicleSkinBaseInfo other)
		{
			return 0;
		}

		// Token: 0x0400ADB3 RID: 44467
		[Token(Token = "0x400ADB3")]
		[FieldOffset(Offset = "0x38")]
		public VehicleSkinData vehicle_skin_data;

		// Token: 0x0400ADB4 RID: 44468
		[Token(Token = "0x400ADB4")]
		[FieldOffset(Offset = "0x40")]
		public uint vehicle_id;
	}
}
