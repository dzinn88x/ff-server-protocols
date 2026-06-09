using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B57 RID: 2903
	[Token(Token = "0x2000B57")]
	[ProtoContract]
	public class MuteSwitchDesc
	{
		// Token: 0x0600285F RID: 10335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285F")]
		[Address(RVA = "0x249E59C", Offset = "0x249E59C", VA = "0x7BBCC9E59C")]
		public MuteSwitchDesc()
		{
		}

		// Token: 0x04003745 RID: 14149
		[Token(Token = "0x4003745")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E770", Offset = "0x112E770")]
		public bool enable_api_data;

		// Token: 0x04003746 RID: 14150
		[Token(Token = "0x4003746")]
		[FieldOffset(Offset = "0x11")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E784", Offset = "0x112E784")]
		public bool mute_switch;
	}
}
