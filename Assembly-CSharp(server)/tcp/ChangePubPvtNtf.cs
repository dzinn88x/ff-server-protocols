using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200049B RID: 1179
	[Token(Token = "0x200049B")]
	[ProtoContract]
	public class ChangePubPvtNtf
	{
		// Token: 0x06001DA3 RID: 7587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DA3")]
		[Address(RVA = "0x24A29CC", Offset = "0x24A29CC", VA = "0x7BBCCA29CC")]
		public ChangePubPvtNtf()
		{
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x0000CA50 File Offset: 0x0000AC50
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F2")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155C14", Offset = "0x1155C14")]
		public bool is_public
		{
			[Token(Token = "0x6001DA4")]
			[Address(RVA = "0x24A29D4", Offset = "0x24A29D4", VA = "0x7BBCCA29D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136224", Offset = "0x1136224")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001DA5")]
			[Address(RVA = "0x24A29DC", Offset = "0x24A29DC", VA = "0x7BBCCA29DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136234", Offset = "0x1136234")]
			set
			{
			}
		}

		// Token: 0x04001617 RID: 5655
		[Token(Token = "0x4001617")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11026D4", Offset = "0x11026D4")]
		private bool <is_public>k__BackingField;
	}
}
