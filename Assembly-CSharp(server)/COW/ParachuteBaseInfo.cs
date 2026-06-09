using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001E0A RID: 7690
	[Token(Token = "0x2001E0A")]
	public class ParachuteBaseInfo : CollectionBaseInfo, IComparable<ParachuteBaseInfo>
	{
		// Token: 0x0600A82C RID: 43052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A82C")]
		[Address(RVA = "0x203D63C", Offset = "0x203D63C", VA = "0x7BBC83D63C")]
		public ParachuteBaseInfo()
		{
		}

		// Token: 0x0600A82D RID: 43053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A82D")]
		[Address(RVA = "0x203D644", Offset = "0x203D644", VA = "0x7BBC83D644")]
		public ParachuteBaseInfo(uint itemid)
		{
		}

		// Token: 0x0600A82E RID: 43054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A82E")]
		[Address(RVA = "0x203D89C", Offset = "0x203D89C", VA = "0x7BBC83D89C")]
		public static implicit operator ParachuteBaseInfo(Item it)
		{
			return null;
		}

		// Token: 0x0600A82F RID: 43055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A82F")]
		[Address(RVA = "0x203D90C", Offset = "0x203D90C", VA = "0x7BBC83D90C")]
		public static implicit operator ParachuteBaseInfo(ParachuteData data)
		{
			return null;
		}

		// Token: 0x0600A830 RID: 43056 RVA: 0x0002D750 File Offset: 0x0002B950
		[Token(Token = "0x600A830")]
		[Address(RVA = "0x203D97C", Offset = "0x203D97C", VA = "0x7BBC83D97C", Slot = "5")]
		public override uint GetCurrentId()
		{
			return 0U;
		}

		// Token: 0x0600A831 RID: 43057 RVA: 0x0002D768 File Offset: 0x0002B968
		[Token(Token = "0x600A831")]
		[Address(RVA = "0x203DA30", Offset = "0x203DA30", VA = "0x7BBC83DA30", Slot = "6")]
		public int CompareTo(ParachuteBaseInfo other)
		{
			return 0;
		}

		// Token: 0x0400ADAD RID: 44461
		[Token(Token = "0x400ADAD")]
		[FieldOffset(Offset = "0x38")]
		public ParachuteData parachute_data;
	}
}
