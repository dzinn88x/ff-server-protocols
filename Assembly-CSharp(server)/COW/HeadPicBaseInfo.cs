using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001E06 RID: 7686
	[Token(Token = "0x2001E06")]
	public class HeadPicBaseInfo : CollectionBaseInfo, IComparable<HeadPicBaseInfo>
	{
		// Token: 0x0600A817 RID: 43031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A817")]
		[Address(RVA = "0x18582B4", Offset = "0x18582B4", VA = "0x7BBC0582B4")]
		public HeadPicBaseInfo()
		{
		}

		// Token: 0x0600A818 RID: 43032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A818")]
		[Address(RVA = "0x18582BC", Offset = "0x18582BC", VA = "0x7BBC0582BC")]
		public HeadPicBaseInfo(uint headpicId)
		{
		}

		// Token: 0x0600A819 RID: 43033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A819")]
		[Address(RVA = "0x1858518", Offset = "0x1858518", VA = "0x7BBC058518")]
		public static implicit operator HeadPicBaseInfo(Item it)
		{
			return null;
		}

		// Token: 0x0600A81A RID: 43034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A81A")]
		[Address(RVA = "0x1858588", Offset = "0x1858588", VA = "0x7BBC058588")]
		public static implicit operator HeadPicBaseInfo(HeadPicData pd)
		{
			return null;
		}

		// Token: 0x0600A81B RID: 43035 RVA: 0x0002D690 File Offset: 0x0002B890
		[Token(Token = "0x600A81B")]
		[Address(RVA = "0x18585F8", Offset = "0x18585F8", VA = "0x7BBC0585F8", Slot = "5")]
		public override uint GetCurrentId()
		{
			return 0U;
		}

		// Token: 0x0600A81C RID: 43036 RVA: 0x0002D6A8 File Offset: 0x0002B8A8
		[Token(Token = "0x600A81C")]
		[Address(RVA = "0x18586AC", Offset = "0x18586AC", VA = "0x7BBC0586AC", Slot = "6")]
		public int CompareTo(HeadPicBaseInfo other)
		{
			return 0;
		}

		// Token: 0x0400ADA1 RID: 44449
		[Token(Token = "0x400ADA1")]
		[FieldOffset(Offset = "0x34")]
		public uint headpic_id;

		// Token: 0x0400ADA2 RID: 44450
		[Token(Token = "0x400ADA2")]
		[FieldOffset(Offset = "0x38")]
		public HeadPicData headpic_data;

		// Token: 0x0400ADA3 RID: 44451
		[Token(Token = "0x400ADA3")]
		[FieldOffset(Offset = "0x40")]
		public Item headpic_item;
	}
}
