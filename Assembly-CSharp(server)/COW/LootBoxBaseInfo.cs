using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001E08 RID: 7688
	[Token(Token = "0x2001E08")]
	public class LootBoxBaseInfo : CollectionBaseInfo, IComparable<LootBoxBaseInfo>
	{
		// Token: 0x0600A820 RID: 43040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A820")]
		[Address(RVA = "0x1A55070", Offset = "0x1A55070", VA = "0x7BBC255070")]
		public LootBoxBaseInfo()
		{
		}

		// Token: 0x0600A821 RID: 43041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A821")]
		[Address(RVA = "0x1A55078", Offset = "0x1A55078", VA = "0x7BBC255078")]
		public LootBoxBaseInfo(uint lootboxId)
		{
		}

		// Token: 0x0600A822 RID: 43042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A822")]
		[Address(RVA = "0x1A552D0", Offset = "0x1A552D0", VA = "0x7BBC2552D0")]
		public static implicit operator LootBoxBaseInfo(Item it)
		{
			return null;
		}

		// Token: 0x0600A823 RID: 43043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A823")]
		[Address(RVA = "0x1A55340", Offset = "0x1A55340", VA = "0x7BBC255340")]
		public static implicit operator LootBoxBaseInfo(LootBoxData box)
		{
			return null;
		}

		// Token: 0x0600A824 RID: 43044 RVA: 0x0002D6F0 File Offset: 0x0002B8F0
		[Token(Token = "0x600A824")]
		[Address(RVA = "0x1A553B0", Offset = "0x1A553B0", VA = "0x7BBC2553B0", Slot = "5")]
		public override uint GetCurrentId()
		{
			return 0U;
		}

		// Token: 0x0600A825 RID: 43045 RVA: 0x0002D708 File Offset: 0x0002B908
		[Token(Token = "0x600A825")]
		[Address(RVA = "0x1A55464", Offset = "0x1A55464", VA = "0x7BBC255464", Slot = "6")]
		public int CompareTo(LootBoxBaseInfo other)
		{
			return 0;
		}

		// Token: 0x0400ADAB RID: 44459
		[Token(Token = "0x400ADAB")]
		[FieldOffset(Offset = "0x38")]
		public LootBoxData lootbox_data;
	}
}
