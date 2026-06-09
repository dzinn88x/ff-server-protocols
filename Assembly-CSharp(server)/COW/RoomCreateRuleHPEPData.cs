using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001183 RID: 4483
	[Token(Token = "0x2001183")]
	public class RoomCreateRuleHPEPData : CSVBaseData
	{
		// Token: 0x060045C1 RID: 17857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C1")]
		[Address(RVA = "0x1B31858", Offset = "0x1B31858", VA = "0x7BBC331858", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C2")]
		[Address(RVA = "0x1B31960", Offset = "0x1B31960", VA = "0x7BBC331960", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C3")]
		[Address(RVA = "0x1B3196C", Offset = "0x1B3196C", VA = "0x7BBC33196C")]
		public RoomCreateRuleHPEPData()
		{
		}

		// Token: 0x040056C9 RID: 22217
		[Token(Token = "0x40056C9")]
		[FieldOffset(Offset = "0x10")]
		public uint ID;

		// Token: 0x040056CA RID: 22218
		[Token(Token = "0x40056CA")]
		[FieldOffset(Offset = "0x14")]
		public uint Key;

		// Token: 0x040056CB RID: 22219
		[Token(Token = "0x40056CB")]
		[FieldOffset(Offset = "0x18")]
		public string Loc;

		// Token: 0x040056CC RID: 22220
		[Token(Token = "0x40056CC")]
		[FieldOffset(Offset = "0x20")]
		public uint Type;
	}
}
