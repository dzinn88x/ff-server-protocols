using System;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001D12 RID: 7442
	[Token(Token = "0x2001D12")]
	public class RoomGameAchievementData : CSVBaseData
	{
		// Token: 0x0600A207 RID: 41479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A207")]
		[Address(RVA = "0x1B319D4", Offset = "0x1B319D4", VA = "0x7BBC3319D4", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600A208 RID: 41480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A208")]
		[Address(RVA = "0x1B31BF4", Offset = "0x1B31BF4", VA = "0x7BBC331BF4", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600A209 RID: 41481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A209")]
		[Address(RVA = "0x1B31C00", Offset = "0x1B31C00", VA = "0x7BBC331C00")]
		public RoomGameAchievementData()
		{
		}

		// Token: 0x0400A873 RID: 43123
		[Token(Token = "0x400A873")]
		[FieldOffset(Offset = "0x10")]
		public uint ID;

		// Token: 0x0400A874 RID: 43124
		[Token(Token = "0x400A874")]
		[FieldOffset(Offset = "0x14")]
		public QD|\u0082jKq Type;

		// Token: 0x0400A875 RID: 43125
		[Token(Token = "0x400A875")]
		[FieldOffset(Offset = "0x18")]
		public ERoomGameAchevementCamera Camera;

		// Token: 0x0400A876 RID: 43126
		[Token(Token = "0x400A876")]
		[FieldOffset(Offset = "0x1C")]
		public float EffectTime;

		// Token: 0x0400A877 RID: 43127
		[Token(Token = "0x400A877")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID SoundRes;

		// Token: 0x0400A878 RID: 43128
		[Token(Token = "0x400A878")]
		[FieldOffset(Offset = "0x28")]
		public string ImgName;

		// Token: 0x0400A879 RID: 43129
		[Token(Token = "0x400A879")]
		[FieldOffset(Offset = "0x30")]
		public string LocKey;
	}
}
