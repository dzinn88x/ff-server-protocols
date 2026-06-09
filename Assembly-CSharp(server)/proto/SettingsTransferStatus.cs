using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009C5 RID: 2501
	[Token(Token = "0x20009C5")]
	[ProtoContract]
	public enum SettingsTransferStatus
	{
		// Token: 0x04002CCA RID: 11466
		[Token(Token = "0x4002CCA")]
		NONE,
		// Token: 0x04002CCB RID: 11467
		[Token(Token = "0x4002CCB")]
		NOTFOUNDBYACCOUNT,
		// Token: 0x04002CCC RID: 11468
		[Token(Token = "0x4002CCC")]
		NOTEXISTSAMEVERSION,
		// Token: 0x04002CCD RID: 11469
		[Token(Token = "0x4002CCD")]
		FOUNDSAMEVERSION
	}
}
