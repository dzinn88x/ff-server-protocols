using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001E10 RID: 7696
	[Token(Token = "0x2001E10")]
	public class EmoteBaseInfo : CollectionBaseInfo, IComparable<EmoteBaseInfo>
	{
		// Token: 0x0600A84E RID: 43086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A84E")]
		[Address(RVA = "0x1B852BC", Offset = "0x1B852BC", VA = "0x7BBC3852BC")]
		public EmoteBaseInfo()
		{
		}

		// Token: 0x0600A84F RID: 43087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A84F")]
		[Address(RVA = "0x1B852C4", Offset = "0x1B852C4", VA = "0x7BBC3852C4")]
		public EmoteBaseInfo(uint itemid)
		{
		}

		// Token: 0x0600A850 RID: 43088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A850")]
		[Address(RVA = "0x1B8551C", Offset = "0x1B8551C", VA = "0x7BBC38551C")]
		public static implicit operator EmoteBaseInfo(Item it)
		{
			return null;
		}

		// Token: 0x0600A851 RID: 43089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A851")]
		[Address(RVA = "0x1B8558C", Offset = "0x1B8558C", VA = "0x7BBC38558C")]
		public static implicit operator EmoteBaseInfo(EmoteData data)
		{
			return null;
		}

		// Token: 0x0600A852 RID: 43090 RVA: 0x0002D840 File Offset: 0x0002BA40
		[Token(Token = "0x600A852")]
		[Address(RVA = "0x1B855FC", Offset = "0x1B855FC", VA = "0x7BBC3855FC", Slot = "6")]
		public int CompareTo(EmoteBaseInfo other)
		{
			return 0;
		}

		// Token: 0x0400ADB5 RID: 44469
		[Token(Token = "0x400ADB5")]
		[FieldOffset(Offset = "0x38")]
		public EmoteData emote_data;

		// Token: 0x0400ADB6 RID: 44470
		[Token(Token = "0x400ADB6")]
		[FieldOffset(Offset = "0x40")]
		public uint emoteId;
	}
}
