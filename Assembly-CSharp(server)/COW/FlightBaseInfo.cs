using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001E0C RID: 7692
	[Token(Token = "0x2001E0C")]
	public class FlightBaseInfo : CollectionBaseInfo, IComparable<FlightBaseInfo>
	{
		// Token: 0x0600A838 RID: 43064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A838")]
		[Address(RVA = "0x1B99900", Offset = "0x1B99900", VA = "0x7BBC399900")]
		public FlightBaseInfo()
		{
		}

		// Token: 0x0600A839 RID: 43065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A839")]
		[Address(RVA = "0x1B99908", Offset = "0x1B99908", VA = "0x7BBC399908")]
		public FlightBaseInfo(uint itemid)
		{
		}

		// Token: 0x0600A83A RID: 43066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A83A")]
		[Address(RVA = "0x1B99B60", Offset = "0x1B99B60", VA = "0x7BBC399B60")]
		public static implicit operator FlightBaseInfo(Item it)
		{
			return null;
		}

		// Token: 0x0600A83B RID: 43067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A83B")]
		[Address(RVA = "0x1B99BD0", Offset = "0x1B99BD0", VA = "0x7BBC399BD0")]
		public static implicit operator FlightBaseInfo(SkyboardData data)
		{
			return null;
		}

		// Token: 0x0600A83C RID: 43068 RVA: 0x0002D7B0 File Offset: 0x0002B9B0
		[Token(Token = "0x600A83C")]
		[Address(RVA = "0x1B99C40", Offset = "0x1B99C40", VA = "0x7BBC399C40", Slot = "5")]
		public override uint GetCurrentId()
		{
			return 0U;
		}

		// Token: 0x0600A83D RID: 43069 RVA: 0x0002D7C8 File Offset: 0x0002B9C8
		[Token(Token = "0x600A83D")]
		[Address(RVA = "0x1B99CF4", Offset = "0x1B99CF4", VA = "0x7BBC399CF4", Slot = "6")]
		public int CompareTo(FlightBaseInfo other)
		{
			return 0;
		}

		// Token: 0x0400ADAF RID: 44463
		[Token(Token = "0x400ADAF")]
		[FieldOffset(Offset = "0x38")]
		public FlightData flight_data;
	}
}
