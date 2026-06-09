using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010B4 RID: 4276
	[Token(Token = "0x20010B4")]
	public class BigEventNodeSettingData : CSVBaseData
	{
		// Token: 0x060042B3 RID: 17075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042B3")]
		[Address(RVA = "0x21D8050", Offset = "0x21D8050", VA = "0x7BBC9D8050", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060042B4 RID: 17076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042B4")]
		[Address(RVA = "0x21D805C", Offset = "0x21D805C", VA = "0x7BBC9D805C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060042B5 RID: 17077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042B5")]
		[Address(RVA = "0x21D8474", Offset = "0x21D8474", VA = "0x7BBC9D8474")]
		public BigEventNodeSettingData()
		{
		}

		// Token: 0x040051B6 RID: 20918
		[Token(Token = "0x40051B6")]
		[FieldOffset(Offset = "0x10")]
		public int NodeId;

		// Token: 0x040051B7 RID: 20919
		[Token(Token = "0x40051B7")]
		[FieldOffset(Offset = "0x14")]
		public int NodeType;

		// Token: 0x040051B8 RID: 20920
		[Token(Token = "0x40051B8")]
		[FieldOffset(Offset = "0x18")]
		public string SubNode;

		// Token: 0x040051B9 RID: 20921
		[Token(Token = "0x40051B9")]
		[FieldOffset(Offset = "0x20")]
		public int NodeUnlockAmount;

		// Token: 0x040051BA RID: 20922
		[Token(Token = "0x40051BA")]
		[FieldOffset(Offset = "0x28")]
		public string NodeTitle;

		// Token: 0x040051BB RID: 20923
		[Token(Token = "0x40051BB")]
		[FieldOffset(Offset = "0x30")]
		public string NodeBrifeKey;

		// Token: 0x040051BC RID: 20924
		[Token(Token = "0x40051BC")]
		[FieldOffset(Offset = "0x38")]
		public string NodeTime;

		// Token: 0x040051BD RID: 20925
		[Token(Token = "0x40051BD")]
		[FieldOffset(Offset = "0x40")]
		public string NodeDescribtion1;

		// Token: 0x040051BE RID: 20926
		[Token(Token = "0x40051BE")]
		[FieldOffset(Offset = "0x48")]
		public string NodeDescribtion2;

		// Token: 0x040051BF RID: 20927
		[Token(Token = "0x40051BF")]
		[FieldOffset(Offset = "0x50")]
		public string NodeDescribtion3;

		// Token: 0x040051C0 RID: 20928
		[Token(Token = "0x40051C0")]
		[FieldOffset(Offset = "0x58")]
		public string ArtResource1;

		// Token: 0x040051C1 RID: 20929
		[Token(Token = "0x40051C1")]
		[FieldOffset(Offset = "0x60")]
		public string ArtResource2;

		// Token: 0x040051C2 RID: 20930
		[Token(Token = "0x40051C2")]
		[FieldOffset(Offset = "0x68")]
		public string ArtResource3;

		// Token: 0x040051C3 RID: 20931
		[Token(Token = "0x40051C3")]
		[FieldOffset(Offset = "0x70")]
		public uint AwardItemId1;

		// Token: 0x040051C4 RID: 20932
		[Token(Token = "0x40051C4")]
		[FieldOffset(Offset = "0x74")]
		public uint AwardItemId2;

		// Token: 0x040051C5 RID: 20933
		[Token(Token = "0x40051C5")]
		[FieldOffset(Offset = "0x78")]
		public uint AwardItemId3;

		// Token: 0x040051C6 RID: 20934
		[Token(Token = "0x40051C6")]
		[FieldOffset(Offset = "0x7C")]
		public uint AwardItemId4;

		// Token: 0x040051C7 RID: 20935
		[Token(Token = "0x40051C7")]
		[FieldOffset(Offset = "0x80")]
		public uint AwardItemNum1;

		// Token: 0x040051C8 RID: 20936
		[Token(Token = "0x40051C8")]
		[FieldOffset(Offset = "0x84")]
		public uint AwardItemNum2;

		// Token: 0x040051C9 RID: 20937
		[Token(Token = "0x40051C9")]
		[FieldOffset(Offset = "0x88")]
		public uint AwardItemNum3;

		// Token: 0x040051CA RID: 20938
		[Token(Token = "0x40051CA")]
		[FieldOffset(Offset = "0x8C")]
		public uint AwardItemNum4;

		// Token: 0x040051CB RID: 20939
		[Token(Token = "0x40051CB")]
		[FieldOffset(Offset = "0x90")]
		public uint AwardItemType1;

		// Token: 0x040051CC RID: 20940
		[Token(Token = "0x40051CC")]
		[FieldOffset(Offset = "0x94")]
		public uint AwardItemType2;

		// Token: 0x040051CD RID: 20941
		[Token(Token = "0x40051CD")]
		[FieldOffset(Offset = "0x98")]
		public uint AwardItemType3;

		// Token: 0x040051CE RID: 20942
		[Token(Token = "0x40051CE")]
		[FieldOffset(Offset = "0x9C")]
		public uint AwardItemType4;

		// Token: 0x040051CF RID: 20943
		[Token(Token = "0x40051CF")]
		[FieldOffset(Offset = "0xA0")]
		public string NodeIcon;
	}
}
