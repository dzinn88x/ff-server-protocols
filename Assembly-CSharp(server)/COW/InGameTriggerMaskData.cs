using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001111 RID: 4369
	[Token(Token = "0x2001111")]
	public class InGameTriggerMaskData : CSVBaseData
	{
		// Token: 0x06004469 RID: 17513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004469")]
		[Address(RVA = "0x185D130", Offset = "0x185D130", VA = "0x7BBC05D130", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600446A RID: 17514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600446A")]
		[Address(RVA = "0x185D1A8", Offset = "0x185D1A8", VA = "0x7BBC05D1A8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600446B RID: 17515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600446B")]
		[Address(RVA = "0x185D398", Offset = "0x185D398", VA = "0x7BBC05D398")]
		public InGameTriggerMaskData()
		{
		}

		// Token: 0x0400545C RID: 21596
		[Token(Token = "0x400545C")]
		[FieldOffset(Offset = "0x10")]
		public uint ID;

		// Token: 0x0400545D RID: 21597
		[Token(Token = "0x400545D")]
		[FieldOffset(Offset = "0x14")]
		public uint Priority;

		// Token: 0x0400545E RID: 21598
		[Token(Token = "0x400545E")]
		[FieldOffset(Offset = "0x18")]
		public ResourceID IconRes;

		// Token: 0x0400545F RID: 21599
		[Token(Token = "0x400545F")]
		[FieldOffset(Offset = "0x1C")]
		public uint FollowType;

		// Token: 0x04005460 RID: 21600
		[Token(Token = "0x4005460")]
		[FieldOffset(Offset = "0x20")]
		public uint MarkType;

		// Token: 0x04005461 RID: 21601
		[Token(Token = "0x4005461")]
		[FieldOffset(Offset = "0x24")]
		public int Deviation;

		// Token: 0x04005462 RID: 21602
		[Token(Token = "0x4005462")]
		[FieldOffset(Offset = "0x28")]
		public float Duration;

		// Token: 0x04005463 RID: 21603
		[Token(Token = "0x4005463")]
		[FieldOffset(Offset = "0x2C")]
		public float CoolDown;

		// Token: 0x04005464 RID: 21604
		[Token(Token = "0x4005464")]
		[FieldOffset(Offset = "0x30")]
		public uint IsBlinkOn;
	}
}
