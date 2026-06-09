using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200112A RID: 4394
	[Token(Token = "0x200112A")]
	public class LinkMvpScoreData : CSVBaseData
	{
		// Token: 0x060044AE RID: 17582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044AE")]
		[Address(RVA = "0x1404C8C", Offset = "0x1404C8C", VA = "0x7BBBC04C8C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060044AF RID: 17583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044AF")]
		[Address(RVA = "0x1404C98", Offset = "0x1404C98", VA = "0x7BBBC04C98", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044B0")]
		[Address(RVA = "0x1404D98", Offset = "0x1404D98", VA = "0x7BBBC04D98")]
		public static string GetEvaluation(int score)
		{
			return null;
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B1")]
		[Address(RVA = "0x1404FD8", Offset = "0x1404FD8", VA = "0x7BBBC04FD8")]
		public LinkMvpScoreData()
		{
		}

		// Token: 0x040054DC RID: 21724
		[Token(Token = "0x40054DC")]
		[FieldOffset(Offset = "0x10")]
		public uint Id;

		// Token: 0x040054DD RID: 21725
		[Token(Token = "0x40054DD")]
		[FieldOffset(Offset = "0x14")]
		public int MinScore;

		// Token: 0x040054DE RID: 21726
		[Token(Token = "0x40054DE")]
		[FieldOffset(Offset = "0x18")]
		public int MaxScore;

		// Token: 0x040054DF RID: 21727
		[Token(Token = "0x40054DF")]
		[FieldOffset(Offset = "0x20")]
		public string Evaluation;
	}
}
