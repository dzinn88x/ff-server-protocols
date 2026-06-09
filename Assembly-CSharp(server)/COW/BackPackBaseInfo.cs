using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001E09 RID: 7689
	[Token(Token = "0x2001E09")]
	public class BackPackBaseInfo : CollectionBaseInfo, IComparable<BackPackBaseInfo>
	{
		// Token: 0x0600A826 RID: 43046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A826")]
		[Address(RVA = "0x21CB300", Offset = "0x21CB300", VA = "0x7BBC9CB300")]
		public BackPackBaseInfo()
		{
		}

		// Token: 0x0600A827 RID: 43047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A827")]
		[Address(RVA = "0x21CB308", Offset = "0x21CB308", VA = "0x7BBC9CB308")]
		public BackPackBaseInfo(uint backpackId)
		{
		}

		// Token: 0x0600A828 RID: 43048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A828")]
		[Address(RVA = "0x21CB560", Offset = "0x21CB560", VA = "0x7BBC9CB560")]
		public static implicit operator BackPackBaseInfo(Item it)
		{
			return null;
		}

		// Token: 0x0600A829 RID: 43049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A829")]
		[Address(RVA = "0x21CB5D0", Offset = "0x21CB5D0", VA = "0x7BBC9CB5D0")]
		public static implicit operator BackPackBaseInfo(BackPackData backpack)
		{
			return null;
		}

		// Token: 0x0600A82A RID: 43050 RVA: 0x0002D720 File Offset: 0x0002B920
		[Token(Token = "0x600A82A")]
		[Address(RVA = "0x21CB640", Offset = "0x21CB640", VA = "0x7BBC9CB640", Slot = "5")]
		public override uint GetCurrentId()
		{
			return 0U;
		}

		// Token: 0x0600A82B RID: 43051 RVA: 0x0002D738 File Offset: 0x0002B938
		[Token(Token = "0x600A82B")]
		[Address(RVA = "0x21CB6F4", Offset = "0x21CB6F4", VA = "0x7BBC9CB6F4", Slot = "6")]
		public int CompareTo(BackPackBaseInfo other)
		{
			return 0;
		}

		// Token: 0x0400ADAC RID: 44460
		[Token(Token = "0x400ADAC")]
		[FieldOffset(Offset = "0x38")]
		public BackPackData backpack_data;
	}
}
