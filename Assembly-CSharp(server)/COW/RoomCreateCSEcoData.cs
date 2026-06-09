using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001185 RID: 4485
	[Token(Token = "0x2001185")]
	public class RoomCreateCSEcoData : CSVBaseData
	{
		// Token: 0x060045C7 RID: 17863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C7")]
		[Address(RVA = "0x1B2E934", Offset = "0x1B2E934", VA = "0x7BBC32E934", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C8")]
		[Address(RVA = "0x1B2EAC0", Offset = "0x1B2EAC0", VA = "0x7BBC32EAC0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C9")]
		[Address(RVA = "0x1B2EACC", Offset = "0x1B2EACC", VA = "0x7BBC32EACC")]
		public RoomCreateCSEcoData()
		{
		}

		// Token: 0x040056D3 RID: 22227
		[Token(Token = "0x40056D3")]
		[FieldOffset(Offset = "0x10")]
		public uint Index;

		// Token: 0x040056D4 RID: 22228
		[Token(Token = "0x40056D4")]
		[FieldOffset(Offset = "0x18")]
		public string Key;

		// Token: 0x040056D5 RID: 22229
		[Token(Token = "0x40056D5")]
		[FieldOffset(Offset = "0x20")]
		public int Min;

		// Token: 0x040056D6 RID: 22230
		[Token(Token = "0x40056D6")]
		[FieldOffset(Offset = "0x24")]
		public int Max;

		// Token: 0x040056D7 RID: 22231
		[Token(Token = "0x40056D7")]
		[FieldOffset(Offset = "0x28")]
		public int Default;

		// Token: 0x040056D8 RID: 22232
		[Token(Token = "0x40056D8")]
		[FieldOffset(Offset = "0x2C")]
		public int Step;

		// Token: 0x040056D9 RID: 22233
		[Token(Token = "0x40056D9")]
		[FieldOffset(Offset = "0x30")]
		public bool IsOpen;
	}
}
