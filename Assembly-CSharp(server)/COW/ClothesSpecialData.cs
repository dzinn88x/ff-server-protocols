using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010A5 RID: 4261
	[Token(Token = "0x20010A5")]
	public class ClothesSpecialData : CSVBaseData, IGetId
	{
		// Token: 0x06004269 RID: 17001 RVA: 0x00014730 File Offset: 0x00012930
		[Token(Token = "0x6004269")]
		[Address(RVA = "0x14FA95C", Offset = "0x14FA95C", VA = "0x7BBBCFA95C", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600426A")]
		[Address(RVA = "0x14FA964", Offset = "0x14FA964", VA = "0x7BBBCFA964", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600426B")]
		[Address(RVA = "0x14FA970", Offset = "0x14FA970", VA = "0x7BBBCFA970", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600426C RID: 17004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600426C")]
		[Address(RVA = "0x14FAA94", Offset = "0x14FAA94", VA = "0x7BBBCFAA94")]
		public ClothesSpecialData()
		{
		}

		// Token: 0x0400515F RID: 20831
		[Token(Token = "0x400515F")]
		[FieldOffset(Offset = "0x10")]
		public uint iID;

		// Token: 0x04005160 RID: 20832
		[Token(Token = "0x4005160")]
		[FieldOffset(Offset = "0x14")]
		public uint avatarID;

		// Token: 0x04005161 RID: 20833
		[Token(Token = "0x4005161")]
		[FieldOffset(Offset = "0x18")]
		public uint itemID;

		// Token: 0x04005162 RID: 20834
		[Token(Token = "0x4005162")]
		[FieldOffset(Offset = "0x20")]
		public string recipeStrInLobby;

		// Token: 0x04005163 RID: 20835
		[Token(Token = "0x4005163")]
		[FieldOffset(Offset = "0x28")]
		public string recipeStrInGame;
	}
}
