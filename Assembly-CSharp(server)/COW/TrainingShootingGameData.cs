using System;
using Il2CppDummyDll;
using SimpleJSON;

namespace COW
{
	// Token: 0x02001196 RID: 4502
	[Token(Token = "0x2001196")]
	public class TrainingShootingGameData : IJsonGameData
	{
		// Token: 0x0600460E RID: 17934 RVA: 0x00015360 File Offset: 0x00013560
		[Token(Token = "0x600460E")]
		[Address(RVA = "0x1A313E4", Offset = "0x1A313E4", VA = "0x7BBC2313E4")]
		public uint GetOverrideHpByTargetType(TargetOccurType type)
		{
			return 0U;
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x00015378 File Offset: 0x00013578
		[Token(Token = "0x600460F")]
		[Address(RVA = "0x1A3144C", Offset = "0x1A3144C", VA = "0x7BBC23144C")]
		public uint GetAllTypeTargetCnt()
		{
			return 0U;
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004610")]
		[Address(RVA = "0x1A30E0C", Offset = "0x1A30E0C", VA = "0x7BBC230E0C", Slot = "4")]
		public void LoadDataFromJsonData(JSONNode jObject)
		{
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004611")]
		[Address(RVA = "0x1A30E04", Offset = "0x1A30E04", VA = "0x7BBC230E04")]
		public TrainingShootingGameData()
		{
		}

		// Token: 0x04005728 RID: 22312
		[Token(Token = "0x4005728")]
		[FieldOffset(Offset = "0x10")]
		public uint Rule;

		// Token: 0x04005729 RID: 22313
		[Token(Token = "0x4005729")]
		[FieldOffset(Offset = "0x14")]
		public uint SpawnTargetCnt;

		// Token: 0x0400572A RID: 22314
		[Token(Token = "0x400572A")]
		[FieldOffset(Offset = "0x18")]
		public float GameTime;

		// Token: 0x0400572B RID: 22315
		[Token(Token = "0x400572B")]
		[FieldOffset(Offset = "0x1C")]
		public uint Type0Cnt;

		// Token: 0x0400572C RID: 22316
		[Token(Token = "0x400572C")]
		[FieldOffset(Offset = "0x20")]
		public uint Type1Cnt;

		// Token: 0x0400572D RID: 22317
		[Token(Token = "0x400572D")]
		[FieldOffset(Offset = "0x24")]
		public uint Type2Cnt;

		// Token: 0x0400572E RID: 22318
		[Token(Token = "0x400572E")]
		[FieldOffset(Offset = "0x28")]
		public float TargetDelayTime;

		// Token: 0x0400572F RID: 22319
		[Token(Token = "0x400572F")]
		[FieldOffset(Offset = "0x2C")]
		public uint ShowType2NeedHitCnt;

		// Token: 0x04005730 RID: 22320
		[Token(Token = "0x4005730")]
		[FieldOffset(Offset = "0x30")]
		public bool NeedOverrideHP;

		// Token: 0x04005731 RID: 22321
		[Token(Token = "0x4005731")]
		[FieldOffset(Offset = "0x38")]
		private uint[] OverrideHps;
	}
}
