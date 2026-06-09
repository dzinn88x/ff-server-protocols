using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001E0B RID: 7691
	[Token(Token = "0x2001E0B")]
	public class SkyboardBaseInfo : CollectionBaseInfo, IComparable<SkyboardBaseInfo>
	{
		// Token: 0x0600A832 RID: 43058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A832")]
		[Address(RVA = "0x1B39258", Offset = "0x1B39258", VA = "0x7BBC339258")]
		public SkyboardBaseInfo()
		{
		}

		// Token: 0x0600A833 RID: 43059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A833")]
		[Address(RVA = "0x1B39260", Offset = "0x1B39260", VA = "0x7BBC339260")]
		public SkyboardBaseInfo(uint itemid)
		{
		}

		// Token: 0x0600A834 RID: 43060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A834")]
		[Address(RVA = "0x1B394B8", Offset = "0x1B394B8", VA = "0x7BBC3394B8")]
		public static implicit operator SkyboardBaseInfo(Item it)
		{
			return null;
		}

		// Token: 0x0600A835 RID: 43061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A835")]
		[Address(RVA = "0x1B39528", Offset = "0x1B39528", VA = "0x7BBC339528")]
		public static implicit operator SkyboardBaseInfo(SkyboardData data)
		{
			return null;
		}

		// Token: 0x0600A836 RID: 43062 RVA: 0x0002D780 File Offset: 0x0002B980
		[Token(Token = "0x600A836")]
		[Address(RVA = "0x1B39598", Offset = "0x1B39598", VA = "0x7BBC339598", Slot = "5")]
		public override uint GetCurrentId()
		{
			return 0U;
		}

		// Token: 0x0600A837 RID: 43063 RVA: 0x0002D798 File Offset: 0x0002B998
		[Token(Token = "0x600A837")]
		[Address(RVA = "0x1B3964C", Offset = "0x1B3964C", VA = "0x7BBC33964C", Slot = "6")]
		public int CompareTo(SkyboardBaseInfo other)
		{
			return 0;
		}

		// Token: 0x0400ADAE RID: 44462
		[Token(Token = "0x400ADAE")]
		[FieldOffset(Offset = "0x38")]
		public SkyboardData skyboard_data;
	}
}
