using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010CE RID: 4302
	[Token(Token = "0x20010CE")]
	public class WeaponSkinPropertyScore : CSVBaseData
	{
		// Token: 0x06004310 RID: 17168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004310")]
		[Address(RVA = "0x179FB78", Offset = "0x179FB78", VA = "0x7BBBF9FB78", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004311")]
		[Address(RVA = "0x179FB84", Offset = "0x179FB84", VA = "0x7BBBF9FB84", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004312")]
		[Address(RVA = "0x17A0254", Offset = "0x17A0254", VA = "0x7BBBFA0254")]
		public WeaponSkinPropertyScore()
		{
		}

		// Token: 0x04005281 RID: 21121
		[Token(Token = "0x4005281")]
		[FieldOffset(Offset = "0x10")]
		public int[] Property;

		// Token: 0x04005282 RID: 21122
		[Token(Token = "0x4005282")]
		[FieldOffset(Offset = "0x18")]
		public string Region;

		// Token: 0x04005283 RID: 21123
		[Token(Token = "0x4005283")]
		[FieldOffset(Offset = "0x20")]
		public uint SkinID;
	}
}
