using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200118B RID: 4491
	[Token(Token = "0x200118B")]
	public class SoundTipsData : CSVBaseData
	{
		// Token: 0x060045EF RID: 17903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045EF")]
		[Address(RVA = "0x1B3A5A0", Offset = "0x1B3A5A0", VA = "0x7BBC33A5A0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F0")]
		[Address(RVA = "0x1B3A5AC", Offset = "0x1B3A5AC", VA = "0x7BBC33A5AC", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F1")]
		[Address(RVA = "0x1B3A8EC", Offset = "0x1B3A8EC", VA = "0x7BBC33A8EC")]
		public SoundTipsData()
		{
		}

		// Token: 0x040056FB RID: 22267
		[Token(Token = "0x40056FB")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x040056FC RID: 22268
		[Token(Token = "0x40056FC")]
		[FieldOffset(Offset = "0x14")]
		public ResourceID IconResourceID;

		// Token: 0x040056FD RID: 22269
		[Token(Token = "0x40056FD")]
		[FieldOffset(Offset = "0x18")]
		public float DangerRange;

		// Token: 0x040056FE RID: 22270
		[Token(Token = "0x40056FE")]
		[FieldOffset(Offset = "0x1C")]
		public float WarningRange;

		// Token: 0x040056FF RID: 22271
		[Token(Token = "0x40056FF")]
		[FieldOffset(Offset = "0x20")]
		public float HintRange;

		// Token: 0x04005700 RID: 22272
		[Token(Token = "0x4005700")]
		[FieldOffset(Offset = "0x24")]
		public float MaxRange;

		// Token: 0x04005701 RID: 22273
		[Token(Token = "0x4005701")]
		[FieldOffset(Offset = "0x28")]
		public float Time;

		// Token: 0x04005702 RID: 22274
		[Token(Token = "0x4005702")]
		[FieldOffset(Offset = "0x2C")]
		public bool IsNeedShow;
	}
}
