using System;
using Il2CppDummyDll;
using SimpleJSON;

namespace COW
{
	// Token: 0x02001197 RID: 4503
	[Token(Token = "0x2001197")]
	public class TrainingIceWallPracticeData : IJsonGameData
	{
		// Token: 0x06004612 RID: 17938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004612")]
		[Address(RVA = "0x1A30664", Offset = "0x1A30664", VA = "0x7BBC230664", Slot = "4")]
		public void LoadDataFromJsonData(JSONNode jObject)
		{
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004613")]
		[Address(RVA = "0x1A30894", Offset = "0x1A30894", VA = "0x7BBC230894")]
		public TrainingIceWallPracticeData()
		{
		}

		// Token: 0x04005732 RID: 22322
		[Token(Token = "0x4005732")]
		[FieldOffset(Offset = "0x10")]
		public uint Rule;

		// Token: 0x04005733 RID: 22323
		[Token(Token = "0x4005733")]
		[FieldOffset(Offset = "0x14")]
		public uint ItemID;

		// Token: 0x04005734 RID: 22324
		[Token(Token = "0x4005734")]
		[FieldOffset(Offset = "0x18")]
		public uint GiveCount;

		// Token: 0x04005735 RID: 22325
		[Token(Token = "0x4005735")]
		[FieldOffset(Offset = "0x1C")]
		public float GameTime;

		// Token: 0x04005736 RID: 22326
		[Token(Token = "0x4005736")]
		[FieldOffset(Offset = "0x20")]
		public uint EndGameHp;

		// Token: 0x04005737 RID: 22327
		[Token(Token = "0x4005737")]
		[FieldOffset(Offset = "0x24")]
		public uint PartChangeTime;

		// Token: 0x04005738 RID: 22328
		[Token(Token = "0x4005738")]
		[FieldOffset(Offset = "0x28")]
		public float WeaponShowTime;

		// Token: 0x04005739 RID: 22329
		[Token(Token = "0x4005739")]
		[FieldOffset(Offset = "0x2C")]
		public int WeaponCntPerGroup;

		// Token: 0x0400573A RID: 22330
		[Token(Token = "0x400573A")]
		[FieldOffset(Offset = "0x30")]
		public uint IceWallHP;

		// Token: 0x0400573B RID: 22331
		[Token(Token = "0x400573B")]
		[FieldOffset(Offset = "0x34")]
		public uint IceWallMaxNum;
	}
}
