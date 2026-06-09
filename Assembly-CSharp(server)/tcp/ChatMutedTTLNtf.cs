using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200046B RID: 1131
	[Token(Token = "0x200046B")]
	[ProtoContract]
	public class ChatMutedTTLNtf
	{
		// Token: 0x06001C9E RID: 7326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9E")]
		[Address(RVA = "0x24A2A90", Offset = "0x24A2A90", VA = "0x7BBCCA2A90")]
		public ChatMutedTTLNtf()
		{
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001C9F RID: 7327 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		// (set) Token: 0x06001CA0 RID: 7328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154D78", Offset = "0x1154D78")]
		public long ttl
		{
			[Token(Token = "0x6001C9F")]
			[Address(RVA = "0x24A2A98", Offset = "0x24A2A98", VA = "0x7BBCCA2A98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11353A4", Offset = "0x11353A4")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001CA0")]
			[Address(RVA = "0x24A2AA0", Offset = "0x24A2AA0", VA = "0x7BBCCA2AA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11353B4", Offset = "0x11353B4")]
			set
			{
			}
		}

		// Token: 0x040014EB RID: 5355
		[Token(Token = "0x40014EB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101F94", Offset = "0x1101F94")]
		private long <ttl>k__BackingField;
	}
}
