using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001DA1 RID: 7585
	[Token(Token = "0x2001DA1")]
	public class RollNoticeData
	{
		// Token: 0x0600A5E0 RID: 42464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5E0")]
		[Address(RVA = "0x175E4A8", Offset = "0x175E4A8", VA = "0x7BBBF5E4A8")]
		public RollNoticeData(string ct, EAnnouncement.NavigationType t = EAnnouncement.NavigationType.NavigationType_NONE, EBroadCastType broadCastType = EBroadCastType.None, [Optional] object obj)
		{
		}

		// Token: 0x0600A5E1 RID: 42465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A5E1")]
		[Address(RVA = "0x175E548", Offset = "0x175E548", VA = "0x7BBBF5E548")]
		public static implicit operator RollNoticeData(ScrollMarqueeDesc desc)
		{
			return null;
		}

		// Token: 0x0600A5E2 RID: 42466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A5E2")]
		[Address(RVA = "0x175E67C", Offset = "0x175E67C", VA = "0x7BBBF5E67C")]
		public static implicit operator RollNoticeData(BroadcastMessage msg)
		{
			return null;
		}

		// Token: 0x0600A5E3 RID: 42467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A5E3")]
		[Address(RVA = "0x175E79C", Offset = "0x175E79C", VA = "0x7BBBF5E79C")]
		public static implicit operator RollNoticeData(MessageInfo msg)
		{
			return null;
		}

		// Token: 0x0600A5E4 RID: 42468 RVA: 0x0002C580 File Offset: 0x0002A780
		[Token(Token = "0x600A5E4")]
		[Address(RVA = "0x175E9A0", Offset = "0x175E9A0", VA = "0x7BBBF5E9A0")]
		public bool IsSpecial()
		{
			return default(bool);
		}

		// Token: 0x0600A5E5 RID: 42469 RVA: 0x0002C598 File Offset: 0x0002A798
		[Token(Token = "0x600A5E5")]
		[Address(RVA = "0x175E9B4", Offset = "0x175E9B4", VA = "0x7BBBF5E9B4")]
		public bool IsGM()
		{
			return default(bool);
		}

		// Token: 0x0400AB8C RID: 43916
		[Token(Token = "0x400AB8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string content;

		// Token: 0x0400AB8D RID: 43917
		[Token(Token = "0x400AB8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EAnnouncement.NavigationType navType;

		// Token: 0x0400AB8E RID: 43918
		[Token(Token = "0x400AB8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string gos_url;

		// Token: 0x0400AB8F RID: 43919
		[Token(Token = "0x400AB8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string sub_go_pos;

		// Token: 0x0400AB90 RID: 43920
		[Token(Token = "0x400AB90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool use_embedded_browser;

		// Token: 0x0400AB91 RID: 43921
		[Token(Token = "0x400AB91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int go_pos;

		// Token: 0x0400AB92 RID: 43922
		[Token(Token = "0x400AB92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EBroadCastType bc_type;

		// Token: 0x0400AB93 RID: 43923
		[Token(Token = "0x400AB93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public object ext;
	}
}
