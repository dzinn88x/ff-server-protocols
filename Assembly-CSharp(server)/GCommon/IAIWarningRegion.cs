using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EAA RID: 3754
	[Token(Token = "0x2000EAA")]
	public interface IAIWarningRegion
	{
		// Token: 0x06003362 RID: 13154
		[Token(Token = "0x6003362")]
		void OnInit();

		// Token: 0x06003363 RID: 13155
		[Token(Token = "0x6003363")]
		void OnRecycle();

		// Token: 0x06003364 RID: 13156
		[Token(Token = "0x6003364")]
		GameObject GetGameObject();

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06003365 RID: 13157
		[Token(Token = "0x17000679")]
		Transform transform { [Token(Token = "0x6003365")] get; }
	}
}
