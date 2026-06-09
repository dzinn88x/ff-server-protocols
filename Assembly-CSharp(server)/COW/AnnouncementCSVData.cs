using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001D5D RID: 7517
	[Token(Token = "0x2001D5D")]
	public class AnnouncementCSVData : CSVBaseData
	{
		// Token: 0x0600A3EB RID: 41963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A3EB")]
		[Address(RVA = "0x154D764", Offset = "0x154D764", VA = "0x7BBBD4D764", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600A3EC RID: 41964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3EC")]
		[Address(RVA = "0x154D770", Offset = "0x154D770", VA = "0x7BBBD4D770", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600A3ED RID: 41965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3ED")]
		[Address(RVA = "0x154D964", Offset = "0x154D964", VA = "0x7BBBD4D964")]
		public AnnouncementCSVData()
		{
		}

		// Token: 0x0400A9F8 RID: 43512
		[Token(Token = "0x400A9F8")]
		[FieldOffset(Offset = "0x10")]
		public string Region;

		// Token: 0x0400A9F9 RID: 43513
		[Token(Token = "0x400A9F9")]
		[FieldOffset(Offset = "0x18")]
		public string Title;

		// Token: 0x0400A9FA RID: 43514
		[Token(Token = "0x400A9FA")]
		[FieldOffset(Offset = "0x20")]
		public string Brief;

		// Token: 0x0400A9FB RID: 43515
		[Token(Token = "0x400A9FB")]
		[FieldOffset(Offset = "0x28")]
		public string ImageUrl;

		// Token: 0x0400A9FC RID: 43516
		[Token(Token = "0x400A9FC")]
		[FieldOffset(Offset = "0x30")]
		public string FBPageID;

		// Token: 0x0400A9FD RID: 43517
		[Token(Token = "0x400A9FD")]
		[FieldOffset(Offset = "0x38")]
		public string LinkUrl;

		// Token: 0x0400A9FE RID: 43518
		[Token(Token = "0x400A9FE")]
		[FieldOffset(Offset = "0x40")]
		public string Desc;

		// Token: 0x0400A9FF RID: 43519
		[Token(Token = "0x400A9FF")]
		[FieldOffset(Offset = "0x48")]
		public uint Id;

		// Token: 0x0400AA00 RID: 43520
		[Token(Token = "0x400AA00")]
		[FieldOffset(Offset = "0x4C")]
		public uint OrderInThisRegion;
	}
}
