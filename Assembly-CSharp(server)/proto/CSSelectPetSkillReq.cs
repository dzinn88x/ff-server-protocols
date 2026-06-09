using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200072A RID: 1834
	[Token(Token = "0x200072A")]
	[ProtoContract]
	public class CSSelectPetSkillReq
	{
		// Token: 0x06002437 RID: 9271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002437")]
		[Address(RVA = "0x21B75E0", Offset = "0x21B75E0", VA = "0x7BBC9B75E0")]
		public CSSelectPetSkillReq()
		{
		}

		// Token: 0x04002467 RID: 9319
		[Token(Token = "0x4002467")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C3DC", Offset = "0x110C3DC")]
		public uint pet_id;

		// Token: 0x04002468 RID: 9320
		[Token(Token = "0x4002468")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C3F0", Offset = "0x110C3F0")]
		public uint skill_id;
	}
}
