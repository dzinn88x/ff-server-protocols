using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010AB RID: 4267
	[Token(Token = "0x20010AB")]
	public class ClothEffectData : CSVBaseData, IGetId
	{
		// Token: 0x06004295 RID: 17045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004295")]
		[Address(RVA = "0x14FA640", Offset = "0x14FA640", VA = "0x7BBBCFA640", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004296 RID: 17046 RVA: 0x00014898 File Offset: 0x00012A98
		[Token(Token = "0x6004296")]
		[Address(RVA = "0x14FA64C", Offset = "0x14FA64C", VA = "0x7BBBCFA64C", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004297")]
		[Address(RVA = "0x14FA654", Offset = "0x14FA654", VA = "0x7BBBCFA654", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004298")]
		[Address(RVA = "0x14FA754", Offset = "0x14FA754", VA = "0x7BBBCFA754")]
		public ClothEffectData()
		{
		}

		// Token: 0x0400519D RID: 20893
		[Token(Token = "0x400519D")]
		[FieldOffset(Offset = "0x10")]
		public uint quality;

		// Token: 0x0400519E RID: 20894
		[Token(Token = "0x400519E")]
		[FieldOffset(Offset = "0x14")]
		public uint effectMyCloth;

		// Token: 0x0400519F RID: 20895
		[Token(Token = "0x400519F")]
		[FieldOffset(Offset = "0x18")]
		public uint effectTeammateCloth;

		// Token: 0x040051A0 RID: 20896
		[Token(Token = "0x40051A0")]
		[FieldOffset(Offset = "0x1C")]
		public uint effectEnemyCloth;
	}
}
