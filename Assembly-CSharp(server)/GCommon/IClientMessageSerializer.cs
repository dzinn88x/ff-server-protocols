using System;
using System.IO;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F71 RID: 3953
	[Token(Token = "0x2000F71")]
	public interface IClientMessageSerializer
	{
		// Token: 0x0600398B RID: 14731
		[Token(Token = "0x600398B")]
		void Serialize(BinaryWriter writer);

		// Token: 0x0600398C RID: 14732
		[Token(Token = "0x600398C")]
		void UnSerialize(BinaryReader reader);
	}
}
