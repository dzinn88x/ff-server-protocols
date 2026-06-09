using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000783 RID: 1923
	[Token(Token = "0x2000783")]
	[ProtoContract]
	public class BundleShow
	{
		// Token: 0x06002492 RID: 9362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002492")]
		[Address(RVA = "0x21AFFBC", Offset = "0x21AFFBC", VA = "0x7BBC9AFFBC")]
		public BundleShow()
		{
		}

		// Token: 0x0400256F RID: 9583
		[Token(Token = "0x400256F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DF5C", Offset = "0x110DF5C")]
		public uint id;

		// Token: 0x04002570 RID: 9584
		[Token(Token = "0x4002570")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DF70", Offset = "0x110DF70")]
		public List<BundleShowData> bundles;
	}
}
