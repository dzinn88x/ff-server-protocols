using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200110A RID: 4362
	[Token(Token = "0x200110A")]
	public class HeroicMarkData : CSVBaseData
	{
		// Token: 0x06004421 RID: 17441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004421")]
		[Address(RVA = "0x18589D8", Offset = "0x18589D8", VA = "0x7BBC0589D8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004422 RID: 17442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004422")]
		[Address(RVA = "0x1858A0C", Offset = "0x1858A0C", VA = "0x7BBC058A0C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004423")]
		[Address(RVA = "0x1858E4C", Offset = "0x1858E4C", VA = "0x7BBC058E4C")]
		public HeroicMarkData()
		{
		}

		// Token: 0x04005428 RID: 21544
		[Token(Token = "0x4005428")]
		[FieldOffset(Offset = "0x10")]
		public uint Level;

		// Token: 0x04005429 RID: 21545
		[Token(Token = "0x4005429")]
		[FieldOffset(Offset = "0x14")]
		public EHeroicMarkType MarkType;

		// Token: 0x0400542A RID: 21546
		[Token(Token = "0x400542A")]
		[FieldOffset(Offset = "0x18")]
		public ResourceID IconRes;

		// Token: 0x0400542B RID: 21547
		[Token(Token = "0x400542B")]
		[FieldOffset(Offset = "0x1C")]
		public ResourceID BigIconRes;

		// Token: 0x0400542C RID: 21548
		[Token(Token = "0x400542C")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID VfxRes;

		// Token: 0x0400542D RID: 21549
		[Token(Token = "0x400542D")]
		[FieldOffset(Offset = "0x24")]
		public ResourceID VfxResSmall;
	}
}
