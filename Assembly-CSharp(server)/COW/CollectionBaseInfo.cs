using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001E07 RID: 7687
	[Token(Token = "0x2001E07")]
	public class CollectionBaseInfo : IComparable<CollectionBaseInfo>
	{
		// Token: 0x0600A81D RID: 43037 RVA: 0x0002D6C0 File Offset: 0x0002B8C0
		[Token(Token = "0x600A81D")]
		[Address(RVA = "0x14FAD6C", Offset = "0x14FAD6C", VA = "0x7BBBCFAD6C", Slot = "5")]
		public virtual uint GetCurrentId()
		{
			return 0U;
		}

		// Token: 0x0600A81E RID: 43038 RVA: 0x0002D6D8 File Offset: 0x0002B8D8
		[Token(Token = "0x600A81E")]
		[Address(RVA = "0x14FAD74", Offset = "0x14FAD74", VA = "0x7BBBCFAD74", Slot = "4")]
		public int CompareTo(CollectionBaseInfo other)
		{
			return 0;
		}

		// Token: 0x0600A81F RID: 43039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A81F")]
		[Address(RVA = "0x14FAED0", Offset = "0x14FAED0", VA = "0x7BBBCFAED0")]
		public CollectionBaseInfo()
		{
		}

		// Token: 0x0400ADA4 RID: 44452
		[Token(Token = "0x400ADA4")]
		[FieldOffset(Offset = "0x10")]
		public uint id;

		// Token: 0x0400ADA5 RID: 44453
		[Token(Token = "0x400ADA5")]
		[FieldOffset(Offset = "0x14")]
		public uint sort_id;

		// Token: 0x0400ADA6 RID: 44454
		[Token(Token = "0x400ADA6")]
		[FieldOffset(Offset = "0x18")]
		public bool is_default;

		// Token: 0x0400ADA7 RID: 44455
		[Token(Token = "0x400ADA7")]
		[FieldOffset(Offset = "0x19")]
		public bool is_owned;

		// Token: 0x0400ADA8 RID: 44456
		[Token(Token = "0x400ADA8")]
		[FieldOffset(Offset = "0x20")]
		public Item item;

		// Token: 0x0400ADA9 RID: 44457
		[Token(Token = "0x400ADA9")]
		[FieldOffset(Offset = "0x28")]
		public CSSharedItemData item_data;

		// Token: 0x0400ADAA RID: 44458
		[Token(Token = "0x400ADAA")]
		[FieldOffset(Offset = "0x30")]
		public bool is_withEffect;
	}
}
