using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010A6 RID: 4262
	[Token(Token = "0x20010A6")]
	public class ClothesHairUpData : CSVBaseData, IGetId
	{
		// Token: 0x0600426D RID: 17005 RVA: 0x00014748 File Offset: 0x00012948
		[Token(Token = "0x600426D")]
		[Address(RVA = "0x14FA7BC", Offset = "0x14FA7BC", VA = "0x7BBBCFA7BC", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x0600426E RID: 17006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600426E")]
		[Address(RVA = "0x14FA7C4", Offset = "0x14FA7C4", VA = "0x7BBBCFA7C4", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600426F RID: 17007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600426F")]
		[Address(RVA = "0x14FA7D0", Offset = "0x14FA7D0", VA = "0x7BBBCFA7D0", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004270")]
		[Address(RVA = "0x14FA8F4", Offset = "0x14FA8F4", VA = "0x7BBBCFA8F4")]
		public ClothesHairUpData()
		{
		}

		// Token: 0x04005164 RID: 20836
		[Token(Token = "0x4005164")]
		[FieldOffset(Offset = "0x10")]
		public uint iID;

		// Token: 0x04005165 RID: 20837
		[Token(Token = "0x4005165")]
		[FieldOffset(Offset = "0x14")]
		public uint LV0;

		// Token: 0x04005166 RID: 20838
		[Token(Token = "0x4005166")]
		[FieldOffset(Offset = "0x18")]
		public uint LV1;

		// Token: 0x04005167 RID: 20839
		[Token(Token = "0x4005167")]
		[FieldOffset(Offset = "0x1C")]
		public uint LV2;

		// Token: 0x04005168 RID: 20840
		[Token(Token = "0x4005168")]
		[FieldOffset(Offset = "0x20")]
		public uint LV3;
	}
}
