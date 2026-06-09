using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001143 RID: 4419
	[Token(Token = "0x2001143")]
	public class ManualMapReward : CSVBaseData
	{
		// Token: 0x060044FA RID: 17658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044FA")]
		[Address(RVA = "0x1A562DC", Offset = "0x1A562DC", VA = "0x7BBC2562DC", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044FB")]
		[Address(RVA = "0x1A562E8", Offset = "0x1A562E8", VA = "0x7BBC2562E8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044FC")]
		[Address(RVA = "0x1A565E8", Offset = "0x1A565E8", VA = "0x7BBC2565E8")]
		public ManualMapReward()
		{
		}

		// Token: 0x0400552F RID: 21807
		[Token(Token = "0x400552F")]
		[FieldOffset(Offset = "0x10")]
		public uint m_MapID;

		// Token: 0x04005530 RID: 21808
		[Token(Token = "0x4005530")]
		[FieldOffset(Offset = "0x18")]
		public string m_MapTitleKey;

		// Token: 0x04005531 RID: 21809
		[Token(Token = "0x4005531")]
		[FieldOffset(Offset = "0x20")]
		public string m_MapIntroKey;

		// Token: 0x04005532 RID: 21810
		[Token(Token = "0x4005532")]
		[FieldOffset(Offset = "0x28")]
		public uint m_AwardType1;

		// Token: 0x04005533 RID: 21811
		[Token(Token = "0x4005533")]
		[FieldOffset(Offset = "0x30")]
		public string m_AwardName1;

		// Token: 0x04005534 RID: 21812
		[Token(Token = "0x4005534")]
		[FieldOffset(Offset = "0x38")]
		public uint m_AwardID1;

		// Token: 0x04005535 RID: 21813
		[Token(Token = "0x4005535")]
		[FieldOffset(Offset = "0x3C")]
		public uint m_AwardNum1;

		// Token: 0x04005536 RID: 21814
		[Token(Token = "0x4005536")]
		[FieldOffset(Offset = "0x40")]
		public uint m_AwardTime1;

		// Token: 0x04005537 RID: 21815
		[Token(Token = "0x4005537")]
		[FieldOffset(Offset = "0x44")]
		public uint m_AwardType2;

		// Token: 0x04005538 RID: 21816
		[Token(Token = "0x4005538")]
		[FieldOffset(Offset = "0x48")]
		public string m_AwardName2;

		// Token: 0x04005539 RID: 21817
		[Token(Token = "0x4005539")]
		[FieldOffset(Offset = "0x50")]
		public uint m_AwardID2;

		// Token: 0x0400553A RID: 21818
		[Token(Token = "0x400553A")]
		[FieldOffset(Offset = "0x54")]
		public uint m_AwardNum2;

		// Token: 0x0400553B RID: 21819
		[Token(Token = "0x400553B")]
		[FieldOffset(Offset = "0x58")]
		public uint m_AwardTime2;

		// Token: 0x0400553C RID: 21820
		[Token(Token = "0x400553C")]
		[FieldOffset(Offset = "0x5C")]
		public uint m_AwardType3;

		// Token: 0x0400553D RID: 21821
		[Token(Token = "0x400553D")]
		[FieldOffset(Offset = "0x60")]
		public string m_AwardName3;

		// Token: 0x0400553E RID: 21822
		[Token(Token = "0x400553E")]
		[FieldOffset(Offset = "0x68")]
		public uint m_AwardID3;

		// Token: 0x0400553F RID: 21823
		[Token(Token = "0x400553F")]
		[FieldOffset(Offset = "0x6C")]
		public uint m_AwardNum3;

		// Token: 0x04005540 RID: 21824
		[Token(Token = "0x4005540")]
		[FieldOffset(Offset = "0x70")]
		public uint m_AwardTime3;
	}
}
