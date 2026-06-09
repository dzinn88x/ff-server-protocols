using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001175 RID: 4469
	[Token(Token = "0x2001175")]
	public class PVEDropShowcaseData : CSVBaseData
	{
		// Token: 0x06004592 RID: 17810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004592")]
		[Address(RVA = "0x203C4A0", Offset = "0x203C4A0", VA = "0x7BBC83C4A0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004593 RID: 17811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004593")]
		[Address(RVA = "0x203C4AC", Offset = "0x203C4AC", VA = "0x7BBC83C4AC", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004594 RID: 17812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004594")]
		[Address(RVA = "0x203C620", Offset = "0x203C620", VA = "0x7BBC83C620")]
		public PVEDropShowcaseData()
		{
		}

		// Token: 0x04005678 RID: 22136
		[Token(Token = "0x4005678")]
		[FieldOffset(Offset = "0x10")]
		public uint ConfigId;

		// Token: 0x04005679 RID: 22137
		[Token(Token = "0x4005679")]
		[FieldOffset(Offset = "0x14")]
		public int Difficulty;

		// Token: 0x0400567A RID: 22138
		[Token(Token = "0x400567A")]
		[FieldOffset(Offset = "0x18")]
		public uint ItemId;

		// Token: 0x0400567B RID: 22139
		[Token(Token = "0x400567B")]
		[FieldOffset(Offset = "0x1C")]
		public bool IsPVEToken;

		// Token: 0x0400567C RID: 22140
		[Token(Token = "0x400567C")]
		[FieldOffset(Offset = "0x1D")]
		public bool IsMainDrop;

		// Token: 0x0400567D RID: 22141
		[Token(Token = "0x400567D")]
		[FieldOffset(Offset = "0x20")]
		public uint GoPos;

		// Token: 0x0400567E RID: 22142
		[Token(Token = "0x400567E")]
		[FieldOffset(Offset = "0x28")]
		public string SubGoPos;
	}
}
