using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001121 RID: 4385
	[Token(Token = "0x2001121")]
	public class LevelRewardData : CSVBaseData
	{
		// Token: 0x06004493 RID: 17555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004493")]
		[Address(RVA = "0x1402888", Offset = "0x1402888", VA = "0x7BBBC02888", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004494")]
		[Address(RVA = "0x1402894", Offset = "0x1402894", VA = "0x7BBBC02894", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004495 RID: 17557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004495")]
		[Address(RVA = "0x1402ADC", Offset = "0x1402ADC", VA = "0x7BBBC02ADC")]
		private void BuildRewardList()
		{
		}

		// Token: 0x06004496 RID: 17558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004496")]
		[Address(RVA = "0x1402D58", Offset = "0x1402D58", VA = "0x7BBBC02D58")]
		public LevelRewardData()
		{
		}

		// Token: 0x040054AA RID: 21674
		[Token(Token = "0x40054AA")]
		[FieldOffset(Offset = "0x10")]
		public uint m_TargetLevel;

		// Token: 0x040054AB RID: 21675
		[Token(Token = "0x40054AB")]
		[FieldOffset(Offset = "0x14")]
		public uint m_AwardType1;

		// Token: 0x040054AC RID: 21676
		[Token(Token = "0x40054AC")]
		[FieldOffset(Offset = "0x18")]
		public uint m_AwardID1;

		// Token: 0x040054AD RID: 21677
		[Token(Token = "0x40054AD")]
		[FieldOffset(Offset = "0x1C")]
		public uint m_AwardNum1;

		// Token: 0x040054AE RID: 21678
		[Token(Token = "0x40054AE")]
		[FieldOffset(Offset = "0x20")]
		public uint m_AwardMaxNum1;

		// Token: 0x040054AF RID: 21679
		[Token(Token = "0x40054AF")]
		[FieldOffset(Offset = "0x24")]
		public uint m_AwardType2;

		// Token: 0x040054B0 RID: 21680
		[Token(Token = "0x40054B0")]
		[FieldOffset(Offset = "0x28")]
		public uint m_AwardID2;

		// Token: 0x040054B1 RID: 21681
		[Token(Token = "0x40054B1")]
		[FieldOffset(Offset = "0x2C")]
		public uint m_AwardNum2;

		// Token: 0x040054B2 RID: 21682
		[Token(Token = "0x40054B2")]
		[FieldOffset(Offset = "0x30")]
		public uint m_AwardMaxNum2;

		// Token: 0x040054B3 RID: 21683
		[Token(Token = "0x40054B3")]
		[FieldOffset(Offset = "0x34")]
		public uint m_AwardType3;

		// Token: 0x040054B4 RID: 21684
		[Token(Token = "0x40054B4")]
		[FieldOffset(Offset = "0x38")]
		public uint m_AwardID3;

		// Token: 0x040054B5 RID: 21685
		[Token(Token = "0x40054B5")]
		[FieldOffset(Offset = "0x3C")]
		public uint m_AwardNum3;

		// Token: 0x040054B6 RID: 21686
		[Token(Token = "0x40054B6")]
		[FieldOffset(Offset = "0x40")]
		public uint m_AwardMaxNum3;

		// Token: 0x040054B7 RID: 21687
		[Token(Token = "0x40054B7")]
		[FieldOffset(Offset = "0x48")]
		public List<AwardDesc> m_AwardList;
	}
}
