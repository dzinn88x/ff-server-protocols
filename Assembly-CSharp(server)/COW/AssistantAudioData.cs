using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001097 RID: 4247
	[Token(Token = "0x2001097")]
	public class AssistantAudioData : CSVBaseData
	{
		// Token: 0x0600418E RID: 16782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418E")]
		[Address(RVA = "0x155230C", Offset = "0x155230C", VA = "0x7BBBD5230C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600418F RID: 16783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600418F")]
		[Address(RVA = "0x1552380", Offset = "0x1552380", VA = "0x7BBBD52380", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004190")]
		[Address(RVA = "0x1552504", Offset = "0x1552504", VA = "0x7BBBD52504")]
		public AssistantAudioData()
		{
		}

		// Token: 0x040050CD RID: 20685
		[Token(Token = "0x40050CD")]
		[FieldOffset(Offset = "0x10")]
		public string VoiceIDName;

		// Token: 0x040050CE RID: 20686
		[Token(Token = "0x40050CE")]
		[FieldOffset(Offset = "0x18")]
		public string Line;

		// Token: 0x040050CF RID: 20687
		[Token(Token = "0x40050CF")]
		[FieldOffset(Offset = "0x20")]
		public string Langsuffix;

		// Token: 0x040050D0 RID: 20688
		[Token(Token = "0x40050D0")]
		[FieldOffset(Offset = "0x28")]
		public uint CharacterID;

		// Token: 0x040050D1 RID: 20689
		[Token(Token = "0x40050D1")]
		[FieldOffset(Offset = "0x2C")]
		public int TriggerType;

		// Token: 0x040050D2 RID: 20690
		[Token(Token = "0x40050D2")]
		[FieldOffset(Offset = "0x30")]
		public ResourceID VoiceID;
	}
}
