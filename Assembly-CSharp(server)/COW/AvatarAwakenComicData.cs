using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200109A RID: 4250
	[Token(Token = "0x200109A")]
	public class AvatarAwakenComicData : CSVBaseData
	{
		// Token: 0x0600419B RID: 16795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419B")]
		[Address(RVA = "0x155C218", Offset = "0x155C218", VA = "0x7BBBD5C218", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600419C RID: 16796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419C")]
		[Address(RVA = "0x155C224", Offset = "0x155C224", VA = "0x7BBBD5C224")]
		public static string GeneratePrimaryKey(uint characterID, uint comicID)
		{
			return null;
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600419D")]
		[Address(RVA = "0x155C2B8", Offset = "0x155C2B8", VA = "0x7BBBD5C2B8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600419E RID: 16798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600419E")]
		[Address(RVA = "0x155C42C", Offset = "0x155C42C", VA = "0x7BBBD5C42C")]
		public AvatarAwakenComicData()
		{
		}

		// Token: 0x040050DF RID: 20703
		[Token(Token = "0x40050DF")]
		[FieldOffset(Offset = "0x10")]
		public uint CharacterID;

		// Token: 0x040050E0 RID: 20704
		[Token(Token = "0x40050E0")]
		[FieldOffset(Offset = "0x14")]
		public uint ComicID;

		// Token: 0x040050E1 RID: 20705
		[Token(Token = "0x40050E1")]
		[FieldOffset(Offset = "0x18")]
		public uint UnlockItemID;

		// Token: 0x040050E2 RID: 20706
		[Token(Token = "0x40050E2")]
		[FieldOffset(Offset = "0x1C")]
		public uint UnlockItemNum;

		// Token: 0x040050E3 RID: 20707
		[Token(Token = "0x40050E3")]
		[FieldOffset(Offset = "0x20")]
		public string ComicName;

		// Token: 0x040050E4 RID: 20708
		[Token(Token = "0x40050E4")]
		[FieldOffset(Offset = "0x28")]
		public string ComicTitleCDN;

		// Token: 0x040050E5 RID: 20709
		[Token(Token = "0x40050E5")]
		[FieldOffset(Offset = "0x30")]
		public string ComicContentCDN;
	}
}
