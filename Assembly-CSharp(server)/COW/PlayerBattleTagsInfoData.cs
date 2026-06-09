using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001167 RID: 4455
	[Token(Token = "0x2001167")]
	public class PlayerBattleTagsInfoData : CSVBaseData
	{
		// Token: 0x06004563 RID: 17763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004563")]
		[Address(RVA = "0x1EFE410", Offset = "0x1EFE410", VA = "0x7BBC6FE410", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004564 RID: 17764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004564")]
		[Address(RVA = "0x1EFE41C", Offset = "0x1EFE41C", VA = "0x7BBC6FE41C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004565")]
		[Address(RVA = "0x1EFE51C", Offset = "0x1EFE51C", VA = "0x7BBC6FE51C")]
		public PlayerBattleTagsInfoData()
		{
		}

		// Token: 0x0400564A RID: 22090
		[Token(Token = "0x400564A")]
		[FieldOffset(Offset = "0x10")]
		public uint BattleTagID;

		// Token: 0x0400564B RID: 22091
		[Token(Token = "0x400564B")]
		[FieldOffset(Offset = "0x14")]
		public uint TagPriority;

		// Token: 0x0400564C RID: 22092
		[Token(Token = "0x400564C")]
		[FieldOffset(Offset = "0x18")]
		public string TagNameKey;

		// Token: 0x0400564D RID: 22093
		[Token(Token = "0x400564D")]
		[FieldOffset(Offset = "0x20")]
		public string TagDescriptionKey;
	}
}
