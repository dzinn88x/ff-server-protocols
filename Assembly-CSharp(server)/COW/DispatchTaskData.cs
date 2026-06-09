using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010E0 RID: 4320
	[Token(Token = "0x20010E0")]
	public class DispatchTaskData : CSVBaseData
	{
		// Token: 0x06004369 RID: 17257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004369")]
		[Address(RVA = "0x1608D8C", Offset = "0x1608D8C", VA = "0x7BBBE08D8C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600436A RID: 17258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436A")]
		[Address(RVA = "0x1609148", Offset = "0x1609148", VA = "0x7BBBE09148", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600436B")]
		[Address(RVA = "0x1609154", Offset = "0x1609154", VA = "0x7BBBE09154")]
		public DispatchTaskData()
		{
		}

		// Token: 0x0400531F RID: 21279
		[Token(Token = "0x400531F")]
		[FieldOffset(Offset = "0x10")]
		public uint QuestLine;

		// Token: 0x04005320 RID: 21280
		[Token(Token = "0x4005320")]
		[FieldOffset(Offset = "0x14")]
		public uint QuestId;

		// Token: 0x04005321 RID: 21281
		[Token(Token = "0x4005321")]
		[FieldOffset(Offset = "0x18")]
		public uint IsRepeated;

		// Token: 0x04005322 RID: 21282
		[Token(Token = "0x4005322")]
		[FieldOffset(Offset = "0x20")]
		public string QuestName;

		// Token: 0x04005323 RID: 21283
		[Token(Token = "0x4005323")]
		[FieldOffset(Offset = "0x28")]
		public float QuestTime;

		// Token: 0x04005324 RID: 21284
		[Token(Token = "0x4005324")]
		[FieldOffset(Offset = "0x2C")]
		public uint QuestNumber;

		// Token: 0x04005325 RID: 21285
		[Token(Token = "0x4005325")]
		[FieldOffset(Offset = "0x30")]
		public uint AwardType;

		// Token: 0x04005326 RID: 21286
		[Token(Token = "0x4005326")]
		[FieldOffset(Offset = "0x34")]
		public uint AwardId;

		// Token: 0x04005327 RID: 21287
		[Token(Token = "0x4005327")]
		[FieldOffset(Offset = "0x38")]
		public uint AwardNum;

		// Token: 0x04005328 RID: 21288
		[Token(Token = "0x4005328")]
		[FieldOffset(Offset = "0x3C")]
		public uint AwardTime;

		// Token: 0x04005329 RID: 21289
		[Token(Token = "0x4005329")]
		[FieldOffset(Offset = "0x40")]
		public uint AwardType2;

		// Token: 0x0400532A RID: 21290
		[Token(Token = "0x400532A")]
		[FieldOffset(Offset = "0x44")]
		public uint AwardId2;

		// Token: 0x0400532B RID: 21291
		[Token(Token = "0x400532B")]
		[FieldOffset(Offset = "0x48")]
		public uint AwardNum2;

		// Token: 0x0400532C RID: 21292
		[Token(Token = "0x400532C")]
		[FieldOffset(Offset = "0x4C")]
		public uint AwardTime2;

		// Token: 0x0400532D RID: 21293
		[Token(Token = "0x400532D")]
		[FieldOffset(Offset = "0x50")]
		public uint AwardType3;

		// Token: 0x0400532E RID: 21294
		[Token(Token = "0x400532E")]
		[FieldOffset(Offset = "0x54")]
		public uint AwardId3;

		// Token: 0x0400532F RID: 21295
		[Token(Token = "0x400532F")]
		[FieldOffset(Offset = "0x58")]
		public uint AwardNum3;

		// Token: 0x04005330 RID: 21296
		[Token(Token = "0x4005330")]
		[FieldOffset(Offset = "0x5C")]
		public uint AwardTime3;

		// Token: 0x04005331 RID: 21297
		[Token(Token = "0x4005331")]
		[FieldOffset(Offset = "0x60")]
		public float CriticalRate;

		// Token: 0x04005332 RID: 21298
		[Token(Token = "0x4005332")]
		[FieldOffset(Offset = "0x64")]
		public float CriticalTimes;
	}
}
