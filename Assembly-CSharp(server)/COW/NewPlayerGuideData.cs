using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200114A RID: 4426
	[Token(Token = "0x200114A")]
	public class NewPlayerGuideData : CSVBaseData
	{
		// Token: 0x06004512 RID: 17682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004512")]
		[Address(RVA = "0x1A632E0", Offset = "0x1A632E0", VA = "0x7BBC2632E0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004513 RID: 17683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004513")]
		[Address(RVA = "0x1A632EC", Offset = "0x1A632EC", VA = "0x7BBC2632EC", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004514 RID: 17684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004514")]
		[Address(RVA = "0x1A634C4", Offset = "0x1A634C4", VA = "0x7BBC2634C4")]
		public NewPlayerGuideData()
		{
		}

		// Token: 0x04005577 RID: 21879
		[Token(Token = "0x4005577")]
		[FieldOffset(Offset = "0x10")]
		public int Precdt1;

		// Token: 0x04005578 RID: 21880
		[Token(Token = "0x4005578")]
		[FieldOffset(Offset = "0x14")]
		public int Precdt_value1;

		// Token: 0x04005579 RID: 21881
		[Token(Token = "0x4005579")]
		[FieldOffset(Offset = "0x18")]
		public int Precdt2;

		// Token: 0x0400557A RID: 21882
		[Token(Token = "0x400557A")]
		[FieldOffset(Offset = "0x1C")]
		public int Precdt_value2;

		// Token: 0x0400557B RID: 21883
		[Token(Token = "0x400557B")]
		[FieldOffset(Offset = "0x20")]
		public int Precdt3;

		// Token: 0x0400557C RID: 21884
		[Token(Token = "0x400557C")]
		[FieldOffset(Offset = "0x24")]
		public int Precdt_value3;

		// Token: 0x0400557D RID: 21885
		[Token(Token = "0x400557D")]
		[FieldOffset(Offset = "0x28")]
		public int Precdt4;

		// Token: 0x0400557E RID: 21886
		[Token(Token = "0x400557E")]
		[FieldOffset(Offset = "0x2C")]
		public int Precdt_value4;

		// Token: 0x0400557F RID: 21887
		[Token(Token = "0x400557F")]
		[FieldOffset(Offset = "0x30")]
		public int GuideId;

		// Token: 0x04005580 RID: 21888
		[Token(Token = "0x4005580")]
		[FieldOffset(Offset = "0x38")]
		public string GuideIntroKey;
	}
}
