using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001D5E RID: 7518
	[Token(Token = "0x2001D5E")]
	public class AnnoucementInfo : IComparable<AnnoucementInfo>
	{
		// Token: 0x0600A3EE RID: 41966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3EE")]
		[Address(RVA = "0x154D304", Offset = "0x154D304", VA = "0x7BBBD4D304")]
		public AnnoucementInfo()
		{
		}

		// Token: 0x0600A3EF RID: 41967 RVA: 0x0002B638 File Offset: 0x00029838
		[Token(Token = "0x600A3EF")]
		[Address(RVA = "0x154D374", Offset = "0x154D374", VA = "0x7BBBD4D374", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A3F0 RID: 41968 RVA: 0x0002B650 File Offset: 0x00029850
		[Token(Token = "0x600A3F0")]
		[Address(RVA = "0x154D37C", Offset = "0x154D37C", VA = "0x7BBBD4D37C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600A3F1 RID: 41969 RVA: 0x0002B668 File Offset: 0x00029868
		[Token(Token = "0x600A3F1")]
		[Address(RVA = "0x154D464", Offset = "0x154D464", VA = "0x7BBBD4D464", Slot = "4")]
		public int CompareTo(AnnoucementInfo other)
		{
			return 0;
		}

		// Token: 0x0600A3F2 RID: 41970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A3F2")]
		[Address(RVA = "0x154D5D0", Offset = "0x154D5D0", VA = "0x7BBBD4D5D0")]
		public static implicit operator AnnoucementInfo(AnnouncementDesc data)
		{
			return null;
		}

		// Token: 0x0600A3F3 RID: 41971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A3F3")]
		[Address(RVA = "0x154D640", Offset = "0x154D640", VA = "0x7BBBD4D640")]
		public static implicit operator AnnoucementInfo(AnnouncementCSVData data)
		{
			return null;
		}

		// Token: 0x0400AA01 RID: 43521
		[Token(Token = "0x400AA01")]
		[FieldOffset(Offset = "0x10")]
		public AnnouncementDesc Data;

		// Token: 0x0400AA02 RID: 43522
		[Token(Token = "0x400AA02")]
		[FieldOffset(Offset = "0x18")]
		public EEventTag EventTagType;
	}
}
