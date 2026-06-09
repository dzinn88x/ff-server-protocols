using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010EA RID: 4330
	[Token(Token = "0x20010EA")]
	public class EPInGameEffectConfigData : CSVBaseData
	{
		// Token: 0x0600438F RID: 17295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600438F")]
		[Address(RVA = "0x160F384", Offset = "0x160F384", VA = "0x7BBBE0F384", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004390")]
		[Address(RVA = "0x160F390", Offset = "0x160F390", VA = "0x7BBBE0F390", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004391")]
		[Address(RVA = "0x160F4F8", Offset = "0x160F4F8", VA = "0x7BBBE0F4F8")]
		public EPInGameEffectConfigData()
		{
		}

		// Token: 0x0400536F RID: 21359
		[Token(Token = "0x400536F")]
		[FieldOffset(Offset = "0x10")]
		public string Region;

		// Token: 0x04005370 RID: 21360
		[Token(Token = "0x4005370")]
		[FieldOffset(Offset = "0x18")]
		public uint ID;

		// Token: 0x04005371 RID: 21361
		[Token(Token = "0x4005371")]
		[FieldOffset(Offset = "0x1C")]
		public uint EPEventId;

		// Token: 0x04005372 RID: 21362
		[Token(Token = "0x4005372")]
		[FieldOffset(Offset = "0x20")]
		public uint IsOpen;

		// Token: 0x04005373 RID: 21363
		[Token(Token = "0x4005373")]
		[FieldOffset(Offset = "0x24")]
		public ResourceID EffectResource;
	}
}
