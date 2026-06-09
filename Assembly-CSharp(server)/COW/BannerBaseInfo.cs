using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001E05 RID: 7685
	[Token(Token = "0x2001E05")]
	public class BannerBaseInfo : CollectionBaseInfo, IComparable<BannerBaseInfo>
	{
		// Token: 0x0600A811 RID: 43025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A811")]
		[Address(RVA = "0x21CD614", Offset = "0x21CD614", VA = "0x7BBC9CD614")]
		public BannerBaseInfo()
		{
		}

		// Token: 0x0600A812 RID: 43026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A812")]
		[Address(RVA = "0x21CD61C", Offset = "0x21CD61C", VA = "0x7BBC9CD61C")]
		public BannerBaseInfo(uint bannerId)
		{
		}

		// Token: 0x0600A813 RID: 43027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A813")]
		[Address(RVA = "0x21CD874", Offset = "0x21CD874", VA = "0x7BBC9CD874")]
		public static implicit operator BannerBaseInfo(Item it)
		{
			return null;
		}

		// Token: 0x0600A814 RID: 43028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A814")]
		[Address(RVA = "0x21CD8E4", Offset = "0x21CD8E4", VA = "0x7BBC9CD8E4")]
		public static implicit operator BannerBaseInfo(BannerData bd)
		{
			return null;
		}

		// Token: 0x0600A815 RID: 43029 RVA: 0x0002D660 File Offset: 0x0002B860
		[Token(Token = "0x600A815")]
		[Address(RVA = "0x21CD954", Offset = "0x21CD954", VA = "0x7BBC9CD954", Slot = "5")]
		public override uint GetCurrentId()
		{
			return 0U;
		}

		// Token: 0x0600A816 RID: 43030 RVA: 0x0002D678 File Offset: 0x0002B878
		[Token(Token = "0x600A816")]
		[Address(RVA = "0x21CDA08", Offset = "0x21CDA08", VA = "0x7BBC9CDA08", Slot = "6")]
		public int CompareTo(BannerBaseInfo other)
		{
			return 0;
		}

		// Token: 0x0400AD9E RID: 44446
		[Token(Token = "0x400AD9E")]
		[FieldOffset(Offset = "0x34")]
		public uint banner_id;

		// Token: 0x0400AD9F RID: 44447
		[Token(Token = "0x400AD9F")]
		[FieldOffset(Offset = "0x38")]
		public BannerData banner_data;

		// Token: 0x0400ADA0 RID: 44448
		[Token(Token = "0x400ADA0")]
		[FieldOffset(Offset = "0x40")]
		public Item banner_item;
	}
}
