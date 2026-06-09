using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02001012 RID: 4114
	[Token(Token = "0x2001012")]
	public interface IShare
	{
		// Token: 0x06003DDF RID: 15839
		[Token(Token = "0x6003DDF")]
		void BeforeScreenshot();

		// Token: 0x06003DE0 RID: 15840
		[Token(Token = "0x6003DE0")]
		void AfterScreenshot();

		// Token: 0x06003DE1 RID: 15841
		[Token(Token = "0x6003DE1")]
		void BeforeSharePreview();

		// Token: 0x06003DE2 RID: 15842
		[Token(Token = "0x6003DE2")]
		void AfterSharePreview();

		// Token: 0x06003DE3 RID: 15843
		[Token(Token = "0x6003DE3")]
		void OnShare(bool success, int platform);
	}
}
