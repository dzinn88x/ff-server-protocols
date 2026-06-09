using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001142 RID: 4418
	[Token(Token = "0x2001142")]
	public class ManualMapData : CSVBaseData
	{
		// Token: 0x060044F7 RID: 17655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F7")]
		[Address(RVA = "0x1A56118", Offset = "0x1A56118", VA = "0x7BBC256118", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F8")]
		[Address(RVA = "0x1A56124", Offset = "0x1A56124", VA = "0x7BBC256124", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F9")]
		[Address(RVA = "0x1A56274", Offset = "0x1A56274", VA = "0x7BBC256274")]
		public ManualMapData()
		{
		}

		// Token: 0x04005529 RID: 21801
		[Token(Token = "0x4005529")]
		[FieldOffset(Offset = "0x10")]
		public uint m_EventID;

		// Token: 0x0400552A RID: 21802
		[Token(Token = "0x400552A")]
		[FieldOffset(Offset = "0x14")]
		public uint m_MapID;

		// Token: 0x0400552B RID: 21803
		[Token(Token = "0x400552B")]
		[FieldOffset(Offset = "0x18")]
		public uint m_LocationID;

		// Token: 0x0400552C RID: 21804
		[Token(Token = "0x400552C")]
		[FieldOffset(Offset = "0x1C")]
		public uint m_FragmentRadius;

		// Token: 0x0400552D RID: 21805
		[Token(Token = "0x400552D")]
		[FieldOffset(Offset = "0x20")]
		public string m_TriggerName;

		// Token: 0x0400552E RID: 21806
		[Token(Token = "0x400552E")]
		[FieldOffset(Offset = "0x28")]
		public string FragmentName;
	}
}
