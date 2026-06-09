using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000603 RID: 1539
	[Token(Token = "0x2000603")]
	[ProtoContract]
	public class AvatarDispatchStatus
	{
		// Token: 0x0600237F RID: 9087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237F")]
		[Address(RVA = "0x21AF4A0", Offset = "0x21AF4A0", VA = "0x7BBC9AF4A0")]
		public AvatarDispatchStatus()
		{
		}

		// Token: 0x04001EB4 RID: 7860
		[Token(Token = "0x4001EB4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106FA4", Offset = "0x1106FA4")]
		public uint avatar_id;

		// Token: 0x04001EB5 RID: 7861
		[Token(Token = "0x4001EB5")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106FB8", Offset = "0x1106FB8")]
		public EProfile.DispatchLine status;
	}
}
