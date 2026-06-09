using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001193 RID: 4499
	[Token(Token = "0x2001193")]
	public class TrainingEsportHallOfFameData : CSVBaseData
	{
		// Token: 0x0600460A RID: 17930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600460A")]
		[Address(RVA = "0x1A30380", Offset = "0x1A30380", VA = "0x7BBC230380", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600460B")]
		[Address(RVA = "0x1A3038C", Offset = "0x1A3038C", VA = "0x7BBC23038C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600460C")]
		[Address(RVA = "0x1A30528", Offset = "0x1A30528", VA = "0x7BBC230528")]
		public TrainingEsportHallOfFameData()
		{
		}

		// Token: 0x0400571E RID: 22302
		[Token(Token = "0x400571E")]
		[FieldOffset(Offset = "0x10")]
		public uint ID;

		// Token: 0x0400571F RID: 22303
		[Token(Token = "0x400571F")]
		[FieldOffset(Offset = "0x18")]
		public string Title;

		// Token: 0x04005720 RID: 22304
		[Token(Token = "0x4005720")]
		[FieldOffset(Offset = "0x20")]
		public string Desc;

		// Token: 0x04005721 RID: 22305
		[Token(Token = "0x4005721")]
		[FieldOffset(Offset = "0x28")]
		public string TeamName;

		// Token: 0x04005722 RID: 22306
		[Token(Token = "0x4005722")]
		[FieldOffset(Offset = "0x30")]
		public ResourceID TextureResID;

		// Token: 0x04005723 RID: 22307
		[Token(Token = "0x4005723")]
		[FieldOffset(Offset = "0x34")]
		public ResourceID TeamIconRes;
	}
}
