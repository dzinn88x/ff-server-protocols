using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010DA RID: 4314
	[Token(Token = "0x20010DA")]
	public class CSSharedItemData : CsvDataIndexedReading, IGetId
	{
		// Token: 0x06004351 RID: 17233 RVA: 0x00014B38 File Offset: 0x00012D38
		[Token(Token = "0x6004351")]
		[Address(RVA = "0x14F0A90", Offset = "0x14F0A90", VA = "0x7BBBCF0A90", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06004352 RID: 17234 RVA: 0x00014B50 File Offset: 0x00012D50
		[Token(Token = "0x170007ED")]
		public byte subType
		{
			[Token(Token = "0x6004352")]
			[Address(RVA = "0x14F0A98", Offset = "0x14F0A98", VA = "0x7BBBCF0A98")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06004353 RID: 17235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007EE")]
		public string endTime
		{
			[Token(Token = "0x6004353")]
			[Address(RVA = "0x14F0BA0", Offset = "0x14F0BA0", VA = "0x7BBBCF0BA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004354")]
		[Address(RVA = "0x14F0CA8", Offset = "0x14F0CA8", VA = "0x7BBBCF0CA8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004355")]
		[Address(RVA = "0x14F0CB4", Offset = "0x14F0CB4", VA = "0x7BBBCF0CB4", Slot = "7")]
		public override string[] GetHeadColNames()
		{
			return null;
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004356")]
		[Address(RVA = "0x14F10AC", Offset = "0x14F10AC", VA = "0x7BBBCF10AC", Slot = "8")]
		public override void ParseData(IIndexString ss, int[] index)
		{
		}

		// Token: 0x06004357 RID: 17239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004357")]
		[Address(RVA = "0x14F1B68", Offset = "0x14F1B68", VA = "0x7BBBCF1B68")]
		public CSSharedItemData()
		{
		}

		// Token: 0x04005303 RID: 21251
		[Token(Token = "0x4005303")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04005304 RID: 21252
		[Token(Token = "0x4005304")]
		[FieldOffset(Offset = "0x18")]
		public string description;

		// Token: 0x04005305 RID: 21253
		[Token(Token = "0x4005305")]
		[FieldOffset(Offset = "0x20")]
		public uint iID;

		// Token: 0x04005306 RID: 21254
		[Token(Token = "0x4005306")]
		[FieldOffset(Offset = "0x24")]
		public ResourceID iconRes;

		// Token: 0x04005307 RID: 21255
		[Token(Token = "0x4005307")]
		[FieldOffset(Offset = "0x28")]
		public ResourceID bigIconRes;

		// Token: 0x04005308 RID: 21256
		[Token(Token = "0x4005308")]
		[FieldOffset(Offset = "0x2C")]
		public byte itemType;

		// Token: 0x04005309 RID: 21257
		[Token(Token = "0x4005309")]
		[FieldOffset(Offset = "0x2D")]
		public byte Rare;

		// Token: 0x0400530A RID: 21258
		[Token(Token = "0x400530A")]
		[FieldOffset(Offset = "0x2E")]
		public bool isUnique;

		// Token: 0x0400530B RID: 21259
		[Token(Token = "0x400530B")]
		[FieldOffset(Offset = "0x2F")]
		public byte collectionType;
	}
}
