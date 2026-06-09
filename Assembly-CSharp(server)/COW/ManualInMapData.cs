using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001141 RID: 4417
	[Token(Token = "0x2001141")]
	public class ManualInMapData : CSVBaseData
	{
		// Token: 0x060044F4 RID: 17652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F4")]
		[Address(RVA = "0x1A55EE0", Offset = "0x1A55EE0", VA = "0x7BBC255EE0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060044F5 RID: 17653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F5")]
		[Address(RVA = "0x1A55EEC", Offset = "0x1A55EEC", VA = "0x7BBC255EEC", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060044F6 RID: 17654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F6")]
		[Address(RVA = "0x1A560B0", Offset = "0x1A560B0", VA = "0x7BBC2560B0")]
		public ManualInMapData()
		{
		}

		// Token: 0x04005520 RID: 21792
		[Token(Token = "0x4005520")]
		[FieldOffset(Offset = "0x10")]
		public uint m_EventID;

		// Token: 0x04005521 RID: 21793
		[Token(Token = "0x4005521")]
		[FieldOffset(Offset = "0x14")]
		public uint m_TypeID;

		// Token: 0x04005522 RID: 21794
		[Token(Token = "0x4005522")]
		[FieldOffset(Offset = "0x18")]
		public uint m_PageID;

		// Token: 0x04005523 RID: 21795
		[Token(Token = "0x4005523")]
		[FieldOffset(Offset = "0x1C")]
		public uint m_LocationID;

		// Token: 0x04005524 RID: 21796
		[Token(Token = "0x4005524")]
		[FieldOffset(Offset = "0x20")]
		public string m_UnLockIcon;

		// Token: 0x04005525 RID: 21797
		[Token(Token = "0x4005525")]
		[FieldOffset(Offset = "0x28")]
		public string m_NameKey;

		// Token: 0x04005526 RID: 21798
		[Token(Token = "0x4005526")]
		[FieldOffset(Offset = "0x30")]
		public string m_IntroKey;

		// Token: 0x04005527 RID: 21799
		[Token(Token = "0x4005527")]
		[FieldOffset(Offset = "0x38")]
		public bool m_link;

		// Token: 0x04005528 RID: 21800
		[Token(Token = "0x4005528")]
		[FieldOffset(Offset = "0x39")]
		public bool m_HaveUnkownFactor;
	}
}
