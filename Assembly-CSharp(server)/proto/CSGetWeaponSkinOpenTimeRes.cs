using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200096B RID: 2411
	[Token(Token = "0x200096B")]
	[ProtoContract]
	public class CSGetWeaponSkinOpenTimeRes
	{
		// Token: 0x06002679 RID: 9849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002679")]
		[Address(RVA = "0x21B62F4", Offset = "0x21B62F4", VA = "0x7BBC9B62F4")]
		public CSGetWeaponSkinOpenTimeRes()
		{
		}

		// Token: 0x04002BFE RID: 11262
		[Token(Token = "0x4002BFE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111976C", Offset = "0x111976C")]
		public List<WeaponSkinOpenTimeDesc> weapon_skin_open_time_desc;
	}
}
