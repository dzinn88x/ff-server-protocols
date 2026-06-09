using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001174 RID: 4468
	[Token(Token = "0x2001174")]
	public class ProfileMapThresholdData : CSVBaseData
	{
		// Token: 0x0600458E RID: 17806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458E")]
		[Address(RVA = "0x174F288", Offset = "0x174F288", VA = "0x7BBBF4F288", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600458F")]
		[Address(RVA = "0x174F290", Offset = "0x174F290", VA = "0x7BBBF4F290", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x00015258 File Offset: 0x00013458
		[Token(Token = "0x6004590")]
		[Address(RVA = "0x174F43C", Offset = "0x174F43C", VA = "0x7BBBF4F43C")]
		public float GetValuePos(float value)
		{
			return 0f;
		}

		// Token: 0x06004591 RID: 17809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004591")]
		[Address(RVA = "0x174F5E8", Offset = "0x174F5E8", VA = "0x7BBBF4F5E8")]
		public ProfileMapThresholdData()
		{
		}

		// Token: 0x04005676 RID: 22134
		[Token(Token = "0x4005676")]
		[FieldOffset(Offset = "0x10")]
		public string FieldName;

		// Token: 0x04005677 RID: 22135
		[Token(Token = "0x4005677")]
		[FieldOffset(Offset = "0x18")]
		public float[] Thresholds;
	}
}
