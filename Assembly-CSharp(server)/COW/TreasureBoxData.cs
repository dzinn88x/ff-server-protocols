using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001199 RID: 4505
	[Token(Token = "0x2001199")]
	public class TreasureBoxData : CsvDataIndexedReading, IGetId
	{
		// Token: 0x06004616 RID: 17942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004616")]
		[Address(RVA = "0x1A31460", Offset = "0x1A31460", VA = "0x7BBC231460", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004617 RID: 17943 RVA: 0x00015390 File Offset: 0x00013590
		[Token(Token = "0x6004617")]
		[Address(RVA = "0x1A3146C", Offset = "0x1A3146C", VA = "0x7BBC23146C", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x06004618 RID: 17944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004618")]
		[Address(RVA = "0x1A31474", Offset = "0x1A31474", VA = "0x7BBC231474", Slot = "7")]
		public override string[] GetHeadColNames()
		{
			return null;
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004619")]
		[Address(RVA = "0x1A31818", Offset = "0x1A31818", VA = "0x7BBC231818", Slot = "8")]
		public override void ParseData(IIndexString ss, int[] index)
		{
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600461A")]
		[Address(RVA = "0x1A31F48", Offset = "0x1A31F48", VA = "0x7BBC231F48")]
		public TreasureBoxData()
		{
		}

		// Token: 0x04005744 RID: 22340
		[Token(Token = "0x4005744")]
		[FieldOffset(Offset = "0x10")]
		public uint ID;

		// Token: 0x04005745 RID: 22341
		[Token(Token = "0x4005745")]
		[FieldOffset(Offset = "0x14")]
		public uint AwardID;

		// Token: 0x04005746 RID: 22342
		[Token(Token = "0x4005746")]
		[FieldOffset(Offset = "0x18")]
		public uint AwardNum;

		// Token: 0x04005747 RID: 22343
		[Token(Token = "0x4005747")]
		[FieldOffset(Offset = "0x1C")]
		public uint AwardTime;

		// Token: 0x04005748 RID: 22344
		[Token(Token = "0x4005748")]
		[FieldOffset(Offset = "0x20")]
		public EInventory.AwardType AwardType;

		// Token: 0x04005749 RID: 22345
		[Token(Token = "0x4005749")]
		[FieldOffset(Offset = "0x24")]
		public bool IsPreview;

		// Token: 0x0400574A RID: 22346
		[Token(Token = "0x400574A")]
		[FieldOffset(Offset = "0x28")]
		public uint PreviewAvatar;

		// Token: 0x0400574B RID: 22347
		[Token(Token = "0x400574B")]
		[FieldOffset(Offset = "0x2C")]
		public bool IsBigReward;

		// Token: 0x0400574C RID: 22348
		[Token(Token = "0x400574C")]
		[FieldOffset(Offset = "0x30")]
		public uint Rewardlevel;

		// Token: 0x0400574D RID: 22349
		[Token(Token = "0x400574D")]
		[FieldOffset(Offset = "0x34")]
		public bool ComposeIcon;
	}
}
