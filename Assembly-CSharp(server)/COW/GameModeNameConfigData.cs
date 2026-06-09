using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001148 RID: 4424
	[Token(Token = "0x2001148")]
	public class GameModeNameConfigData : CSVBaseData
	{
		// Token: 0x0600450C RID: 17676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450C")]
		[Address(RVA = "0x187EBB0", Offset = "0x187EBB0", VA = "0x7BBC07EBB0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600450D")]
		[Address(RVA = "0x187EBBC", Offset = "0x187EBBC", VA = "0x7BBC07EBBC", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600450E")]
		[Address(RVA = "0x187ED34", Offset = "0x187ED34", VA = "0x7BBC07ED34")]
		public GameModeNameConfigData()
		{
		}

		// Token: 0x04005571 RID: 21873
		[Token(Token = "0x4005571")]
		[FieldOffset(Offset = "0x10")]
		public uint ModeID;

		// Token: 0x04005572 RID: 21874
		[Token(Token = "0x4005572")]
		[FieldOffset(Offset = "0x18")]
		public string ModeName;

		// Token: 0x04005573 RID: 21875
		[Token(Token = "0x4005573")]
		[FieldOffset(Offset = "0x20")]
		public string ModeSelectIcon;
	}
}
