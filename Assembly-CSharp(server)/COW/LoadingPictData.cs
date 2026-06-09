using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200112C RID: 4396
	[Token(Token = "0x200112C")]
	public class LoadingPictData : CSVBaseData
	{
		// Token: 0x060044B8 RID: 17592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044B8")]
		[Address(RVA = "0x1405448", Offset = "0x1405448", VA = "0x7BBBC05448", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B9")]
		[Address(RVA = "0x1405454", Offset = "0x1405454", VA = "0x7BBBC05454", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044BA")]
		[Address(RVA = "0x14057A4", Offset = "0x14057A4", VA = "0x7BBBC057A4")]
		public LoadingPictData()
		{
		}

		// Token: 0x040054E2 RID: 21730
		[Token(Token = "0x40054E2")]
		[FieldOffset(Offset = "0x10")]
		public uint iID;

		// Token: 0x040054E3 RID: 21731
		[Token(Token = "0x40054E3")]
		[FieldOffset(Offset = "0x14")]
		public uint matchMode;

		// Token: 0x040054E4 RID: 21732
		[Token(Token = "0x40054E4")]
		[FieldOffset(Offset = "0x18")]
		public uint groupMode;

		// Token: 0x040054E5 RID: 21733
		[Token(Token = "0x40054E5")]
		[FieldOffset(Offset = "0x1C")]
		public uint mapID;

		// Token: 0x040054E6 RID: 21734
		[Token(Token = "0x40054E6")]
		[FieldOffset(Offset = "0x20")]
		public uint modeID;

		// Token: 0x040054E7 RID: 21735
		[Token(Token = "0x40054E7")]
		[FieldOffset(Offset = "0x28")]
		public List<LoadingPictResource> loadingPictsRes;
	}
}
