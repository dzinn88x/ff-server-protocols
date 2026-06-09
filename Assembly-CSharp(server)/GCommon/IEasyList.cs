using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02001021 RID: 4129
	[Token(Token = "0x2001021")]
	public interface IEasyList
	{
		// Token: 0x06003E69 RID: 15977
		[Token(Token = "0x6003E69")]
		UIEasyListItemController OpenItemController(Transform parent);

		// Token: 0x06003E6A RID: 15978
		[Token(Token = "0x6003E6A")]
		void CloseItemController(UIEasyListItemController itemController);
	}
}
