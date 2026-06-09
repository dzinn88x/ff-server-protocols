using System;
using Il2CppDummyDll;
using tcp;

namespace COW
{
	// Token: 0x02001DD9 RID: 7641
	[Token(Token = "0x2001DD9")]
	public class ChatChannelInfo
	{
		// Token: 0x0600A6E0 RID: 42720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A6E0")]
		[Address(RVA = "0x14F49D0", Offset = "0x14F49D0", VA = "0x7BBBCF49D0")]
		public ChatChannelInfo(EChannel.ChannelType type, ulong id)
		{
		}

		// Token: 0x0600A6E1 RID: 42721 RVA: 0x0002CD78 File Offset: 0x0002AF78
		[Token(Token = "0x600A6E1")]
		[Address(RVA = "0x14F4A0C", Offset = "0x14F4A0C", VA = "0x7BBBCF4A0C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600A6E2 RID: 42722 RVA: 0x0002CD90 File Offset: 0x0002AF90
		[Token(Token = "0x600A6E2")]
		[Address(RVA = "0x14F4AD4", Offset = "0x14F4AD4", VA = "0x7BBBCF4AD4", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400AC88 RID: 44168
		[Token(Token = "0x400AC88")]
		[FieldOffset(Offset = "0x10")]
		public EChannel.ChannelType m_ChannelType;

		// Token: 0x0400AC89 RID: 44169
		[Token(Token = "0x400AC89")]
		[FieldOffset(Offset = "0x18")]
		public ulong m_ChannelID;
	}
}
