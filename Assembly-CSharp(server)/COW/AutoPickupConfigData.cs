using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001099 RID: 4249
	[Token(Token = "0x2001099")]
	public class AutoPickupConfigData : CSVBaseData
	{
		// Token: 0x06004194 RID: 16788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004194")]
		[Address(RVA = "0x1555B64", Offset = "0x1555B64", VA = "0x7BBBD55B64", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004195 RID: 16789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004195")]
		[Address(RVA = "0x1555DB8", Offset = "0x1555DB8", VA = "0x7BBBD55DB8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004196 RID: 16790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004196")]
		[Address(RVA = "0x1555DC0", Offset = "0x1555DC0", VA = "0x7BBBD55DC0")]
		public string GetNewKey()
		{
			return null;
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004197")]
		[Address(RVA = "0x1555934", Offset = "0x1555934", VA = "0x7BBBD55934")]
		public void RefreshKeyState()
		{
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x00014220 File Offset: 0x00012420
		[Token(Token = "0x6004198")]
		[Address(RVA = "0x1555DC8", Offset = "0x1555DC8", VA = "0x7BBBD55DC8")]
		public EAutoPickup GetDefaultAutoPickUpSetting()
		{
			return EAutoPickup.On;
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x00014238 File Offset: 0x00012438
		[Token(Token = "0x6004199")]
		[Address(RVA = "0x1555924", Offset = "0x1555924", VA = "0x7BBBD55924")]
		public bool canAutoPickUp()
		{
			return default(bool);
		}

		// Token: 0x0600419A RID: 16794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600419A")]
		[Address(RVA = "0x1555E34", Offset = "0x1555E34", VA = "0x7BBBD55E34")]
		public AutoPickupConfigData()
		{
		}

		// Token: 0x040050D7 RID: 20695
		[Token(Token = "0x40050D7")]
		[FieldOffset(Offset = "0x10")]
		public int Id;

		// Token: 0x040050D8 RID: 20696
		[Token(Token = "0x40050D8")]
		[FieldOffset(Offset = "0x18")]
		public uint[] ItemTypes;

		// Token: 0x040050D9 RID: 20697
		[Token(Token = "0x40050D9")]
		[FieldOffset(Offset = "0x20")]
		public uint[] SubTypes;

		// Token: 0x040050DA RID: 20698
		[Token(Token = "0x40050DA")]
		[FieldOffset(Offset = "0x28")]
		public string LocKey;

		// Token: 0x040050DB RID: 20699
		[Token(Token = "0x40050DB")]
		[FieldOffset(Offset = "0x30")]
		public bool IsDefaultOpen;

		// Token: 0x040050DC RID: 20700
		[Token(Token = "0x40050DC")]
		[FieldOffset(Offset = "0x38")]
		private string primaryKey;

		// Token: 0x040050DD RID: 20701
		[Token(Token = "0x40050DD")]
		[FieldOffset(Offset = "0x40")]
		private string m_NewKey;

		// Token: 0x040050DE RID: 20702
		[Token(Token = "0x40050DE")]
		[FieldOffset(Offset = "0x48")]
		private int m_switch;
	}
}
