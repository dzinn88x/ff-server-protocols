using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200089B RID: 2203
	[Token(Token = "0x200089B")]
	[ProtoContract]
	public class CSGetAndroidApplicationToDetectRes
	{
		// Token: 0x060025A9 RID: 9641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A9")]
		[Address(RVA = "0x21B1F28", Offset = "0x21B1F28", VA = "0x7BBC9B1F28")]
		public CSGetAndroidApplicationToDetectRes()
		{
		}

		// Token: 0x040028FA RID: 10490
		[Token(Token = "0x40028FA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113E20", Offset = "0x1113E20")]
		public List<AndroidApplicationToDetectDesc> android_apps_to_detect_res;
	}
}
