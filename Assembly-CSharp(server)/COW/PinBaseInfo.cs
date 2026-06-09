using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001E0D RID: 7693
	[Token(Token = "0x2001E0D")]
	public class PinBaseInfo : CollectionBaseInfo, IComparable<PinBaseInfo>
	{
		// Token: 0x0600A83E RID: 43070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A83E")]
		[Address(RVA = "0x2053280", Offset = "0x2053280", VA = "0x7BBC853280")]
		public PinBaseInfo()
		{
		}

		// Token: 0x0600A83F RID: 43071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A83F")]
		[Address(RVA = "0x2053288", Offset = "0x2053288", VA = "0x7BBC853288")]
		public PinBaseInfo(uint itemid)
		{
		}

		// Token: 0x0600A840 RID: 43072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A840")]
		[Address(RVA = "0x20534E4", Offset = "0x20534E4", VA = "0x7BBC8534E4")]
		public static implicit operator PinBaseInfo(Item it)
		{
			return null;
		}

		// Token: 0x0600A841 RID: 43073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A841")]
		[Address(RVA = "0x2053554", Offset = "0x2053554", VA = "0x7BBC853554")]
		public static implicit operator PinBaseInfo(PinData data)
		{
			return null;
		}

		// Token: 0x0600A842 RID: 43074 RVA: 0x0002D7E0 File Offset: 0x0002B9E0
		[Token(Token = "0x600A842")]
		[Address(RVA = "0x20535C4", Offset = "0x20535C4", VA = "0x7BBC8535C4", Slot = "5")]
		public override uint GetCurrentId()
		{
			return 0U;
		}

		// Token: 0x0600A843 RID: 43075 RVA: 0x0002D7F8 File Offset: 0x0002B9F8
		[Token(Token = "0x600A843")]
		[Address(RVA = "0x2053678", Offset = "0x2053678", VA = "0x7BBC853678", Slot = "6")]
		public int CompareTo(PinBaseInfo other)
		{
			return 0;
		}

		// Token: 0x0400ADB0 RID: 44464
		[Token(Token = "0x400ADB0")]
		[FieldOffset(Offset = "0x38")]
		public PinData pin_data;
	}
}
